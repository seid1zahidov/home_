using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp58.Interface;

namespace ConsoleApp58
{
    class User : IAccount
    {
        public string FullName;
        public string Email;
        private string _password;




        public string PassWord
        {
            get
            {
                return _password;
            }


            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;

                }


            }
        }

        public User(string email, string pasword)
        {
            Email = email;
            PassWord = pasword;

        }
        public new bool PasswordChecker(string password)
        {
            bool check = false;
            bool check1 = false;

            bool check2 = false;


            if (password.Length >= 8)
            {


                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        check = true;



                    }
                    else if (char.IsDigit(password[i]))
                    {
                        check1 = true;

                    }
                    else if (char.IsLower(password[i]))
                    {
                        check2 = true;
                    }

                }
                if (check && check1 && check2)
                {
                    return true;

                }
                while (check || check1 || check2)
                {
                    Console.WriteLine("Yeniden daxi ELE");
                    string a = Console.ReadLine();



                }


            }
            else
            {
                Console.WriteLine("Sifre 8 reqemden az olmamalidir");
            }

            return false;

        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Tam Adad: {FullName}");
            Console.WriteLine($"Email: {Email}");

        }
    }
}
