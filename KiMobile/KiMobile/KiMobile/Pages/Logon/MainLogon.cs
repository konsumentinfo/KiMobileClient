using System;
using System.Collections.Generic;
using System.Linq;
// using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace KiMobile.Pages.Logon
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
            }
        }

        public MainLogon ()
		{

            //Eventsfired from the LoginPage to trigger actions here
            Facebook.LoginFaceBookSucceeded += HandleLoginFaceBookSucceeded;
            Facebook.LoginFaceBookCancelled += CancelLoginAction;


        }

        public async void HandleLoginFaceBookSucceeded(object sender, EventArgs e)
        {
            //awaits writing token to storage and resets the MainPage UI
            //await storeToken();
            //MainPage = new Welcome();
            var dsfsdf = "sdfsdfdsf";



        }

        public void CancelLoginAction(object sender, EventArgs e)
        {
            //if login cancelled, user will be redirected back to the sign-in page
            //MainPage = new SignIn();
        }


    }
}
