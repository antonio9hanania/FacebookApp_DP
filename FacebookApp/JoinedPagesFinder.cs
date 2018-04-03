using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class JoinedPagesFinder : IJoinedItemsFinder
    {
        public FacebookObjectCollection<IPictureAndNameOwner> GetJoinedItems(User i_User1, User i_User2)
        {
            return findJoinedPages(i_User1, i_User2);
        }

        private FacebookObjectCollection<IPictureAndNameOwner> findJoinedPages(User i_User1, User i_User2)
        {
            return getJoinedPages(i_User1, i_User2);
        }

        private FacebookObjectCollection<IPictureAndNameOwner> getJoinedPages(User i_User1, User i_User2)
        {
            FacebookObjectCollection<IPictureAndNameOwner> joinedPages = null;

            try
            {
                if (i_User2 != null)
                {
                    joinedPages = new FacebookObjectCollection<IPictureAndNameOwner>();
                    if (i_User1.LikedPages != null)
                    {
                        foreach (Page user1LikedPage in i_User1.LikedPages)
                        {
                            foreach (Page user2LikedPage in i_User2.LikedPages)
                            {
                                if (user1LikedPage.Id == user2LikedPage.Id)
                                {
                                    joinedPages.Add(new PageAdapter(user1LikedPage));
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            { // don't do nothing when we are loging out at the mainThread
            }

            return joinedPages;
        }
    }
}
