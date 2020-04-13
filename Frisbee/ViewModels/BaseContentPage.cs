using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Frisbee.ViewModels
{
    public class BaseContentPage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();


            if (!App.Instance.IsAuthenticated)
            {
               
                Navigation.PushModalAsync(new Login());
            }
          
        }
    }
}
