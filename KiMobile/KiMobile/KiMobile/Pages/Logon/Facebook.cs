using System;
using System.Collections.Generic;
using System.Linq;
// using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace KiMobile.Pages.Logon
{
	public class Facebook : ContentPage
	{
		public Facebook ()
		{
            //Page is Rendered in CustomRenderer for IOS and Android

        }
        public static event EventHandler LoginFaceBookSucceeded;
        public static event EventHandler LoginFaceBookCancelled;
        public static Object sender;
        public static void LoginSuccess()
        {
            //Invoked and then sent to the App.cs
            LoginFaceBookSucceeded(sender, EventArgs.Empty);

        }

        public static void LoginCancel()
        {
            //Invoked and then sent to the App.cs
            LoginFaceBookCancelled(sender, EventArgs.Empty);

        }
    }
}
