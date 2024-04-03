using System;

//   THIS PROGRAM IS CREATED BY:

//   XXXXx   XXXXx   XXXXXX  XXX
//   XX  XX  XX  XX  XX      XXX
//   XX  XX  XXXXx   XXXXX   XXX
//   XX  XX  XX  XX  XX      XXX
//   XXXXx   XX  XX  XXXXXX  XXX


namespace CodeByDrei

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username: ");
            string Username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string Password = Console.ReadLine();

            if (Username == "Admin" && Password == "Admin1234!") 
            {
                Console.WriteLine("\n\nLogged in successfully.");
                return;
            }

            else
            {
                Console.WriteLine("\n\nWrong credentials, please try again. (3 attempts left)");
            }
            {
                Console.Write("\n\nEnter Username: ");
                Username = Console.ReadLine();

                Console.Write("Enter Password: ");
                Password = Console.ReadLine();

                if (Username == "Admin" && Password == "Admin1234!")

                {
                    Console.WriteLine("\n\nLogged in successfully.");
                    return;
                }

                else
                { 
                    Console.WriteLine("\n\nWrong credentials, please try again. (2 attempts left)");
                }
                {
                    Console.Write("\n\nEnter Username: ");
                    Username = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    Password = Console.ReadLine();

                    if (Username == "Admin" && Password == "Admin1234!")

                    {
                        Console.WriteLine("\n\nLogged in successfully.");
                        return;
                    }

                    else
                    {
                        Console.WriteLine("\n\nWrong credentials, please try again. (1 attempt left)");
                    }
                    {
                        Console.Write("\n\nEnter Username: ");
                        Username = Console.ReadLine();

                        Console.Write("Enter Password: ");
                        Password = Console.ReadLine();

                        if (Username == "Admin" && Password == "Admin1234!")

                        {
                            Console.WriteLine("\n\nLogged in successfully.");
                            return;
                        }

                        else
                        {
                            Console.WriteLine("\n\nYour account has been temporarily locked, please try again later.");
                        }

                    }

                }

            }

        }

    }

}
