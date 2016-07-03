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
        public static event EventHandler LoginSucceeded;
        public static event EventHandler LoginCancelled;
        public static Object sender;
        public static void LoginSuccess()
        {
            //Invoked and then sent to the App.cs
            LoginSucceeded(sender, EventArgs.Empty);

        }

        public static void LoginCancel()
        {
            //Invoked and then sent to the App.cs
            LoginCancelled(sender, EventArgs.Empty);

        }
    }
}
