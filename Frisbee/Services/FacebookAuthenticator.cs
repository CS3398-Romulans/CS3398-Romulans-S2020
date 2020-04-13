using System;
using Xamarin.Auth;
using Frisbee.Models;

namespace Frisbee.Services
{
    public class FacebookAuthenticator
    {
        private IFacebookAuthenticationDelegate _authenticationDelegate;
        private OAuth2Authenticator _auth;
        public FacebookAuthenticator(string clientID, string scope, IFacebookAuthenticationDelegate authenticationDelegate)
        {
            _authenticationDelegate = authenticationDelegate;
            _auth = new OAuth2Authenticator(
                clientID,
                scope,
                new Uri("https://www.facebook.com/dialog/oauth/"),
                new Uri("https://www.facebook.com/connect/login_success.html"),
                null,
                false
                );

            _auth.Completed += OnAuthenticationCompleted;
            _auth.Error += OnAuthenticationFailed;
        }

        public OAuth2Authenticator GetAuthenticator()
        {
            return _auth;
        }

        private void OnAuthenticationCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            if (e.IsAuthenticated)
            {
                var token = new FacebookOAuthToken
                {
                    AccessToken = e.Account.Properties["access_token"]
                };
                _authenticationDelegate.OnAuthenticationCompleted(token);
            }
            else
            {
                //user is not authenticates
                _authenticationDelegate.OnAuthenticationCanceled();
            }

        }

        private void OnAuthenticationFailed(object sender, AuthenticatorErrorEventArgs e)
        {
            _authenticationDelegate.OnAuthenticationFailed(e.Message, e.Exception);
        }

    }
}
