using System;
namespace Frisbee.Models

{
    public abstract class ApiAuthority
    {
        public ApiAuthority() { }

        #region Singleton
        private static ApiAuthority obj;

        public static ApiAuthority getInstance()
        {
            if (obj == null)
                obj = new ApiAuthority();
            return obj;
        }

        #endregion

        public string ClientID = "197556254831511";
        public string kClientScope = "email";
    }
}
