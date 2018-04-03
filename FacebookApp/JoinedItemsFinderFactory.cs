using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class JoinedItemsFinderFactory
    {
        public static IJoinedItemsFinder Create(Type i_ItemsFinderType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            IJoinedItemsFinder joinedItemsFinder = assembly.CreateInstance(i_ItemsFinderType.FullName) as IJoinedItemsFinder;
            return joinedItemsFinder;
        }
    }
}
