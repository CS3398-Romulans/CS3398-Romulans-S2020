using System;
using Frisbee.Services;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms;
using Frisbee.Models;
using Newtonsoft.Json;
using Frisbee.ViewModels;

namespace Frisbee
{
    public partial class Login : ContentPage
    {
        public WebView facebookWebView;
        public string apiRequest;
        private string facebookJsonData;

        public Login()
        {
            InitializeComponent();

            apiRequest =
                 "https://www.facebook.com/v6.0/dialog/oauth?client_id="
                 + FacebookAuthority.getInstance().clientID
                 + "&display=popup&respone_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html";
        }

        void LoginButtonClicked(object sender, EventArgs e)
        {
           /* facebookWebView = new WebView
            {
                Source = apiRequest,

            };

            facebookWebView.Navigated += WebViewOnNavigated;
            facebookWebView.Navigating += webViewOnNavigating;*/

           


           //Content = facebookWebView;



            //await Navigation.PushModalAsync( new MainPage());
        }

        public async void webViewOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            
            //facebookWebView.IsVisible = false;
            if (e.Url.StartsWith("http://www.facebook.com/"))
            {
                e.Cancel = true;
                await Navigation.PushModalAsync(new MainPage());
            }
        }


        public async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {

            var accessToken = ExtractAccessTokenFromUrl(e.Url);

            if (accessToken != "")
            {
                var cm = BindingContext as FacebookViewModel;
                await GetFacebookProfileAsync(accessToken);

            }


        }

        public string ExtractAccessTokenFromUrl(string url)
        {
            if (url.Contains("access_Token") && url.Contains("expires_in="))
            {
                var at = url.Replace("http://www.facebook.com/connect/login_success.html#access_token=", "");

                var accessToken = at.Remove(at.IndexOf("&expires_in="));

                return accessToken;
            }
            return string.Empty;
        }

        public async Task GetFacebookProfileAsync(string accessToken)
        {

            var requestUrl = "https://graph.facebook.com/v2.7/me"
                + "?fields=name,picture"
                + "&access_token=" + accessToken;

            var httpClient = new HttpClient();

            facebookJsonData = await httpClient.GetStringAsync(requestUrl);

        }
    }
}

     
    