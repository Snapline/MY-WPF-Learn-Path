using System.ComponentModel;

namespace LibraryLoginUI
{
    public class LoginViewModel:INotifyPropertyChanged
    {
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

    }
}
