using Frisbee.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Xamarin.Forms;

namespace Frisbee.ViewModels
{
    public class TwitterViewModel
    {
        private TwitterProfile _twitterProfile;

        public TwitterProfile TwitterProfile
        {
            get { return _twitterProfile; }
            set
            {
                _twitterProfile = value;
                OnPropertyChanged();
                MessagingCenter.Send(this, "Successful_Login", _twitterProfile);
            }
        }

        public async Task SetFacebookUserProfileAsync(string accessToken)
        {
            var twitterServices = new TwitterService();

            TwitterProfile = await twitterServices.GetTwitterProfileAsync(accessToken);
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}