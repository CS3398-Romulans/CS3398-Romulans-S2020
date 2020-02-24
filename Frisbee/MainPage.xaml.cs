using System;
using System.IO;
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


    }
}