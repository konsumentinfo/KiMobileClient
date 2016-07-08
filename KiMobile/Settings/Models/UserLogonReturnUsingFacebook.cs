using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiMobile.Models
{
    public class UserLogonReturnUsingFacebook
    {
        public UserLogonSharedModel Shared { get; set; }
        public AuthKeysModel AuthKeys { get; set; }
    }
    public class UserLogonSharedModel
    {
        public bool LicenseApproved { get; set; }
        public ulong UserId { get; set; }
        public string NickName { get; set; }
    }
    public class AuthKeysModel
    {
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }

    }
}
