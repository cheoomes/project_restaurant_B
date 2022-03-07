using System;

namespace Account_aanmaken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want your username to be?");
            string username = Console.ReadLine();
            Console.WriteLine("What do you want your password to be? ");
            string password = Console.ReadLine();
            Console.WriteLine("What is your phonenumber?");
            string phonenumber = Console.ReadLine();
            int phonenumber_lenght = phonenumber.Length;
            if (phonenumber_lenght < 10)
            {                
                while (phonenumber_lenght < 10)
                {
                    Console.WriteLine("Please enter a valid phonenumber");
                    Console.WriteLine("What is your phonenumber?");
                    phonenumber = Console.ReadLine();
                    phonenumber_lenght = phonenumber.Length;
                }
            }
            Tuple<string, string> password_and_username = Tuple.Create(username, password);

            Console.WriteLine("What is your username?");
            string given_username = Console.ReadLine();
            Console.WriteLine("What is your password?");
            string given_password = Console.ReadLine();
        
            if (given_username == password_and_username.Item1 && given_password == password_and_username.Item2)
            {
                Console.WriteLine("You have logged in");
            }
            else
            {
                Console.WriteLine("Your password or username is incorrect!!");
            }
        }   
    }
}
