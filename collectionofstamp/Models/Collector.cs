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
        public string Name { get; set; }
        public string ContactData { get; set; }
        public string RareStamps { get; set; }
    }
}
