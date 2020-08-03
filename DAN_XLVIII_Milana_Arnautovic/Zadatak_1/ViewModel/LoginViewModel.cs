using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        LoginView view;


        #region Constructors

        public LoginViewModel(LoginView view)
        {
            this.view = view;

        }
        #endregion

        #region Property

        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        #endregion

        #region Commands
        private ICommand login;
        /// <summary>
        /// Command login
        /// </summary>
        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new RelayCommand(LoginExecute);
                }
                return login;
            }
            set { login = value; }
        }
        /// <summary>
        /// Method for checking username and password
        /// </summary>
        /// <param name="o"></param>
        private void LoginExecute(object o)
        {
            try
            {
                string password = (o as PasswordBox).Password;
                if (Username == "Zaposleni" && password == "Zaposleni")
                {
                    MainWindow mw = new MainWindow();
                    view.Close();
                    mw.ShowDialog();
                }

                else if (JMBGisValid(Username)==true && Password == "Gost")
                {
                    GuestView guest = new GuestView(Username);
                    view.Close();
                    guest.Show();
                    return;
                }

                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        #endregion

        /// <summary>
        /// Validation for JMBG
        /// </summary>
        /// <param name="JMBG"></param>
        /// <returns></returns>
        /// <summary>
        /// Validation for JMBG
        /// </summary>
        /// <param name="JMBG"></param>
        /// <returns></returns>
        public static bool JMBGisValid(string JMBG)
        {
            //check lenght of JMBG
            if (JMBG.Length != 13)
                return false;

            //check if all characters in JMBG are number values
            for (int i = 0; i < JMBG.Length; i++)
            {
                if (!Char.IsNumber(JMBG, i))
                    return false;
            }

            DateTime now = DateTime.Now;
            int year = 0;
            //check if year part of the JMBG no is correct year
            if (Char.GetNumericValue(JMBG[4]) == 0)
            {
                year = 2000 + 10 * (int)Char.GetNumericValue(JMBG[5]) + (int)Char.GetNumericValue(JMBG[6]);

                if (year > now.Year)
                    return false;

            }
            else if (Char.GetNumericValue(JMBG[4]) == 9)
            {
                year = 1900 + 10 * (int)Char.GetNumericValue(JMBG[5]) + (int)Char.GetNumericValue(JMBG[6]);
            }
            else
                return false;

            //check if month part of JMBG no is correct month
            int month = (int)Char.GetNumericValue(JMBG[2]) * 10 + (int)Char.GetNumericValue(JMBG[3]);
            if (year == now.Year && month > now.Month)
                return false;

            if (month == 0 || month > 12)
                return false;

            //check if day part of JMBG no is correct day no.
            int day = (int)Char.GetNumericValue(JMBG[0]) * 10 + (int)Char.GetNumericValue(JMBG[1]);
            if (year == now.Year && month == now.Month && day >= now.Day)
            {
                return false;
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day == 0 || day > 31)
                    return false;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day == 0 || day > 30)
                    return false;
            }
            else if (month == 2)
            {
                if (DateTime.IsLeapYear(year))
                {
                    if (day == 0 || day > 29)
                        return false;
                }
                else
                {
                    if (day == 0 || day > 28)
                        return false;
                }
            }
            return true;
        }
    }
}
