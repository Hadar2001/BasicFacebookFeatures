using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public string LastAccessToken { get; set; }

        public List<string> FacebookPermissions { get; set; }

        public AppSettings()
        {
            LastAccessToken = null;
            FacebookPermissions = new List<string>
            {
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos"
            };
        }

        public static AppSettings LoadAppSettings()
        {
            AppSettings appSettings;
            XmlSerializer serializer;

            try
            {
                using (Stream stream = new FileStream("./appSettings.xml", FileMode.Open))
                {
                    serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            catch (Exception ex)
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        internal void SaveToFile()
        {
            FileMode fileMode = File.Exists("appSettings.xml") ? FileMode.Truncate : FileMode.Create;
            XmlSerializer serializer;

            using (Stream stream = new FileStream("appSettings.xml", fileMode, FileAccess.ReadWrite))
            {
                serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}