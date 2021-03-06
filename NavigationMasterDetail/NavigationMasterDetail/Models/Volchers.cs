﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMasterDetail.Models
{
    class Volchers
    {
        public class Resource
        {
            public int id { get; set; }
            public string login { get; set; }
            public string pass { get; set; }
            public object criado { get; set; }
            public string owner { get; set; }
            public string expira { get; set; }
            public bool pago { get; set; }
            public string dias { get; set; }
        }

        public class RootObject
        {
            public List<Resource> resource { get; set; }
        }
    }
}
