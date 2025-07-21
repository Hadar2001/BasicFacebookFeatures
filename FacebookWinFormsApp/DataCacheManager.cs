using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public sealed class DataCacheManager
    {
        private static readonly DataCacheManager sr_Instance = new DataCacheManager();
        private readonly Dictionary<string, object> r_DataCache = new Dictionary<string, object>();
        private readonly object r_FileLockObject = new object();
		private readonly object r_DataCacheLockObject = new object();
		private readonly string r_EventsFilePath = Path.Combine(Properties.Resources.DocumentsFolderPath, Properties.Resources.events);
		
		private DataCacheManager(){}

        public static DataCacheManager SingletonInstance
        {
            get { return sr_Instance; }
        }

        public FacebookObjectCollection<T> GetCollectionFromServiceOrCache<T>(string i_Collection)
            where T : FacebookObject, new()
        {            
            FacebookObjectCollection<T> collectionToReturn = null;

			lock (r_DataCacheLockObject)
			{
				if (r_DataCache.ContainsKey(i_Collection))
				{
					collectionToReturn = (FacebookObjectCollection<T>)r_DataCache[i_Collection];
				}
				else
				{
					collectionToReturn = FacebookService.GetCollection<T>(i_Collection);
					r_DataCache[i_Collection] = collectionToReturn;
				}
			}			

			return collectionToReturn;
		}

        internal IEnumerable<MockEvent> GetMockEvents()
        {
            IEnumerable<MockEvent> eventsList;
			
			lock (r_FileLockObject)
            {
				try
				{					
					if (File.Exists(r_EventsFilePath) && new FileInfo(r_EventsFilePath).Length > 0)
					{
						eventsList = loadEventsFromXml();
					}
					else
					{
						eventsList = new List<MockEvent>(); // Return an empty list if no data exists.
					}
				}
				catch (Exception ex)
				{
					throw new Exception("Failed to load mock events", ex);
				}			
			}

			return eventsList;
		}

		private IEnumerable<MockEvent> loadEventsFromXml()
		{
			lock (r_FileLockObject)
			{			
				try
				{
					using (Stream stream = new FileStream(r_EventsFilePath, FileMode.Open, FileAccess.Read))
					{
						var serializer = new XmlSerializer(typeof(List<MockEvent>));

						return serializer.Deserialize(stream) as IEnumerable<MockEvent>;
					}
				}
				catch (InvalidOperationException ex)
				{
					throw new Exception("Failed to deserialize the XML data. The format may be incorrect.", ex);
				}
			}
		}

		internal void SaveEventsToXmlFile<T>(string i_FilePath, List<T> i_ListOfElementsToSave)
        {
            XmlSerializer serializer;

			lock (r_FileLockObject)
			{
				try
				{
					using (Stream stream = new FileStream(i_FilePath, FileMode.Create))
					{
						serializer = new XmlSerializer(typeof(List<T>));
						serializer.Serialize(stream, i_ListOfElementsToSave);
					}
				}
				catch (Exception ex)
				{
					throw new Exception("Failed to Save Elements", ex);
				}
			}
        }
    }
}