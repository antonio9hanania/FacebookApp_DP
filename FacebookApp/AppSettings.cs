using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace C17_Ex02_Antonio_205707284_Yarden_204718738
{
    public class AppSettings
    {
        public static AppSettings LoadFromFile()
        {
            AppSettings toLoad = null;
            try
            {
                using (Stream stream = new FileStream("appsettings.xml", FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(AppSettings));
                    toLoad = deserializer.Deserialize(stream) as AppSettings;
                }
            }
            catch
            {
                toLoad = new AppSettings();
            }

            return toLoad;
        }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            using(Stream stream = new FileStream("appsettings.xml", FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
