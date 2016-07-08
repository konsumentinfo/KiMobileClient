using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace KiMobile.Main.Pages
{
    public class DebugPage : BaseContentPage
    {
        public DebugPage()
        {
            var BtnPageMain = new Button()
            {
                Text = "MainPage"
            };
            BtnPageMain.Clicked += DoPageShowMainPage;


            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Debug Page!!" }, BtnPageMain
                }
            };
        }

        void DoPageShowMainPage(object sender, EventArgs e)
        {
            Settings.Settings.NavPage = Settings.Enum.Pages.MainPage;
            App.Current.MainPage = new Pages.MainPage();

        }

    }
}
