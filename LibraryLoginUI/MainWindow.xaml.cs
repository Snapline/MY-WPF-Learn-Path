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
            this.DataContext = new LoginViewModel(this);
        }

    }

}
