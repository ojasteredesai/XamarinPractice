using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailDemo
{
    public class ZCNavigationObject
    {
        public int ObjectID { get; set; }
        public string ObjectName { get; set; }
        public List<ZCNavigationObjectItem> ZCObjectItems { get; set; }
    }
}
