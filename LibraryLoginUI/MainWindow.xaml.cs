using System.Windows;

namespace LibraryLoginUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        LoginViewModel loginViewModel;
        public MainWindow()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
            this.DataContext = loginViewModel;
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {

            if (loginViewModel.Username == "wpf" && loginViewModel.Password == "666")
            {
                Home home = new Home();
                home.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("输入的用户名或密码不正确");
                loginViewModel.Username = "";
                loginViewModel.Password = "";
            }
        }
    }

}
