using System;


namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Username = "john";
            string Password = "pass123";
            int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == Username && password == Password)
                {
                    Console.WriteLine("Login successful.");
                    return;
                }
                else if (username == Username)
                {
                    Console.WriteLine("Invalid password.");
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }

                attempts++;
            }

            Console.WriteLine("Login failed.");


        }
    }
}
