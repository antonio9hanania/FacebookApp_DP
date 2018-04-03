using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class BestFriendItemsFinderFactory
    {
        public static BestFriendItemsFinder Create(Type i_Type)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            BestFriendItemsFinder bestFriendItemsFinder = assembly.CreateInstance(i_Type.FullName) as BestFriendItemsFinder;
            return bestFriendItemsFinder;
        }
    }
}
