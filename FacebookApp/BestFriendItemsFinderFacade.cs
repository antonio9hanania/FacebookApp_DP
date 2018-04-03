using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class BestFriendItemsFinderFacade
    {
        public User LoggedInUser { get; set; }

        private BestFriendItemsFinder m_BestFriendItemsFinder;

        public event Action<FacebookObjectCollection<IPictureAndNameOwner>> m_OnItemsFind;

        public event Action<User> m_OnBestFriendFind;

        public void SetJoinedEventsFinder()
        {
            SetJoinedItemsFinder(typeof(JointedEvensFinder));
        }

        public void SetJoinedPagesFinder()
        {
            SetJoinedItemsFinder(typeof(JoinedPagesFinder));
        }

        private void SetBestFriendItemsFinder(Type i_Type)
        {
            m_BestFriendItemsFinder = BestFriendItemsFinderFactory.Create(i_Type);
            m_BestFriendItemsFinder.User = LoggedInUser;
        }

        private void SetJoinedItemsFinder(Type i_Type)
        {
            m_BestFriendItemsFinder.JoinedItemsFinder = JoinedItemsFinderFactory.Create(i_Type);
        }

        public void GetResults()
        {
            User bestFriend = m_BestFriendItemsFinder.FindBestFriend();
            dispatchBestFriend(bestFriend);
            if(bestFriend != null)
            {
                FacebookObjectCollection<IPictureAndNameOwner> joinedItems = m_BestFriendItemsFinder.FindFriendsItems(bestFriend);
                dispatchItems(joinedItems);
            }
        }

        private void dispatchBestFriend(User i_BestFriend)
        {
            if (m_OnBestFriendFind != null)
            {
                m_OnBestFriendFind.Invoke(i_BestFriend);
            }
        }

        private void dispatchItems(FacebookObjectCollection<IPictureAndNameOwner> i_JoinedItems)
        {
            if (m_OnItemsFind != null)
            {
                m_OnItemsFind.Invoke(i_JoinedItems);
            }
        }

        internal void SetLookByLikes()
        {
            SetBestFriendItemsFinder(typeof(BestFriendItemsFinderByLikesToUser));
        }

        internal void SetLookByJoinedPhotos()
        {
            SetBestFriendItemsFinder(typeof(BestFriendItemsFinderByJoinedPhotos));
        }
    }
}
