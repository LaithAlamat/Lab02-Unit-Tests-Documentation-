using System;

namespace Unit_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            UserInterface();
        }

        public static decimal balance = 5000;
        static void UserInterface()
        {
            
        Console.WriteLine("Welcome to your ATM account!");
            Console.WriteLine("Please choose an action:");
            Console.WriteLine("");
            Console.WriteLine("1) View Available Balance");
            Console.WriteLine("2) Cash Withdraw");
            Console.WriteLine("3) Cash Deposit");
            Console.WriteLine("4) Exit Account");
            
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1 || num == 2 || num == 3)
            {
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        ViewBalance();
                        break;
                    case 2:
                        Console.Clear();
                        Withdraw();
                        break;
                    case 3:
                        Console.Clear();
                        Deposit();
                        break;
                    
                }
            }
            else if (num == 4)
            {
                Console.WriteLine("Thank you fo using our ATM!");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please Select a Valid Number (1-4)!");
                Console.WriteLine("");

                UserInterface();

            }
        }
            public static decimal ViewBalance()
            {
                
                Console.WriteLine($"Your Available Balance is: {balance}");
                Console.WriteLine("");
            UserInterface();
            return balance;
            }

        public static void Withdraw()
        {
            Console.Clear();
            decimal input = 0;
            try
            {
                Console.WriteLine("Please Enter the Ammount you wish to Withdraw...");
                input = decimal.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid number...");
                Console.WriteLine(e.Message);
            }
            if(input<=balance)
            {
                balance = balance - input;

                Console.WriteLine("Withdraw was Sucessfull! ");
                Console.WriteLine("");

                ViewBalance();
                
            }
            else
            {
                Console.WriteLine("Ammount not available..");
                UserInterface();

            }
        }
        static void Deposit()
        {
            Console.Clear();
            decimal input = 0;

            try
            {
                Console.WriteLine("Please Enter the Amount you Wish to Deposit...");
                input = decimal.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid number...");
                Console.WriteLine(e.Message);
            }
            if (input > 0) { 
                balance = balance + input;

                Console.WriteLine("Deposit was Sucessfull! ");
                Console.WriteLine("");

                ViewBalance();
            }
            else
            {
                Console.WriteLine("Please Enter a Positive Number...");
                Console.WriteLine("");
                UserInterface();
            }
        }

        }
}
