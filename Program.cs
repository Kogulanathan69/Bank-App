namespace Kogul_Bank
{
    using System;

    class Program
    {
        static void Main()
        {

            Console.WriteLine("==================================");
            Console.WriteLine("           KOGUL BANK            " );
            Console.WriteLine("==================================");
            Console.WriteLine("      WELCOME TO OUR BANK"         );
            Console.WriteLine("=================================="); 

            
            Console.Write("Enter Account Holder Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Opening Balance : ");
            decimal openingBalance = Convert.ToDecimal(Console.ReadLine());

           
            Random random = new Random();
            int accNo = random.Next(100000, 999999);

            
            BankAccount account = new BankAccount(name, accNo, openingBalance);

            bool running = true;

            
            while (running)
            {
                Console.Clear();

                account.ShowWelcome();

                account.ShowMenu();

                Console.Write("\nChoose Option : ");
                int choice =
                    Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (choice)
                {
                   
                    case 1:

                        account.ShowAccountDetails();

                        break;


                    
                    case 2:

                        account.CheckBalance();

                        break;


                    
                    case 3:

                        Console.Write("Enter Deposit Amount : ");

                        decimal depositAmount =
                            Convert.ToDecimal(Console.ReadLine());

                        account.Deposit(depositAmount);

                        break;


                    
                    case 4:

                        Console.Write("Enter Withdrawal Amount : ");

                        decimal withdrawAmount =
                            Convert.ToDecimal(Console.ReadLine());

                        account.Withdraw(withdrawAmount);

                        break;


                    case 5:

                        account.ShowTransactions();

                        break;


                    
                    case 6:

                        Console.WriteLine("THANK YOU FOR USEING KOGUL BANK ");

                        running = false;

                        break;


                    
                    default:

                        Console.WriteLine("Invalid Choice!");

                        break;
                }

                
                if (running)
                {
                    Console.WriteLine("\nPress Any Key To Continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
