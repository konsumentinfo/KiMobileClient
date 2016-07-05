using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace KiMobile.Main.Pages.Logon
{
    public class MainLogon : ContentPage
    {
        static string _TokenFacebook;

        public static string FaceBookToken
        {
            get
            {
                return _TokenFacebook;
            }
            set
            {
                _TokenFacebook = value;
                var dfsdf = "sdfdsf";
            }
        }

        public MainLogon()
        {

            //Eventsfired from the LoginPage to trigger actions here
            Facebook.LoginFaceBookSucceeded += HandleLoginFaceBookSucceeded;
            Facebook.LoginFaceBookCancelled += CancelLoginAction;


            //  Build page design

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


        }

        void DoFaceBookLogon(object sender, EventArgs e)
        {


            App.Current.MainPage = new Pages.Logon.Facebook();
            var dfsdf = "sdfsdfdsf";
        }

        public async void HandleLoginFaceBookSucceeded(object sender, EventArgs e)
        {
            //awaits writing token to storage and resets the MainPage UI
            //await storeToken();
            //MainPage = new Welcome();



            var dsfsdf = "sdfsdfdsf";

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
