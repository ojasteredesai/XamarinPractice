using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetailDemo.Model;

namespace MasterDetailDemo.Services
{
    public class ServiceCaller : IServiceCaller
    {
        #region Interface Implementation
        //In memory data is used for POC purpose only, Here Service call will be made to get the data as per usertype.
        public ZCNavigationMenuResponse CallHostService(ZCNavigationMenuRequest request)
        {
            var response = new ZCNavigationMenuResponse();
            switch (request.UserType)
            {
                case 1: //Member
                    response.ZCNavigationObjects = this.ZCNavigationMenuResponseForMember();
                    break;
                case 2: // Manager
                    response.ZCNavigationObjects = this.ZCNavigationMenuResponseForManager();
                    break;
                case 10: // Vendor
                    response.ZCNavigationObjects = this.ZCNavigationMenuResponseForVendor();
                    break;
                default:                     
                    break;
            }

            return response;    
        }
        #endregion

        #region Private Methods
        private List<ZCNavigationObject> ZCNavigationMenuResponseForMember()
        {
            return new List<ZCNavigationObject>
            {
               
                 new ZCNavigationObject
                 {
                     ObjectID = 2,
                     ObjectName = "Timesheets",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "3",
                                            TextValue="View Timesheet"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "4",
                                            TextValue="Create Timesheet"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 3,
                     ObjectName = "Expenses",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "6",
                                            TextValue="View Expense"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "7",
                                            TextValue="Create Expense"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 6,
                     ObjectName = "Payments",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "13",
                                            TextValue="View Payment History"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 7,
                     ObjectName = "Dossier",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "14",
                                            TextValue="Information"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 8,
                     ObjectName = "LogOut",
                     ZCObjectItems = new List<ZCNavigationObjectItem>()
                 }
            };
        }
        private List<ZCNavigationObject> ZCNavigationMenuResponseForVendor()
        {
            return new List<ZCNavigationObject>
            {
                new ZCNavigationObject
                {
                    ObjectID = 1,
                    ObjectName = "Requisition",
                    ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "1",
                                            TextValue="View Open Requisitions"
                                        }
                                    }
                },
                 new ZCNavigationObject
                 {
                     ObjectID = 2,
                     ObjectName = "Timesheets",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "3",
                                            TextValue="View Timesheet"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "4",
                                            TextValue="Create Timesheet"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 3,
                     ObjectName = "Expenses",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "6",
                                            TextValue="View Expense"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "7",
                                            TextValue="Create Expense"
                                        },
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 5,
                     ObjectName = "Projects",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "11",
                                            TextValue="View Projects"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 6,
                     ObjectName = "Payments",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "13",
                                            TextValue="View Payment History"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 7,
                     ObjectName = "Dossier",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "14",
                                            TextValue="Information"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 8,
                     ObjectName = "LogOut",
                     ZCObjectItems = new List<ZCNavigationObjectItem>()
                 }
            };
        }
        private List<ZCNavigationObject> ZCNavigationMenuResponseForManager()
        {
            return new List<ZCNavigationObject>
            {
                new ZCNavigationObject
                {
                    ObjectID = 1,
                    ObjectName = "Requisition",
                    ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "1",
                                            TextValue="Manage Requisitions"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "2",
                                            TextValue="Approve Requisitions"
                                        }
                                    }
                },
                 new ZCNavigationObject
                 {
                     ObjectID = 2,
                     ObjectName = "Timesheets",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "3",
                                            TextValue="View Timesheet"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "4",
                                            TextValue="Create Timesheet"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "5",
                                            TextValue="Approve Timesheet"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 3,
                     ObjectName = "Expenses",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "6",
                                            TextValue="View Expense"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "7",
                                            TextValue="Create Expense"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "8",
                                            TextValue="Approve Expense"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 4,
                     ObjectName = "Engagement",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "9",
                                            TextValue="View Engagements"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "10",
                                            TextValue="Approve Engagements"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 5,
                     ObjectName = "Projects",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "11",
                                            TextValue="View Projects"
                                        },
                                          new ZCNavigationObjectItem
                                        {
                                            DataValue = "12",
                                            TextValue="Approve Projects"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 7,
                     ObjectName = "Dossier",
                     ZCObjectItems = new List<ZCNavigationObjectItem>
                                    {
                                        new ZCNavigationObjectItem
                                        {
                                            DataValue = "14",
                                            TextValue="Information"
                                        }
                                    }
                 },
                 new ZCNavigationObject
                 {
                     ObjectID = 8,
                     ObjectName = "LogOut",
                     ZCObjectItems = new List<ZCNavigationObjectItem>()
                 }
            };
        }
        #endregion
    }
}

