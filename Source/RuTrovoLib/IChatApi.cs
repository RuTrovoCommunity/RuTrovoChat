using System.Collections.Generic;
using RestSharp;

namespace RuTrovoLib
{
    public interface IChatApi
    {
        IRestResponse Auth();

        bool CheckTokenValidity(string token);
        List<string> GetMessages();

        
    }
}
