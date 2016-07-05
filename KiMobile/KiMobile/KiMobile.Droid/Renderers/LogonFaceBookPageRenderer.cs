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

[assembly: ExportRenderer(typeof(KiMobile.Pages.Logon.Facebook), typeof(LogonFaceBookPageRenderer))]

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
                clientId: "1397851943872695", // your OAuth2 client id
                scope: "", // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"), // the auth URL for the service
                redirectUrl: new Uri("https://www.konsumentinfo.se/connect/login_success.html")); // the redirect URL for the service

            auth.Completed += (sender, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    // App.SuccessfulLoginAction.Invoke();
                    // Use eventArgs.Account to do wonderful things
                    // App.SaveToken(eventArgs.Account.Properties["access_token"]);
                    KiMobile.Pages.Logon.MainLogon.FaceBookToken = eventArgs.Account.Properties["access_token"];
                    Pages.Logon.Facebook.LoginSuccess();
                    

                }
                else
                {
                    // The user cancelled
                    Pages.Logon.Facebook.LoginCancel();
                }
            };

            activity.StartActivity(auth.GetUI(activity));
        }


    }
}