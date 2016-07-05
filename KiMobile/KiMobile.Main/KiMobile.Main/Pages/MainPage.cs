using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace KiMobile.Main.Pages
{
    public class MainPage : BaseContentPage
    {
        public MainPage()
        {
            if (Settings.Settings.NavPage == null)
            {
                Settings.Settings.NavPage = "MainPage";
            }
                

            if (Settings.Settings.NavPage != "MainPage")
            {
                var dsfdsfd = "sdfsdfd";
            }
            var dsfdddsfd = "sdfsdfd";

            var BtnDebug = new Button()
            {
                Text = "Debug"
            };
            BtnDebug.Clicked += DoPageShowDebug;

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Main Page" }, BtnDebug
                }
            };


        }

        void DoPageShowDebug(object sender, EventArgs e)
        {
            App.Current.MainPage = new Pages.DebugPage();

        }

    }
}
