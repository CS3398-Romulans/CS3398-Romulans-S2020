using Frisbee;
using Frisbee.Models;
using OAuth2Demo.XForms.iOS;
using System;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Login), typeof(LoginPageRenderer))]

namespace OAuth2Demo.XForms.iOS
{
    public class LoginPageRenderer : PageRenderer
    {
        
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);


            var auth = new OAuth2Authenticator(
                clientId: App.Instance.oAuthSettings.ClientId, // your OAuth2 client id
                scope: App.Instance.oAuthSettings.Scope, // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: new Uri(App.Instance.oAuthSettings.AuthorizeUrl), // the auth URL for the service
                redirectUrl: new Uri(App.Instance.oAuthSettings.RedirectUrl)); // the redirect URL for the service

            auth.Completed += (sender, eventArgs) =>
            {
                // We presented the UI, so it's up to us to dimiss it on iOS.
                App.Instance.SuccessfulLoginAction.Invoke();

                if (eventArgs.IsAuthenticated)
                {
                    // Use eventArgs.Account to do wonderful things
                    App.Instance.SaveToken(eventArgs.Account.Properties["access_token"]);
                    //await App.Instance.facebookViewModel.SetFacebookUserProfileAsync(App.Instance.Token);
                }
                else
                {
                    // The user cancelled
                }
            };

            PresentViewController(auth.GetUI(), true, null);
        }
    }
}