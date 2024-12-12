using System.Windows;
using PokemonLike.Views;

namespace pokemon_like
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var loginView = new LoginView();
            loginView.Show(); 
            this.Close(); 
        }

        private void SignupButton_Click(object sender, RoutedEventArgs e)
        {
            var signupView = new SignupView();
            signupView.Show(); 
            this.Close(); 
        }
        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            var connectView = new SettingsView();
            connectView.Show(); 
        }
    }
}