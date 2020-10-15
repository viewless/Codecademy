using System;
using System.Collections.Generic;
using System.Text;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (Hidden == true)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.WriteLine(Password);
            }
        }

        public void Reset()
        {
            Password = string.Empty;
            Hidden = false;
        }
    }
}