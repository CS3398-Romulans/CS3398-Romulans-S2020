using System;
using Frisbee.Models;

namespace Frisbee.Services
{
   
      public interface IFacebookAuthenticationDelegate
      {
          void OnAuthenticationCompleted(FacebookOAuthToken token);
          void OnAuthenticationFailed(string message, Exception exception);
          void OnAuthenticationCanceled();
      }
    
}
