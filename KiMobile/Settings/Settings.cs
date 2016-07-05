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
        public static string NavPage { get; set; }
        
    }
}
