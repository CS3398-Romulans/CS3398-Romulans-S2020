using System;
using System.Threading.Tasks;
using Plugin.Media;
using Xamarin.Forms;


namespace Frisbee
{
    public partial class Gallery : ContentPage
    {
        public Gallery()
        {
            InitializeComponent();

        }

        async void BackButtonClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}

