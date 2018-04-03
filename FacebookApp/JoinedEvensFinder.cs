using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using C17_Ex02_Antonio_205707284_Yarden_204718738;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class JointedEvensFinder : IJoinedItemsFinder
    {
        public FacebookObjectCollection<IPictureAndNameOwner> GetJoinedItems(User i_User1, User i_User2)
        {
            return findJoinedEvents(i_User1, i_User2);
        }

        private FacebookObjectCollection<IPictureAndNameOwner> findJoinedEvents(User i_User1, User i_User2)
        {
            return getJoinedEvents(i_User1, i_User2);
        }

        private FacebookObjectCollection<IPictureAndNameOwner> getJoinedEvents(User i_User1, User i_User2)
        {
            FacebookObjectCollection<IPictureAndNameOwner> joinedEvents = null;

            try
            {
                if (i_User2 != null)
                {
                    joinedEvents = new FacebookObjectCollection<IPictureAndNameOwner>();
                    if (i_User1.Events != null)
                    {
                        foreach (Event userEvent in i_User1.Events)
                        {
                            foreach (User attendingUser in userEvent.AttendingUsers)
                            {
                                if (attendingUser.Id == i_User2.Id)
                                {
                                    joinedEvents.Add(new EventAdapter(userEvent));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { // don't do nothing when we are loging out at the mainThread
            }

            return joinedEvents;
        }
    }
}
