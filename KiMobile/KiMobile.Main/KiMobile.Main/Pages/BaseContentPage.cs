using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace KiMobile.Main.Pages
{
    public class BaseContentPage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!Settings.Settings.UserIsLoggedIn)
            {
                // Navigation.PushModalAsync(new Logon.MainLogon());
            }
        }
    }
}

