using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public interface IJoinedItemsFinder
    {
        FacebookObjectCollection<IPictureAndNameOwner> GetJoinedItems(User i_User1, User i_User2);
    }
}
