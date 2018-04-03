using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public abstract class BestFriendItemsFinder
    {
        public User User { get; set; }

        public IJoinedItemsFinder JoinedItemsFinder { get; set; }

        public abstract User FindBestFriend();

        public FacebookObjectCollection<IPictureAndNameOwner> FindFriendsItems(User i_Friend)
        {
            FacebookObjectCollection<IPictureAndNameOwner> joinedItems = JoinedItemsFinder.GetJoinedItems(User, i_Friend);

            return joinedItems;
        }
    }
}
