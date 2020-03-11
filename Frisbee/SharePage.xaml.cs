using System;
using System.Collections.Generic;
using Plugin.FacebookClient;
using Xamarin.Forms;

namespace Frisbee
{
    public partial class SharePage : ContentPage
    {
        public SharePage()
        {
            InitializeComponent();
        }

        async void BackButtonClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        async void FacebookButtonClicked(Object sender, EventArgs e)
        {
            FacebookResponse<bool> response = await CrossFacebookClient.Current.LoginAsync(new string[] { "email", "public_profile" });


        }

        void InstagramButtonClicked(Object sender, EventArgs e)
        {

        }

        void TwitterButtonClicked(Object sender, EventArgs e)
        {

        }
    }
}
