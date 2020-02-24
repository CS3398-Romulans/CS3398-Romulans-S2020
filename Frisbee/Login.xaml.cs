using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Frisbee
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }


         async void LoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync( new MainPage());
        }
    }
}
