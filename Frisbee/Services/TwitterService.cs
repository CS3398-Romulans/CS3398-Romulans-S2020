using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Frisbee.ViewModels;
using Newtonsoft.Json;
using ViewModels;
using Xamarin.Forms;

namespace Frisbee.Services
{
    public class TwitterService
    {
            public async Task<TwitterProfile> GetTwitterProfileAsync(string accessToken)
            {
                var requestUrl =
                    "https://graph.facebook.com/v2.7/me/?fields=name&access_token="
                    + accessToken;

                var httpClient = new HttpClient();

                var userJson = await httpClient.GetStringAsync(requestUrl);

                var facebookProfile = JsonConvert.DeserializeObject<TwitterProfile>(userJson);

                System.Diagnostics.Debug.WriteLine(facebookProfile + ": Created");

                
                return facebookProfile;
            }
    }
}

