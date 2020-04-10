using Frisbee.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Frisbee.Services;
namespace Frisbee
{
    public partial class App : Application
    {
		// just a singleton pattern so I can have the concept of an app instance
		static volatile App _Instance;
		static object _SyncRoot = new Object();
		public static App Instance
		{
			get
			{
				if (_Instance == null)
				{
					lock (_SyncRoot)
					{
						if (_Instance == null)
						{
							_Instance = new App();

							_Instance.OAuthSettings =
								new OAuthSettings(
									clientId: FacebookAuthority.getInstance().clientID,       // your OAuth2 client id 
									scope: "email",         // The scopes for the particular API you're accessing. The format for this will vary by API.
									authorizeUrl: "https://www.facebook.com/dialog/oauth/",     // the auth URL for the service
									redirectUrl: "https://www.facebook.com/connect/login_success.html");   // the redirect URL for the service

						
						}
					}
				}

				return _Instance;
			}
		}

		public OAuthSettings OAuthSettings{ get; private set; }

		NavigationPage _NavPage;

		public Page GetMainPage()
		{
			var mainPage = new MainPage();

			_NavPage = new NavigationPage(mainPage);

			return _NavPage;
		}

		public bool IsAuthenticated
		{
			get { return !string.IsNullOrWhiteSpace(_Token); }
		}

		string _Token;
		public string Token
		{
			get { return _Token; }
		}

		public void SaveToken(string token)
		{
			_Token = token;

			// broadcast a message that authentication was successful
			MessagingCenter.Send<App>(this, "Authenticated");
		}

		public Action SuccessfulLoginAction
		{
			get
			{
				return new Action(() => _NavPage.Navigation.PopModalAsync());
			}
		}
	}
}
/*
        public static string Username { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }

        protected override void OnStart()
        { 
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }*/
//}
