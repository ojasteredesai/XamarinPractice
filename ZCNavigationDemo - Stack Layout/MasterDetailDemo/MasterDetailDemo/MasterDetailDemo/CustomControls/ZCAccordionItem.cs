using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailDemo
{
    public class ZCAccordionItem : Label
    {
        #region Private Variables
        bool expand = false;
        #endregion

        #region Constructors
        public ZCAccordionItem()
        {
            HorizontalOptions = LayoutOptions.FillAndExpand;
            //BorderColor = Color.Black;            
            HeightRequest = 40;
        }
        #endregion
        #region Properties
        public bool Expand
        {
            get
            {
                return expand;
            }
            set
            {
                expand = value;
            }
        }
        public ContentView AssosiatedContent
        {
            get; set;
        }
        #endregion
    }
}
