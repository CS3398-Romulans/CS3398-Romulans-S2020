using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Frisbee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewMasterDetailPageDetail : ContentPage
    {
        public NewMasterDetailPageDetail()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButtonClicked;
        }

       private async void CameraButtonClicked(object sender, EventArgs e)
        {
          
            var photo = await CrossMedia.Current.TakePhotoAsync(
                new Plugin.Media.Abstractions.StoreCameraMediaOptions() {SaveToAlbum = true}); ;


           if (photo !=null)
                pic.Source = ImageSource.FromStream(() => { return photo.GetStream(); });


        }
    }
}
