using System;
using System.Collections.Generic;
using System.Text;

namespace Frisbee.Services
{
    public class OAuthSettings
    {
        public OAuthSettings(
			string clientId,
			string scope,
			string authorizeUrl,
			string redirectUrl)
		{
            ClientId = clientId;
			Scope = scope;
			AuthorizeUrl = authorizeUrl;
			RedirectUrl = redirectUrl;
		}

		public string ClientId { get; private set; }
		public string Scope { get; private set; }
		public string AuthorizeUrl { get; private set; }
		public string RedirectUrl { get; private set; }
	}
}
