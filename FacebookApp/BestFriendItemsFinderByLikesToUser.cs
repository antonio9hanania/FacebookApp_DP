using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class BestFriendItemsFinderByLikesToUser : BestFriendItemsFinder
    {
        public override User FindBestFriend()
        {
            return findBestFriend(User);
        }

        private User findBestFriend(User i_User)
        {
            return (new UserBestLikers(User)).GetUserWithMaxLikes();
        }
    }
}
