using System;
using System.Collections.Generic;
using System.Text;
using Frisbee.Services;
using Xamarin.Forms;

namespace Frisbee.ViewModels
{
    class ProfilePage : BaseContentPage
    {
        Label label;

        public ProfilePage()
        {
            label = new Label()
            {
                
                Text = "Hello" + App.Instance.facebookViewModel.FacebookProfile.FirstName,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Content = label;

            MessagingCenter.Subscribe<FacebookViewModel>(this, "Successful_Login", (sender) =>
            {
                System.Diagnostics.Debug.WriteLine("Profile Name: ");

                label.Text = App.Instance.facebookViewModel.FacebookProfile.FirstName;
            });
        }
    }  
}
