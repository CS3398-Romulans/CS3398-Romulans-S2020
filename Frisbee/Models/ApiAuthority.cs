using System;
namespace Frisbee
{
    public class ApiAuthority
    {


        private ApiAuthority() { }

        #region Singleton
        private static ApiAuthority obj;

        public static ApiAuthority getInstance()
        {
            if (obj == null)
                obj = new ApiAuthority();
            return obj;
        }

        #endregion

        public string facebookClientID = "197556254831511";

    }
}
