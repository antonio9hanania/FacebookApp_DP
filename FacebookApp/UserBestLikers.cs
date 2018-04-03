using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class UserBestLikers
    {
        private Dictionary<string, User> m_UsersDictionary;
        private Dictionary<string, int> m_LikesCounterDictionary;
        private User m_User;

        public event Action<List<KeyValuePair<User, int>>> m_OnBestLikersCalc;

        public UserBestLikers(User i_User)
        {
            m_User = i_User;
        }

        private void fetchPostsLikers()
        {
            m_UsersDictionary = new Dictionary<string, User>();
            m_LikesCounterDictionary = new Dictionary<string, int>();

            try
            {
                FacebookObjectCollection<Post> UserPosts = m_User.Posts;
                if (UserPosts != null)
                {
                    foreach (Post post in UserPosts)
                    {
                        if (post.Message != null)
                        {
                            foreach (User friend in post.LikedBy)
                            {
                                if (!m_LikesCounterDictionary.ContainsKey(friend.Id))
                                {
                                    m_LikesCounterDictionary.Add(friend.Id, -1);
                                    m_UsersDictionary.Add(friend.Id, friend);
                                }
                                else
                                {
                                    m_LikesCounterDictionary[friend.Id]--;
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            { // don't do nothing when we are loging out at the mainThread
            }
        }

        private List<KeyValuePair<User, int>> sortUsernamesByLikesCount()
        {
            List<KeyValuePair<string, int>> m_FriendIdSortedByLikingLvl = m_LikesCounterDictionary.ToList();

            m_FriendIdSortedByLikingLvl.Sort(delegate(KeyValuePair<string, int> i_FirstLikesNum, KeyValuePair<string, int> i_SecondLikesNum)
            {
                return i_FirstLikesNum.Value.CompareTo(i_SecondLikesNum.Value);
            });

            List<KeyValuePair<User, int>> UserThatLikesMeTheMost = new List<KeyValuePair<User, int>>();
            foreach (var friend in m_FriendIdSortedByLikingLvl)
            {
                UserThatLikesMeTheMost.Add(new KeyValuePair<User, int>(m_UsersDictionary[friend.Key], friend.Value));
            }

            return UserThatLikesMeTheMost;
        }

        public void Run()
        {
            this.fetchPostsLikers();
            m_OnBestLikersCalc.Invoke(sortUsernamesByLikesCount());
        }

        public User GetUserWithMaxLikes()
        {
            this.fetchPostsLikers();
            return sortUsernamesByLikesCount()[0].Key;
        }
    }
}
