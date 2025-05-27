using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionofstamp.Models
{
    public static class DataManager
    {
        private const string StampsFile = "stamps.json";
        private const string CollectorsFile = "collectors.json";
        private const string MyCollectionFile = "mycollection.json";

        public static void CheckAndCreateFiles()
        {
            string[] files = { StampsFile, CollectorsFile, MyCollectionFile };
            foreach (var file in files)
            {
                if (!File.Exists(file))
                {
                    File.WriteAllText(file, "[]");
                }
            }
        }

        public static (List<Stamp>, List<Collector>, List<Stamp>) LoadData()
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                string stampsJson = File.ReadAllText(StampsFile, Encoding.UTF8);
                var stamps = JsonSerializer.Deserialize<List<Stamp>>(stampsJson) ?? new List<Stamp>();

                string collectorsJson = File.ReadAllText(CollectorsFile, Encoding.UTF8);
                var collectors = JsonSerializer.Deserialize<List<Collector>>(collectorsJson) ?? new List<Collector>();

                string myCollectionJson = File.ReadAllText(MyCollectionFile, Encoding.UTF8);
                var myCollection = JsonSerializer.Deserialize<List<Stamp>>(myCollectionJson) ?? new List<Stamp>();

                return (stamps, collectors, myCollection);
            }
            catch (Exception)
            {
                return (new List<Stamp>(), new List<Collector>(), new List<Stamp>());
            }
        }

        public static void SaveData(List<Stamp> stamps, List<Collector> collectors, List<Stamp> myCollection)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(StampsFile, JsonSerializer.Serialize(stamps, options));
                File.WriteAllText(CollectorsFile, JsonSerializer.Serialize(collectors, options));
                File.WriteAllText(MyCollectionFile, JsonSerializer.Serialize(myCollection, options));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
