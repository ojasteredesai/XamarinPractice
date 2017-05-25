using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearingApp
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginWebServicePage : ContentPage
    {
        public LoginWebServicePage()
        {
            InitializeComponent();
           
            var json = CallLoginService();
        }

        private async Task CallLoginService()
        {
            try
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri("http://10.37.21.93/ZeroChaos.Service.Host/json/reply/loginrequest");// ("http://devservices.zcdev.net/US-21.0/json/reply/loginrequest");
                request.Method = HttpMethod.Post;
                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("x-api-key", "D18F5B97-9FC2-4355-B293-0000044B8088");

                var values = new List<KeyValuePair<string, string>>();
                values.Add(new KeyValuePair<string, string>("emailAddress", "test1@test1.com12"));
                values.Add(new KeyValuePair<string, string>("password", "rspl123#"));

                request.Content = new FormUrlEncodedContent(values);
                
                var client = new HttpClient();
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var returnedToken = response.Content.ReadAsStringAsync();
                    var jsonResponse = JsonConvert.DeserializeObject<LoginResponse>(returnedToken.Result);
                    this.Content = new Label
                    {
                        Text = returnedToken.Result
                    };
                }
            }
            catch (Exception ex)
            {
                this.Content = new Label
                {
                    Text = ex.Message
                };
            }
        }

        private bool CallLoginService1()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://localhost/ZeroChaos.Service.Host/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("x-api-key", "D18F5B97-9FC2-4355-B293-0000044B8088");

                    var loginRequest = new LoginRequest
                    {
                        EmailAddress = "ira.friedman@pharma.com",
                        Password = "rspl123#"
                    };

                    var response = client.PostAsJsonAsync("http://localhost/ZeroChaos.Service.Host/json/reply/loginrequest", loginRequest).Result;

                    if (response != null && response.IsSuccessStatusCode)
                    {
                        var response1 = response.Content.ReadAsAsync<LoginResponse>().Result;
                    }
                }
                catch (Exception ex)
                {
                }

            }
            return true;
        }
    }


    public class LoginRequest
    {
        /// <summary>
        /// Server TimeZone
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Server Time
        /// </summary>
        public string Password { get; set; }

    }

    public class LoginResponse
    {
        public string EmailAddress { get; set; }
        public string FullName { get; set; }
        public string AuthToken { get; set; }
        public string UserType { get; set; }
        public int UserTypeID { get; set; }
        public int ClientID { get; set; }
        public int ResourceID { get; set; }
        public int PreferredLanguageID { get; set; }
        public int ContactID { get; set; }
        public Guid UserID { get; set; }
        public int UserPreferredCNLanguageID { get; set; }
        public int VendorID { get; set; }
        public string EmpClassID { get; set; }
        public UserPermissions UserPermissions { get; set; }
        public bool IsEnabledLivePerson { get; set; }
        public int EnrollStatusID { get; set; }
        public string LoggedInUserProfileImageName { get; set; }
        public bool? IsSubscribed { get; set; }
        public bool IsAnEnrollmentActive { get; set; }
        public bool IsAnEnrollmentPending { get; set; }
        public string UserPreferredTimeZoneName { get; set; }
        public string UserPreferredLanguageName { get; set; }
        public string ZCWUserID { get; set; }
        public string UserPreferredTimeZone { get; set; }
        public string UserCulture { get; set; }
        private List<EnrollmentDetails> pendingEnrollments;
        //Property added for ZMOB-2885
        public int GlobalSupplierID { get; set; }
        public LoginResponse()
        {
            pendingEnrollments = new List<EnrollmentDetails>();

        }
        public List<EnrollmentDetails> PendingEnrollments
        {
            get { return pendingEnrollments; }
            set { pendingEnrollments = value; }
        }
    }

    public class EnrollmentDetails
    {
        public string ProjectNameAndStatus { get; set; }
        public string DivisionName { get; set; }
    }

    public class UserPermissions
    {
        public bool? AllowSOWInvoicing;
        public bool? AllowRequisitions { get; set; }
        public bool? AllowToSearchCandidates { get; set; }
        public bool? AllowToAddTimesheet { get; set; }
        public bool? AllowToAddExpense { get; set; }
        public bool? AllowToSubmitExpense { get; set; }
        public bool? AllowToSubmitTimesheet { get; set; }
        public bool? AllowToHaveCheckList { get; set; }
        public bool? IsRegistered { get; set; }
        public bool? CanClientContactCandidate { get; set; }
        public bool? IsSourcingVendor { get; set; }
        public bool? AllowInsurancePenalty { get; set; }
        public bool? IsPayrollingVendor { get; set; }
        public bool? AllowToEditEnrollment { get; set; }
        public bool? AllowToVendorBIEdit { get; set; }
        public bool? IsServiceProvider { get; set; }
        public bool? IsEnableEvaluationExpiration { get; set; }
        public bool? AllowSOWRequisition { get; set; }
        public bool? AllowEngagement { get; set; }
        public bool? AllowToManageProjects { get; set; }
        public bool? AllowToManageTimesheets { get; set; }
        public bool? AllowToManageMemberPayHistory { get; set; }
        public bool? AllowEnrollMent { get; set; }
        public bool? AllowToManageDocuments { get; set; }
        public bool? IsBackGroundCheckRequiredForMember { get; set; }
        public bool? IsDrugScreenRequiredForMember { get; set; }
        public bool? EnableSSOForMember { get; set; }
        public bool? AllowH1BIPlacement { get; set; }
        public bool? HasW2eVerifyCheck { get; set; }
        public bool? IsRehire { get; set; }
        public bool? IsPayRateAccepted { get; set; }
        public bool? IsMailMeCheck { get; set; }
        public bool? AllowSSOEmailVerification { get; set; }
        public bool? AllowThroughVMS { get; set; }
        public bool? AllowComplianceClientDecision { get; set; }
        public bool? HasEnterpriseWideAccess { get; set; }
        public bool? OutOfOfficeActive { get; set; }
        public bool? AllowToReceiveEmailDuringOutOfOffice { get; set; }
        public bool? IsSentPDF { get; set; }
        public bool? AllowToViewReport { get; set; }
        public bool? AllowManagerToAddNewEngagement { get; set; }
        public bool? AllowManagerToAddNewServiceProvider { get; set; }
        public bool? AllowRFPCreation { get; set; }
        //  public bool? AllowToEditReqAfterDraft { get; set; } //ZCW-71768
        public bool? AllowAutoDistReqsByTier { get; set; }
        public bool? AllowToExceedMaxBillRate { get; set; }
        public bool? AllowToEditResumeByMSP { get; set; }
        public bool? IsClassicDashBoard { get; set; }
        public bool? CanVendorContactClient { get; set; }
        public bool? AllowAutoTerminateProjects { get; set; }
        public bool IsClientExpenseModuleEnabled { get; set; }
        public bool IsClientExpenseModuleEnabledOnDashLet { get; set; }
        public string ResourceCode { get; set; }
        public bool? ShowTimesheetSectionForSP { get; set; }
        /// <summary>
        /// ZCW-61333 used for menu permission               
        /// </summary>
        public bool AllowToSearchServiceProviderProfile { get; set; }
    }
}
