using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Frisbee.ViewModels
{
    class ProfilePage : BaseContentPage
    {


        public ProfilePage()
        {
            Content = new Label()
            {
                Text = "Hello" + App.Instance.facebookViewModel.FacebookProfile.FirstName,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }  
}
