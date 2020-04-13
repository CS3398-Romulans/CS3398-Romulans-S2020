using System;
using Frisbee.ViewModels;
using Xamarin.Forms;

namespace Frisbee
{
    public class Profile : BaseContentPage
    {
        public Profile()
        {

            Content = new Label()
            {
                Text = "Hello",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,

            };
        }
    }
}
