using System;
using System.Collections.Generic;
using RestSharp;

namespace RuTrovoLib
{
    public class TwitchChatApi : IChatApi
    {
        public IRestResponse Auth()
        {
            RestClient client = new RestClient();
            var request =
                new RestRequest(
                    "https://id.twitch.tv/oauth2/authorize?response_type=token&client_id=jah9fieemhwuq558w5y5fzk8uva8hb&redirect_uri=http://localhost&scope=viewing_activity_read&state=c3ab8aa609ea11e793ae92361f002671",
                    Method.GET);
            return client.Execute(request);
        }

        public bool CheckTokenValidity(string token)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetMessages()
        {
            throw new System.NotImplementedException();
        }
    }
}