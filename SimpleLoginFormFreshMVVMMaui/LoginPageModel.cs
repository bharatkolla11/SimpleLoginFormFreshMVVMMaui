using FreshMvvm.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleLoginFormFreshMVVMMaui
{
    internal class LoginPageModel : FreshBasePageModel
    {
        #region #Properties#
        //UserNameLabel
        string _userNameLabel = string.Empty;
        public string UserNameLabel
        {
            get { return _userNameLabel; }
            set
            {
                _userNameLabel = value;
                RaisePropertyChanged("UserNameLabel");
            }
        }
        //UserNameEntryText
        string _userNameEntryText = string.Empty;
        public string UserNameEntryText
        {
            get { return _userNameEntryText; }
            set
            {
                _userNameEntryText = value;
                RaisePropertyChanged("UserNameEntryText");
            }
        }
        //UserNameEntryPlaceHolder
        string _userNameEntryPlaceHolder = string.Empty;
        public string UserNameEntryPlaceHolder
        {
            get { return _userNameEntryPlaceHolder; }
            set
            {
                _userNameEntryPlaceHolder = value;
                RaisePropertyChanged("UserNameEntryPlaceHolder");
            }
        }
        //PasswordNameLabel
        string _passwordNameLabel = string.Empty;
        public string PasswordNameLabel
        {
            get { return _passwordNameLabel; }
            set
            {
                _passwordNameLabel = value;
                RaisePropertyChanged("PasswordNameLabel");
            }
        }
        //PasswordEntryText
        string _passwordEntryText = string.Empty;
        public string PasswordEntryText
        {
            get { return _passwordEntryText; }
            set
            {
                _passwordEntryText = value;
                RaisePropertyChanged("PasswordEntryText");
            }
        }
        //PasswordEntryPlaceHolder
        string _passwordEntryPlaceHolder = string.Empty;
        public string PasswordEntryPlaceHolder
        {
            get { return _passwordEntryPlaceHolder; }
            set
            {
                _passwordEntryPlaceHolder = value;
                RaisePropertyChanged("PasswordEntryPlaceHolder");
            }
        }
        //SubmitButtonText
        string _submitButtonText = string.Empty;
        public string SubmitButtonText
        {
            get { return _submitButtonText; }
            set
            {
                _submitButtonText = value;
                RaisePropertyChanged("SubmitButtonText");
            }
        }
        #endregion

        #region #Commands#
        public ICommand SubmitButtonCommand { get; }
        #endregion

        #region #Constructor#
        public LoginPageModel()
        {
            UserNameLabel = "Username";
            PasswordNameLabel = "Password";
            UserNameEntryPlaceHolder = "Entry Username";
            PasswordEntryPlaceHolder = "Enter Password";
            SubmitButtonText = "Login/Submit";

            SubmitButtonCommand = new Command(async () => await NavigateToMainPage());
        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
        }

        #endregion

        #region #Methods#
        private async Task NavigateToMainPage()
        {
            try
            {
                if(string.IsNullOrEmpty(UserNameEntryText) || string.IsNullOrEmpty(PasswordEntryText))
                {
                    await CoreMethods.DisplayAlert("Error", "One or More required fields are empty", "OK");
                    return;
                }
            }
            catch(Exception ex)
            {
                await CoreMethods.DisplayAlert("Error", "Navigation to Main Page Failed", "OK");
            }
        }
        #endregion
    }
}
