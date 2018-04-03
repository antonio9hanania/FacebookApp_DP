using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class PageAdapter : IPictureAndNameOwner
    {
        private Page m_Page;

        public PageAdapter(Page i_Page)
        {
            m_Page = i_Page;
        }

        public System.Drawing.Image ImageNormal
        {
            get
            {
                return m_Page.ImageNormal;
            }
        }

        public string Name
        {
            get
            {
                return m_Page.Name;
            }
        }
    }
}
