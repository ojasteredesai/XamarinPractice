using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailDemo
{
    public class ZCNavigationSource
    {
        public int ObjectID { get; set; }
        public string HeaderText { get; set; }
        public Color HeaderTextColor { get; set; }
        public Color HeaderBackGroundColor { get; set; }
        public View ContentItems { get; set; }
    }
}
