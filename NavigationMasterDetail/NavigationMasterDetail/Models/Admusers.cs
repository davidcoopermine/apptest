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
            public string name { get; set; }
            public string user { get; set; }
            public string pass { get; set; }
            public string email { get; set; }
            public int accesslevel { get; set; }
            public string description { get; set; }
            public int enable { get; set; }
            public int log { get; set; }
            public int showpass { get; set; }
            public int onlylocal { get; set; }
            public string deny { get; set; }
            public int cron_week_status { get; set; }
            public int cron_week_police { get; set; }
            public string cron_week_sunday { get; set; }
            public string cron_week_monday { get; set; }
            public string cron_week_tuesday { get; set; }
            public string cron_week_wednesday { get; set; }
            public string cron_week_thursday { get; set; }
            public string cron_week_friday { get; set; }
            public string cron_week_saturday { get; set; }
            public string cron_week_holiday { get; set; }
            public int radius_enable { get; set; }
            public string radius_pass { get; set; }
            public int mail_alert { get; set; }
            public string profile { get; set; }
            public int credenciado { get; set; }
        }

        public class RootObject
        {
            public List<Resource> resource { get; set; }
        }


    }
}
