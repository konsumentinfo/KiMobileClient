using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KiMobile
{
	public class App : Application
	{
		public App ()
		{
            // The root page of your application


           
        }
        void LogonOnButtonClicked(object sender, EventArgs e)
        {
            //  Go to main logonpage
            //App.Current.MainPage = new Pages.Logon.MainLogon();

        }

        protected override void OnStart ()
		{
            // Handle when your app starts
            App.Current.MainPage = new Pages.Logon.MainLogon();
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
            App.Current.MainPage = new Pages.Logon.MainLogon();
            // Handle when your app resumes
        }
	}
}
