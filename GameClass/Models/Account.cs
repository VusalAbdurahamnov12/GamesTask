using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using GameClass.Extension;
using GameClass.CustomException;
namespace GameClass.Models
{
    internal class Account
    {
        private string _password;
        private string _email;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            
            set 
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value)) _name = value;
                else throw new StringNullEmptyWhiteSpcaeException("This cant be null , whitespace or empty");
            }
        }
        public string EMail
        {
            get
            {
                return _email;
            }
            set
            {
                if (EmailChecker(value) == true) _email = value;
                else throw new Exception();
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value) == true) _password = value;
                else throw new Exception();
            }
        }

        public Account(string name, string email, string password)
        {
            Name = name;
            EMail = email;
            Password = password;
        }

        public string ShowInfo()
        {
            return $@"Name-{Name}
E-Mail-{EMail}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

        public bool PasswordChecker(string password)
        {
            Regex hasNumber = new Regex(@"[0-9]+");
            Regex hasUpperChar = new Regex(@"[A-Z]+");
            Regex hasMinimum8Chars = new Regex(@".{8,}");
            Regex hasLower = new Regex(@"[a-z]+");

            bool isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password) && hasLower.IsMatch(password);
            return isValidated;
        }
        #region Email Checker (Optional)
        public bool EmailChecker(string email)
        {
            Regex emailValid = new Regex(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,13})+$");
            bool isEmailValid = emailValid.IsMatch(email);
            return isEmailValid;
        }
        #endregion

    }
}
