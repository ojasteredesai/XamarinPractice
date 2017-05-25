using MasterDetailDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailDemo.Services
{
    public interface IServiceCaller
    {
        ZCNavigationMenuResponse CallHostService(ZCNavigationMenuRequest request);
    }
}
