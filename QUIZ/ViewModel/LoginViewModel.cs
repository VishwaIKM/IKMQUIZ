using MaterialDesignThemes.Wpf;
using MicroMvvm;
using QUIZ.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using QUIZ.Model;

namespace QUIZ.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            int a = 0;
        }
        #region Members and Inst.


        private bool _isloginvisibile = true;
        UserModel _login = new UserModel();
        public readonly PaletteHelper paletteHelper = new PaletteHelper();
        #endregion

        #region Properties
        public UserModel Login
        {
            get => _login;
            set { _login = value; }
        }
        public string UserID
        {
            get => Login.UserId;
            set
            {
                if (Login.UserId != value)
                {
                    Login.UserId = value;
                    RaisePropertyChanged("UserID");
                }
            }
        }
        public string Password
        {
            get => Login.Password;
            set
            {
                if (Login.Password != value)
                {
                    Login.Password = value;
                    RaisePropertyChanged("Password");
                }
            }
        }
        public bool IsLoginButtonEnable
        {
            get => _isloginvisibile;
            set
            {
                if (_isloginvisibile != value)
                {
                    _isloginvisibile = value;
                    RaisePropertyChanged("IsLoginButtonEnable");
                }
            }
        }
        public bool IsDarkTheme { get; set; }

        #endregion

        #region Methods

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region ICommand BUTTON Method 
        void LoginCommandMethodExcute()
        {
            IsLoginButtonEnable = false;
            string username = UserID;
            string password = Password;
         
         
            IsLoginButtonEnable = true;
        }
        void ExitCommandMethodExcute()
        {
            Application.Current.Shutdown();
        }
        void ToogleCommandMethodExecute()
        {
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }
        bool CanThisMethodExecute() { return true; }

        #endregion

        #region ICommand
        public ICommand LoginCommand { get { return new RelayCommand(LoginCommandMethodExcute, CanThisMethodExecute); } }
        public ICommand ToggleCommand { get { return new RelayCommand(ToogleCommandMethodExecute, CanThisMethodExecute); } }
        public ICommand ExitAppCommand { get { return new RelayCommand(ExitCommandMethodExcute, CanThisMethodExecute); } }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
