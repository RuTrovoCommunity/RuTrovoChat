using System.Windows;
using CefSharp.Wpf;
using RuTrovoLib;

namespace RuTrovoFirstIteration
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Browser AuthBrowser;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var chatApi = new TwitchChatApi();
            var t = chatApi.Auth();
            AuthBrowser = new Browser(t.ResponseUri.AbsoluteUri);
            AuthBrowser.Show();
            GetData.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResultURI.Visibility = Visibility.Visible;
            ResultURI.Content = AuthBrowser.ResultUrl;
        }
    }
}
