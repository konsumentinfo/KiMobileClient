using KiMobile.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Json;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Auth;
using Xamarin.Forms;

namespace KiMobile.Main.Pages.Logon
{

    public class MainLogon : ContentPage
    {
        protected IAccountData AccountData { get; set; } = DependencyService.Get<IAccountData>();
        protected ICommunicationFacebook AccountCommunicationFaceBook { get; set; } = DependencyService.Get<ICommunicationFacebook>();


        public MainLogon()
        {

            //Event handling facebook logon
            Facebook.LoginFaceBookSucceeded += HandleLoginFaceBookSucceeded;
            Facebook.LoginFaceBookCancelled += CancelLoginAction;


            
            #region Build page design

            
            this.Padding = new Thickness(20, Device.OnPlatform(40, 20, 20), 20, 20);

            #region Top loggo and Text


            StackLayout pnTop = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Spacing = 15,
            };

            // Label lbLogonMainLoggoText = new Label { Text = "Konsumentinfo.se", FontSize = 24 };

            pnTop.Children.Add(new Label { Text = "Konsumentinfo.se", FontSize = 24 });
            // pnTop.Children.Add(lbLogonMainLoggoText);

            #endregion

            #region Logon Using external service

            StackLayout dd2 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Spacing = 2,
            };



            Button btnFaceBookLoggo = new Button
            {
                Image = "fblogon.png",
                WidthRequest = 100,
                HeightRequest = 100,

            };
            btnFaceBookLoggo.Clicked += DoFaceBookLogon;

            #endregion


            //  Test


            dd2.Children.Add(new Label { Text = "Du kan välja att logga in med:", FontSize = 14 });

            Label lbLogonAltText = new Label { Text = "Någon utav följande tjänst." };
            dd2.Children.Add(lbLogonAltText);
            dd2.Children.Add(btnFaceBookLoggo);
            var dd = new Frame
            {
                OutlineColor = Color.Silver,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Content = dd2

            };
            // dd.Content = dd2;



            // ---
            StackLayout panelPut = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Spacing = 15
            };
            panelPut.Children.Add(pnTop);
            panelPut.Children.Add(dd);



            //  Output page design
            this.Content = panelPut;

            #endregion

        }

        void DoFaceBookLogon(object sender, EventArgs e)
        {

            //  Check if facebook account exist on phone.
            var dd = AccountData.Facebook;

            var dfsdf = "sdfsdfdsf";

            if (dd == null)
            {
                App.Current.MainPage = new Pages.Logon.Facebook();
                dfsdf = "sdfsdfdsf";
            }
            else
            {
                dfsdf = "sdfsdfdsf";
                this.HandleLoginFaceBookSucceeded(this, null);
            }

            dfsdf = "sdfsdfdsf";


        }

        public void HandleLoginFaceBookSucceeded(object sender, EventArgs e)
        {
            string ddf = "";

            if (e == null)
            {
                ddf = "";
                KiMobile.Settings.Settings.LogonData.LogonType = Settings.Enum.LogonType.Facebook;
                KiMobile.Settings.Settings.LogonData.FaceBook = new Settings.LogonDataFaceBook
                {
                    Account = AccountData.Facebook,
                    Token = AccountData.Facebook.Properties["access_token"],
                    TokenExpiresIn = Convert.ToUInt64(AccountData.Facebook.Properties["expires_in"])
                };
            }
            else
            {
                ddf = "";
                AuthenticatorCompletedEventArgs dfe = (AuthenticatorCompletedEventArgs)e;
                AccountData.Facebook = dfe.Account;

            }

            ddf = "";

            //awaits writing token to storage and resets the MainPage UI
            //await storeToken();
            //MainPage = new Welcome();

            //  Save account data to accountStorage


            //  Get information from facebook.



            AccountCommunicationFaceBook.GetProfileData();


            var dsdfdsfds = "sdfsdf";


            //var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, dfe.Account);
            //await request.GetResponseAsync().ContinueWith(t =>
            // {
            //     if (t.IsFaulted)
            //         ddf = "Error: " + t.Exception.InnerException.Message;
            //     else if (t.IsCanceled)
            //         ddf = "Canceled";
            //     else
            //     {
            //         var obj = JsonValue.Parse(t.Result.GetResponseText());
            //         ddf = "Logged in as " + obj["name"];
            //     };


            // });

            Settings.Settings.UserIsLoggedIn = true;
            var dsfsdf = "sdfsdfdsf";
            Settings.Settings.NavPage = Settings.Enum.Pages.MainPage;
            App.Current.MainPage = new Pages.MainPage();

        }

        public void CancelLoginAction(object sender, EventArgs e)
        {
            //if login cancelled, user will be redirected back to the sign-in page
            //MainPage = new SignIn();
            var sdfdsfdsf = "sdfsdf";
        }
    }
}
