using System;

// THIS PROGRAM IS CREATED BY:

//   XXXXx   XXXXx   XXXXXX  XXX
//   XX  XX  XX  XX  XX      XXX
//   XX  XX  XXXXx   XXXXX   XXX
//   XX  XX  XX  XX  XX      XXX
//   XXXXX   XX  XX  XXXXXX  XXX


namespace CodeByDrei

{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter Username:");
            string Username = Console.ReadLine();

            if (Username == "Admin") ;

            Console.Write("Enter Password:");
            string Password = Console.ReadLine();

            if (Password == "Admin1234!") ;

            else
            {
                Console.WriteLine("\n\nWrong credentials, please try again. (3 attempts left)");

                Console.Write("\nEnter Username:");
                Username = Console.ReadLine();

                if (Username == "Admin") ;

                Console.Write("Enter Password:");
                Password = Console.ReadLine();

                if (Password == "Admin1234!") ;

                {
                    Console.Write("\n\nWrong credentials, please try again. (2 attempts left)");

                    Console.Write("\n\nEnter Username:");
                    Username = Console.ReadLine();

                    if (Username == "Admin") ;

                    Console.Write("Enter Password:");
                    Password = Console.ReadLine();

                    if (Password == "Admin1234!") ;


                    {
                        Console.Write("\n\nWrong credentials, please try again. (1 attempt left)");

                        Console.Write("\n\nEnter Username:");
                        Username = Console.ReadLine();

                        if (Username == "Admin") ;

                        Console.Write("Enter Password:");
                        Password = Console.ReadLine();

                        if (Password == "Admin1234!") ;

                    }


                }


            }


        }

    }

}
        
