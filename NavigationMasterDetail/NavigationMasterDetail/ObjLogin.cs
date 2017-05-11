using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMasterDetail
{
    class ObjLogin
    {
        public static string login { get; set; }
        public static bool logado { get; set; }
        public static int login_id { get; set; }
    }
    class ObjVolchers
    {
        public static int Quantidade { get; set; }
    }

    class ObjRamdomPass
    {
        public static string UserRandom { get; set; }
        public static string PassRandom { get; set; }
        public static string DataExpira { get; set; }
    }
}

