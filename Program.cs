using System.ComponentModel;

namespace Week2ChallengeLab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctUserName = "JongDo";
            string correctPassword = ".";
            bool success = false;

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("Please enter your username: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Please enter your password: ");
                string password = Console.ReadLine();

                if (userName == correctUserName && password == correctPassword)
                {
                    success = true;
                    break;
                }
            }  
            if (success) 
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Account blocked!!!");
            }
             
        }    
    }
}
//Write a C# Sharp program that takes userid and password as input (type string).
//After 3 wrong attempts, user will be rejected.
