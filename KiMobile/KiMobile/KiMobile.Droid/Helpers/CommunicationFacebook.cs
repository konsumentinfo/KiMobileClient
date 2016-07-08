using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.Json;

using Xamarin.Forms;
using Xamarin.Auth;

using KiMobile.Main.Interfaces;
using KiMobile.Droid.Helpers;
using KiMobile.Settings;
using System.Threading.Tasks;

[assembly: Dependency(typeof(CommunicationFacebook))]
namespace KiMobile.Droid.Helpers
{
    public class CommunicationFacebook : ICommunicationFacebook
    {
        public void GetProfileData()
        {
            Settings.Settings.LogonData.FaceBook.CommunicationResponse = "running";
            Settings.Settings.LogonData.FaceBook.CommunicationIsWorking = false;

            string ddf = "";
            
            var tmpReturn = new FacebookProfileData();

            var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, KiMobile.Settings.Settings.LogonData.FaceBook.Account);
            // var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me?fields=email,first_name,last_name,gender,picture"), null, e.Account);


            ddf = "dsfsdfdsf";

            Task<Xamarin.Auth.Response> getFbData = request.GetResponseAsync();

            // var response = await request.GetResponseAsync();
            // await getFbData;
            // var response = await getFbData;
            // var obj = JsonValue.Parse(response.Result.GetResponseText());

            var obj = JsonValue.Parse(getFbData.Result.GetResponseText());

            ddf = "dsfsdfdsf";

            #region Obj syntax facebook return data
            /*
                "birthday": "07/30/1932",
                "email": "",
                "first_name": "",
                "gender": "", 
                "id": "",
                "last_name": "",
                "link": "",
                "locale": "sv_SE",
                "name": "",
                "timezone": 2,
                "updated_time": "2016-04-22T18:42:25+0000",
                "verified": true
             * 
             * */
            #endregion

            if (obj != null)
            {
                ddf = "dsfsdfdsf";

                if (obj["birthday"] != null)
                {
                    string tmpBd = obj["birthday"].ToString().Replace("\"", "");
                    tmpReturn.Birtday = Convert.ToDateTime(tmpBd);

                }



                tmpReturn.Email = obj?["email"].ToString().Replace("\"", "");
                tmpReturn.FirstName = obj?["first_name"].ToString().Replace("\"", "");
                tmpReturn.LastName = obj?["last_name"].ToString().Replace("\"", "");
                tmpReturn.Id = obj?["id"].ToString().Replace("\"", "");

                if (obj["gender"] != null)
                {
                    tmpReturn.Gender = obj["gender"].ToString().Replace("\"", "");
                }

                tmpReturn.Name = obj?["name"].ToString().Replace("\"", "");
                tmpReturn.Link = obj?["link"].ToString().Replace("\"", "");


                if (obj["timezone"] != null)
                {
                    tmpReturn.TimeZone = obj["timezone"].ToString().Replace("\"", "");
                }

                if (obj["updated_time"] != null)
                {
                    string tmp = obj["updated_time"].ToString().Replace("\"", "");
                    tmpReturn.UpdateTime = Convert.ToDateTime(tmp);

                }
                

                if (obj["verified"] != null)
                {
                    string tmp = obj?["verified"].ToString().Replace("\"", "");
                    tmpReturn.Verified = Convert.ToBoolean(tmp);

                }
                

                KiMobile.Settings.Settings.UserProfileFaceBook = tmpReturn;
            }

            ddf = "dsfsdfdsf";

        }

    }
}