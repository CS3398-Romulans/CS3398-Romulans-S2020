using System;
using System.Collections.Generic;

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

        void FacebookButtonClicked(Object sender, EventArgs e)
        {

        }

        void InstagramButtonClicked(Object sender, EventArgs e)
        {

        }

        void TwitterButtonClicked(Object sender, EventArgs e)
        {

        }
    }
}
