using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace collectionofstamp.Models
{
    public class Collector
    {
        public string Country { get; set; }
        [JsonPropertyName("collector_name")]
        public string Name { get; set; }
        [JsonPropertyName("contact_info")]
        public string ContactData { get; set; }
        [JsonPropertyName("rare_stamps")]
        public string RareStamps { get; set; }
    }
}
