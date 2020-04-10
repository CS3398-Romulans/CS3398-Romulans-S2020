using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Frisbee.ViewModels
{
    class ProfilePage : BaseContentPage
    {
        FacebookViewModel facebookViewModel = new FacebookViewModel();

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await facebookViewModel.SetFacebookUserProfileAsync(App.Instance.Token);
        }


        public ProfilePage()
        {
            Content = new Label()
            {
                Text = "Hello" + facebookViewModel.FacebookProfile.FirstName,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }  
}
