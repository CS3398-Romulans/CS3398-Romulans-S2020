using System;
using System.Collections.Generic;
using System.Text;

namespace Frisbee.Models
{
    public class FacebookAuthority : ApiAuthority
    {


        #region Singleton
        public static FacebookAuthority instance;

        public static ApiAuthority getInstance()
        {
            if (instance == null)
                instance = new FacebookAuthority();
            return instance;
        }
        #endregion

        public string clientID = "197556254831511";
        public string clientScope = "email";
        public string authorizeUrl = "https://www.facebook.com/dialog/oauth/";
        public string redirectUrl = "https://www.facebook.com/connect/login_success.html";
       
    }
}
