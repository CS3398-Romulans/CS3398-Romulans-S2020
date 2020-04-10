using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Frisbee
{
    public partial class App : Application
    {

        public static string Username { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NewMasterDetailPage();
        }

        protected override void OnStart()
        { 
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
