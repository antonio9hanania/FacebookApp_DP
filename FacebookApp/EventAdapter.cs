using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class EventAdapter : IPictureAndNameOwner
    {
        private Event m_Event;

        public EventAdapter(Event i_Event)
        {
            m_Event = i_Event;
        }

        public System.Drawing.Image ImageNormal
        {
            get
            {
                return m_Event.ImageNormal;
            }
        }

        public string Name
        {
            get
            {
                return m_Event.Name;
            }
        }
    }
}
