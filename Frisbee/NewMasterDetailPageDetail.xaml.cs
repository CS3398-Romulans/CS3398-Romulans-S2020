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
        }

       private async void CameraButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { SaveToAlbum = true}); ;
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
        }
    }
}
