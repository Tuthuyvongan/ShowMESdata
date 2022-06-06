using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMESData
{
    class ListPQC
    {
        public string Model { get; set; }
        public string Date { get; set; }
        public string Line { get; set; }
        public double OUTPUT { get; set; }
        public double REWORK { get; set; }
        public double NOGOOD { get; set; }
        public double Total { get; set; }
        public double NG_rate_realtime { get; set; }
        public double NG_rate_allow { get; set; }
    }
}
