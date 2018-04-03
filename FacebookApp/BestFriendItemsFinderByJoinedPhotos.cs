using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class BestFriendItemsFinderByJoinedPhotos : BestFriendItemsFinder
    {
        public override User FindBestFriend()
        {
           return findBestFriend(User);
        }

        private User findBestFriend(User i_User)
        {
            Dictionary<string, User> UsersTaggedInDictionary = new Dictionary<string, User>();
            Dictionary<string, int> UsersCounterTaggedInDictionary = new Dictionary<string, int>();
            User bestFriend = null;

            try
            {
                if (i_User.Albums != null)
                {
                    foreach (Album userAlbum in i_User.Albums)
                    {
                        if (userAlbum != null)
                        {
                            foreach (Photo picture in userAlbum.Photos)
                            {
                                if (picture.Tags != null)
                                {
                                    foreach (PhotoTag userTaggedFriend in picture.Tags)
                                    {
                                        if (!UsersTaggedInDictionary.ContainsKey(userTaggedFriend.User.Id) && userTaggedFriend.User.Id != i_User.Id && !string.IsNullOrEmpty(userTaggedFriend.User.Id))
                                        {
                                            UsersTaggedInDictionary.Add(userTaggedFriend.User.Id, userTaggedFriend.User);
                                            UsersCounterTaggedInDictionary.Add(userTaggedFriend.User.Id, 1);
                                        }
                                        else
                                        {
                                            if (userTaggedFriend.User.Id != i_User.Id && !string.IsNullOrEmpty(userTaggedFriend.User.Id))
                                            {
                                                UsersCounterTaggedInDictionary[userTaggedFriend.User.Id]++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                string bestFriendId = findMaxTaggedIdFriend(UsersCounterTaggedInDictionary);

                if (!string.IsNullOrEmpty(bestFriendId))
                {
                    bestFriend = UsersTaggedInDictionary[bestFriendId];
                }
            }
            catch(Exception ex)
            { // don't do nothing when we are loging out at the mainThread
            }

            return bestFriend;
        }

        private string findMaxTaggedIdFriend(Dictionary<string, int> i_TaggedInPhotosDictionary)
        {
            int maxFriendTags = -1;
            string bestFriendId = string.Empty;

            foreach (KeyValuePair<string, int> friendTags in i_TaggedInPhotosDictionary)
            {
                if (friendTags.Value > maxFriendTags)
                {
                    bestFriendId = friendTags.Key;
                    maxFriendTags = friendTags.Value;
                }
            }

            return bestFriendId;
        }
    }
}