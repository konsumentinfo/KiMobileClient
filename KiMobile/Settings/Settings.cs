using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KiMobile.Settings
{
    public static class Settings // : ContentPage
    {
        public static string Build => "2016" + "07" + "05" + "1013";

        public static string Version => "0" + "." + "0" + "."+ "1";

        public static string FaceBookAppId => "1397851943872695";
        public static string FaceBookAuthorizeUrl => "https://m.facebook.com/dialog/oauth/";
        public static string FaceBookRedirectUrl => "https://www.konsumentinfo.se/connect/login_success.html";

        public static bool UserIsLoggedIn { get; set; }
        public static Enum.Pages NavPage { get; set; }
        
        public static LogonData LogonData = new LogonData();
        public static FacebookProfileData UserProfileFaceBook { get; set; }
        
    }
    public class LogonData
    {
        public Enum.LogonType LogonType { get; set; }

        public LogonDataFaceBook FaceBook { get; set; }

        public LogonData()
        {
            LogonType = Enum.LogonType.Null;
        }
    }
    public class LogonDataFaceBook
    {
        public Xamarin.Auth.Account Account { get; set; }
        public bool CommunicationIsWorking { get; set; }
        public string CommunicationResponse { get; set; }
        public string Token { get; set; }
        public ulong TokenExpiresIn { get; set; }
        //public string UserId { get; set; }
        //public string UserName { get; set; }

 
    }
    public class FacebookProfileData
    {
        public DateTime Birtday { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string TimeZone { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool Verified { get; set; }


    }
}
