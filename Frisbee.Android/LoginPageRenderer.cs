﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Frisbee;
using Frisbee.Droid;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Login), typeof(LoginPageRenderer))]

namespace Frisbee.Droid
{
        public class LoginPageRenderer : PageRenderer
        {
            protected override void OnModelChanged(VisualElement oldModel, VisualElement newModel)
            {
                base.OnModelChanged(oldModel, newModel);

                // this is a ViewGroup - so should be able to load an AXML file and FindView<>
                var activity = this.Context as Activity;

                var auth = new OAuth2Authenticator(
                    clientId: "", // your OAuth2 client id
                    scope: "", // the scopes for the particular API you're accessing, delimited by "+" symbols
                    authorizeUrl: new Uri(""), // the auth URL for the service
                    redirectUrl: new Uri("")); // the redirect URL for the service

                auth.Completed += (sender, eventArgs) => {
                    if (eventArgs.IsAuthenticated)
                    {
                        App.Instance.SuccessfulLoginAction.Invoke();
                        // Use eventArgs.Account to do wonderful things
                        App.Instance.SaveToken(eventArgs.Account.Properties["access_token"]);
                    }
                    else
                    {
                        // The user cancelled
                    }
                };

                activity.StartActivity(auth.GetUI(activity));
            }
        }
    }