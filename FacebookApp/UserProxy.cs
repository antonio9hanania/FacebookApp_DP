using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class UserProxy : IPictureAndNameOwner
    {
        public User User { get; set; }

        public int Rate { get; set; }

        public System.Drawing.Image ImageNormal
        {
            get
            {
                return User.ImageNormal;
            }
        }

        public string Name
        {
            get
            {
                return User.Name;
            }
        }

        public string NameAndRate
        {
            get
            {
                return ToString();
            }
        }

        public override string ToString()
        {
            return string.Format("{0}) {1}", Rate, User.Name);
        }
    }
}
