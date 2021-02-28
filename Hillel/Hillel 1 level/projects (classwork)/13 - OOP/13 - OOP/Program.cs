using System;
using System.Collections.Generic;

namespace _13___OOP
{
    class Auth
    {
        Dictionary<string, string> login_pass = new Dictionary<string, string>();
        private string login = "undefined";
        private string password = "undefined";

        void Init()
        {
            login_pass.Add("login1", "pass1");
        }

        public Auth(string login, string password)
        {
            Init();

                if (login_pass.ContainsKey(login) && login_pass.ContainsValue(password))
                {
                    Console.WriteLine("You are auth...");
                   
                }
                else
                    throw new Exception("AUTH WRONG.");
        }
        
    }

    class User
    {
        #region Fields
        private string name;
        private string sName;
        private byte age;
        private string login;
        private string password;
        #endregion

        #region Properties
        public string Name
        { 
        get { return name; }
        set {
                if (value.Length >= 5 && value.Length < 15)
                { 
                    name = value;
                }
                else
                { 
                    throw new ArgumentException("15 > Name.Length > 5");
                }
            }
        }

        public string SName
        {
            get { return sName; }
            set
            {
                if (value.Length >= 5 && value.Length < 15)
                {
                    sName = value;
                }
                else
                {
                    throw new ArgumentException("15 > SName.Length > 5");
                }
            }
        }

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = isValidPassword(value); }
        }
        #endregion

        #region public Methods
        public void PrintInfo()
        {
            Console.WriteLine($"{name} {sName} {password}");
        }
        #endregion

        #region Private Methods
        private string isValidPassword(string value)
        {
            byte countIsDigit = 0;
            byte countIsUCase = 0;
            byte countIsLCase = 0;
            byte countIsSpecialSymbol = 0;

            for (int i = 0; i < value.Length; i++)
            {

                if (char.IsDigit(value[i]))
                {
                    countIsDigit++;
                }

                if (char.IsUpper(value[i]))
                {
                    countIsUCase++;
                }
                if (char.IsLower(value[i]))
                {
                    countIsLCase++;
                }
                if (!char.IsLetterOrDigit(value[i]))
                {
                    countIsSpecialSymbol++;
                }
            }

            if (countIsDigit > 0 &&
                countIsLCase > 0 &&
                countIsLCase > 0 &&
                countIsSpecialSymbol > 0 &&
                value.Length > 7)
            {
                return value;
            }
            else
            {
                throw new ArgumentException("Password invalid");
            }
        }
        #endregion

        #region User's constructor
        public User(string name, string sName, byte age, string login, string password)
        {

        }
        #endregion
    }

    class Program
    {
    
        static void Main(string[] args)
        {
            Auth auth = new Auth("login111","password222");
            Registration();
        }

        static void Registration()
        {
            User user = new User();
            Console.Write("Enter name : ");
            user.Name = Console.ReadLine();

            Console.Write("Enter sname : ");
            user.SName = Console.ReadLine();

            Console.Write("Enter password : ");
            user.Password = Console.ReadLine();

            user.PrintInfo();
        }
    }
}
