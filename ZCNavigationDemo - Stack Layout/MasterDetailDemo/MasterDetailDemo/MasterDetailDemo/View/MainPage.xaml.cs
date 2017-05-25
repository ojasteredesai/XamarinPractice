using MasterDetailDemo.Model;
using MasterDetailDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailDemo
{
    public partial class MainPage : MasterDetailPage
    {
        #region Constructors
        public MainPage()
        {
            InitializeComponent();
            MainOne.DataSource = GetZCNavigationData();
            MainOne.DataBind();
            Detail = new NavigationPage(new DossierPage());
            IsPresented = false;
        }
        #endregion

        #region Public Methods
        public List<ZCNavigationSource> GetZCNavigationData()
        {
            var result = new List<ZCNavigationSource>();
            try
            {
                var zcnavigationData = GetZCNavigationObjectData();
                StackLayout zcnavigatioItemStackLayout;
                ZCNavigationSource zcnavigationHeader;
                foreach (var data in zcnavigationData.ZCNavigationObjects)
                {
                    // zcnavigatioItemStackLayout = new StackLayout{ Padding= new Thickness(5,3,0,0)};
                    zcnavigatioItemStackLayout = new StackLayout { Padding = Device.OnPlatform<Thickness>(new Thickness(5, 1, 0, 0), new Thickness(5, 1, 0, 0), new Thickness(0)) };

                    foreach (var item in data.ZCObjectItems)
                    {
                        Label itemLabel = new Label
                        {
                            Text = item.TextValue,
                            StyleId = item.DataValue,
                            TextColor = Color.White,
                            HeightRequest = 30,
                            TranslationX = 5
                        };

                        var tapGestureRecognizer = new TapGestureRecognizer();
                        tapGestureRecognizer.Tapped += (s, e) =>
                        {
                            var selectedLabel = s as Label;
                            OnListItemClicked(selectedLabel.StyleId);
                            IsPresented = false;
                        };
                        itemLabel.GestureRecognizers.Add(tapGestureRecognizer);
                        zcnavigatioItemStackLayout.Children.Add(itemLabel);
                    }

                    zcnavigationHeader = new ZCNavigationSource()
                    {
                        ObjectID = data.ObjectID,
                        HeaderText = data.ObjectName,
                        HeaderTextColor = Color.White,
                        HeaderBackGroundColor = Color.FromHex("#3c9ece"),
                        ContentItems = zcnavigatioItemStackLayout
                    };
                    result.Add(zcnavigationHeader);
                }
            }
            catch (Exception ex)
            {
                //Exception to be logged here.                
            }
            return result;
        }
        #endregion

        #region Private Methods
        private void OnListItemClicked(string itemID)
        {
            //For POC switch case is used. Better approach like Dependency Injection or similar approach can be used.
            #region Selection 
            switch (itemID)
            {
                case "1":
                    Detail = new NavigationPage(new ManageRequisitionPage());
                    break;
                case "2":
                    Detail = new NavigationPage(new ApproveRequisitionPage());
                    break;
                case "3":
                    Detail = new NavigationPage(new ViewTimesheetPage());
                    break;
                case "4":
                    Detail = new NavigationPage(new CreateTimeSheetPage());
                    break;
                case "5":
                    Detail = new NavigationPage(new ApproveTimeSheetPage());
                    break;
                case "6":
                    Detail = new NavigationPage(new ViewExpensePage());
                    break;
                case "7":
                    Detail = new NavigationPage(new CreateExpensePage());
                    break;
                case "8":
                    Detail = new NavigationPage(new ApproveExpensePage());
                    break;
                case "9":
                    Detail = new NavigationPage(new ViewEngagementPage());
                    break;
                case "10":
                    Detail = new NavigationPage(new ApproveEngagementPage());
                    break;
                case "11":
                    Detail = new NavigationPage(new ViewProjectPage());
                    break;
                case "12":
                    Detail = new NavigationPage(new ApproveProjectPage());
                    break;
                case "13":
                    Detail = new NavigationPage(new ViewPayHistoryPage());
                    break;
                case "14":
                    Detail = new NavigationPage(new DossierPage());
                    break;
                default:
                    Detail = new NavigationPage(new DossierPage());
                    break;
            }
            #endregion
        }

        private ZCNavigationMenuResponse GetZCNavigationObjectData()
        {
            ZCNavigationMenuRequest request = new ZCNavigationMenuRequest { UserType = 2 };
            //This object creation is for POC purpose only. Dependency injection can be used for actual implementation.
            IServiceCaller caller = new ServiceCaller();
            return caller.CallHostService(request);
        }
        #endregion
    }
}
