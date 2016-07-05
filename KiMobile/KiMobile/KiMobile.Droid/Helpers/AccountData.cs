using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using KiMobile.Droid.Helpers;
using Xamarin.Auth;

//  https://developer.xamarin.com/recipes/cross-platform/xamarin-forms/general/store-credentials/

[assembly: Dependency(typeof(AccountData))]
namespace KiMobile.Droid.Helpers
{
    public class AccountData
    {
        public static Account Facebook
        {
            get
            {
                
                var accounts = AccountStore.Create(Forms.Context).FindAccountsForService("Facebook").FirstOrDefault();
                return (accounts != null) ? accounts : null;
                
            }
            set
            {
                AccountStore.Create(Forms.Context).Save(value, "Facebook");
                var dsfdsf = "sdfsdf";
                
            }
        }
        public static void FacebookDeleteCredentials()
        {
            var account = Facebook;
            if (account != null)
            {
                AccountStore.Create(Forms.Context).Delete(account, "Facebook");
            }
        }
        



    }
}