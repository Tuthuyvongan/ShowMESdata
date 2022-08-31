using System.Data;

namespace WindowsFormsApplication1
{
    public class SaveData
    {       
        public static double total { get; set; }
        public static double target { get; set; }
        public static double op { get; set; }
        public static double rw { get; set; }       
        public static double ng { get; set; }     
        public static string line { get; set; }
        public static double NGrealtime { get; set; }
        public static string NGallow { get; set; }
        public static double RWrealtime { get; set; }
        public static string RWallow { get; set; }
        public static string Model { get; set; }
        public static bool MQCClick { get; set; }
        public static bool PQCClick { get; set; }
        public static bool MQC { get; set; }
        public static bool PQC { get; set; }
        public static string Date { get; set; }
        //List MQC Date
        public static string Date1 { get; set; }
        public static string Date2 { get; set; }
        //List PQC Date
        public static string Date3 { get; set; }
        public static string Date4 { get; set; }
        //public static DataTable dtTemp1 { get; set; }
        public static DataTable dtTemp2 { get; set; }
        //DataTable of MQC
        public static DataTable dtTemp3 { get; set; }
        public static DataTable dtTemp4 { get; set; }
        public static DataTable dtTemp5 { get; set; }
        public static DataTable dtTemp6 { get; set; }
        //DataTable of PQC
        public static DataTable dtTemp7 { get; set; }
        public static DataTable dtTemp8 { get; set; }
        public static DataTable dtTemp9 { get; set; }
        public static DataTable dtTemp10 { get; set; }
        public static int uc_mqc { get; set; }
        public static int uc_pqc { get; set; }
        public static int uc_pi { get; set; }
        public static bool check { get; set; }
        public static string pass { get; set; }
        public static bool checkpass { get; set; }
        public static bool checknull { get; set; }
        public static bool checknullPQC { get; set; }
    }
}
