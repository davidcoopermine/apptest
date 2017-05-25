using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMasterDetail.Models
{
    class OwnerAdmin
    {
        public class Resource
        {
            public int id { get; set; }
            public string owner { get; set; }
            public bool adm { get; set; }
            public string total { get; set; }
            public string pagos { get; set; }
            public string abertos { get; set; }
        }

        public class RootObject
        {
            public List<Resource> resource { get; set; }
        }
    }
}
