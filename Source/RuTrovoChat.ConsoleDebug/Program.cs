using CefSharp.Wpf;

using RuTrovoLib;

namespace RuTrovoChat.ConsoleDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatApi = new TwitchChatApi();
            var t = chatApi.Auth();
            var browser = new ChromiumWebBrowser(t.ResponseUri.AbsoluteUri);
            var k = browser;
        }
    }
}
