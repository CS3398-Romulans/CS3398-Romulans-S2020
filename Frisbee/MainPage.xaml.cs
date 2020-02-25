using System;
using System.Threading.Tasks;
using Plugin.Media;
using Xamarin.Forms;


namespace Frisbee
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            HelloMessage.Text = "Hello " + App.Username + "!";
         }

        private async void CameraButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });
            }
            catch(Exception w)
            {
                throw new Exception(w.Message);
            }
        }


    }
}