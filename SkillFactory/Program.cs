using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
        class User
        {
            private string login;

            public string Login
            {
                get
                {
                    return login;
                }

                set
                {
                    if (value.Length < 3)
                    {
                        Console.WriteLine("Login must be at least 3 characters long");
                    }
                    else
                    {
                        login = value;
                    }
                }
            }

            private string email;

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    if (!value.Contains('@'))
                    {
                        Console.WriteLine("Incorrect adress");
                    }
                    else
                    {
                        email = value;
                    }
                }
            }
        }
    }
}
