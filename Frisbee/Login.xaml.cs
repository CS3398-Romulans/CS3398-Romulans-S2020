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
            App.Username = this.Username.Text;
            await Navigation.PushModalAsync( new MainPage());
        }
    }
}
