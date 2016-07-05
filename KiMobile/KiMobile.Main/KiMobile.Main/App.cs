using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KiMobile.Main
{
    public class App : Application
    {
        public App()
        {
            #region Test - remove 


            //    //  Test page
            //    var btn = new Button { Text = "Click me now!" };
            //    Button btnLogon = new Button { Text = "logon" };

            //    int count = 1;

            //    btn.Clicked += (sender, args) =>
            //    {
            //        btn.Text = $"Clicked {count} times.";
            //        count++;
            //    };

            //    btnLogon.Clicked += LogonOnButtonClicked;

            //    // The root page of your application
            //    MainPage = new ContentPage
            //    {
            //        Content = new StackLayout
            //        {
            //            VerticalOptions = LayoutOptions.Center,
            //            Children = {
            //                btn, btnLogon
            // //new Label {
            // //	HorizontalTextAlignment = TextAlignment.Center,
            // //	Text = "Welcome to Xamarin Forms!"
            // // }
            //}
            //        }
            //    };

            #endregion
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            App.Current.MainPage = new Pages.MainPage();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            App.Current.MainPage = new Pages.MainPage();
        }
    }
}
