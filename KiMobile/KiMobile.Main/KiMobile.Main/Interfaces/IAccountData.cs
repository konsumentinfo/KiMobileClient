using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace KiMobile.Main.Interfaces
{
    public interface IAccountData
    {
        Account Facebook { get; set; }
        void FacebookDeleteCredentials();
    }
}
