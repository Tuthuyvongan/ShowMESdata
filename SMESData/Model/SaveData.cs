using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMESData
{
    public class SaveData
    {       
        public static double total { get; set; }
        public static double op { get; set; }
        public static double rw { get; set; }       
        public static double ng { get; set; }     
        public static string line { get; set; }
        public static double NGrealtime { get; set; }
        public static double NGallow { get; set; }
        public static string Model { get; set; }
        public static bool MQCClick { get; set; }
        public static bool PQCClick { get; set; }
        public static bool MQC { get; set; }
        public static bool PQC { get; set; }
    }
}
