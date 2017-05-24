using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMasterDetail
{
    class Admusers
    {

        public class Resource
        {

            public int id { get; set; }
            public string user { get; set; }
            public string pass { get; set; }
            public bool adm { get; set; }
            public bool baixa { get; set; }

        }

        public class RootObject
        {
            public List<Resource> resource { get; set; }
        }


    }
}
