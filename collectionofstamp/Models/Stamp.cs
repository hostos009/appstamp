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
        public string Naming { get; set; }
        public string Country { get; set; }
        public string Price { get; set; }
        public int Year { get; set; }
        public int Circulation { get; set; }
        public string Features { get; set; }
    }
}
