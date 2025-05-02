using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace collectionofstamp.Models
{
    public class Stamp
    {
        public string Country { get; set; }
        [JsonPropertyName("nominal_value")]
        public string Price { get; set; }
        public int Year { get; set; }
        public int Circulation { get; set; }
        public string Features { get; set; }
    }
}
