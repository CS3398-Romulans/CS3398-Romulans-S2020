using System;
namespace Frisbee.Models

{
    public abstract class ApiAuthority
    {
       
        public string clientID;
        public string clientScope;
        public string authorizeUrl;
        public string redirectUrl;
    }
}
