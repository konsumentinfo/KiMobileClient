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
using Xamarin.Forms.Platform.Android;
using KiMobile.Droid.Renderers;
using Xamarin.Auth;
using System.Json;

[assembly: ExportRenderer(typeof(KiMobile.Main.Pages.Logon.Facebook), typeof(LogonFaceBookPageRenderer))]

namespace KiMobile.Droid.Renderers
{
    public class LogonFaceBookPageRenderer : PageRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            // base.ElementChanged(oldModel, newModel);
            base.OnElementChanged(e);

            // this is a ViewGroup - so should be able to load an AXML file and FindView<>
            var activity = this.Context as Activity;
            
            var auth = new OAuth2Authenticator(
                clientId: KiMobile.Settings.Settings.FaceBookAppId, 
                scope: "", // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: new Uri(KiMobile.Settings.Settings.FaceBookAuthorizeUrl), // the auth URL for the service
                redirectUrl: new Uri(KiMobile.Settings.Settings.FaceBookRedirectUrl)); // the redirect URL for the service

            var dsfdsf = "sdfdsfd";

            auth.Completed += (sender, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    // App.SuccessfulLoginAction.Invoke();
                    // Use eventArgs.Account to do wonderful things
                    // App.SaveToken(eventArgs.Account.Properties["access_token"]);

                    

                    KiMobile.Settings.Settings.LogonData.LogonType = Settings.Enum.LogonType.Facebook;
                    KiMobile.Settings.Settings.LogonData.FaceBook = new Settings.LogonDataFaceBook
                    {
                        Account = eventArgs.Account,
                        Token = eventArgs.Account.Properties["access_token"],
                        TokenExpiresIn = Convert.ToUInt64(eventArgs.Account.Properties["expires_in"])
                    };


                    // KiMobile.Main.Pages.Logon.MainLogon.FaceBookToken = eventArgs.Account.Properties["access_token"];

                    //  Save account data to accountStorage
                    // Helpers.AccountData.Facebook = eventArgs.Account;


                    Main.Pages.Logon.Facebook.LoginSuccess(sender, eventArgs);


                    // AccountStore.Create (this).Save(eventArgs.Account, "Facebook");
                    
                }
                else
                {
                    // The user cancelled
                    Main.Pages.Logon.Facebook.LoginCancel();
                }
            };

            activity.StartActivity(auth.GetUI(activity));
        }


    }
}