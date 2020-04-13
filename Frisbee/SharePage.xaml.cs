using System;
using System.Collections.Generic;
using Xamarin.Essentials;
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
            await Navigation.PushModalAsync(new NewMasterDetailPageMaster());
        }

        async void FacebookButtonClicked(Object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareFileRequest
            {
                Title = "Hello",
                File = new ShareFile("Ultimate.png")
            });
        }

        void InstagramButtonClicked(Object sender, EventArgs e)
        {

        }

        void TwitterButtonClicked(Object sender, EventArgs e)
        {

        }
    }
}
