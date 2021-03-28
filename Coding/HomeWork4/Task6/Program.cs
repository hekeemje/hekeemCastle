using System;

namespace Task6
{
    class DateBase // сымитировал класс как Базу данных где хранится данные об аккаунтах и тд.
    {
        public string account;
        public int moneyOnAccount;
    }

    class ConnectionToDataBase : DateBase // класс который отвечает за соединение с ней
    {
        public readonly bool Connection = true;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConnectionToDataBase connectToDataBase = new ConnectionToDataBase(); 
            // не совсем понял условий задания , сделал примерно так как понял условия , сымитировал бд и создал класс наследник который будет отвечать за коннект к ней
        }
    }
}
