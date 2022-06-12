using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertTracking1
{
    public class Asset
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public  string Brand { get; set; } 
        public string Model { get; set; }
        public string Office { get; set; }

        public int DateofPurchase { get; set; }

        public int Currency { get; set; }



    }
}
