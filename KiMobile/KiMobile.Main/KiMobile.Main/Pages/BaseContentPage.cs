using KiMobile.Main.Interfaces;
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
        protected IAccountData AccountData { get; set; } = DependencyService.Get<IAccountData>();
        

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!Settings.Settings.UserIsLoggedIn)
            {
                    Navigation.PushModalAsync(new Logon.MainLogon());
            }
        }
    }
}

