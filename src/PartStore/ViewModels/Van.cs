using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartStore
{
    public class Van
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Registration { get; set; }

        public int Mileage { get; set; }

        public DateTime LastServiced { get; set; }

        public DateTime LastWashed { get; set; }
    }
}
