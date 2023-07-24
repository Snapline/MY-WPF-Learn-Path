using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace LibraryLoginUI
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        private MainWindow _mainWindow;
        public LoginViewModel(MainWindow main)
        {
            _mainWindow = main;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private LoginModel _LoginM = new LoginModel();


        public string Username
        {
            get { return _LoginM.Username; }
            set
            {
                _LoginM.Username = value;
                RaisePropertyChanged("Username");
            }
        }


        public string Password
        {
            get { return _LoginM.Password; }
            set
            {
                _LoginM.Password = value;
                RaisePropertyChanged("Password");
            }
        }

        void LoginFunc()
        {
            if (Username == "wpf" && Password == "666")
            {
                Home home = new Home();
                home.Show();

                _mainWindow.Hide();
            }
            else
            {
                MessageBox.Show("输入的用户名或密码不正确");
                Username = "";
                Password = "";
            }
        }

        bool CanLoginExecute()
        {
            return true;
        }

        //命令
        public ICommand LoginAction
        {
            get
            {
                return new RelyCommand(LoginFunc, CanLoginExecute);
            }
        }

    }
}
