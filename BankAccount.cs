using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BankAccount
{
   
    public string BankName = "KOGUL BANK";

    public string AccountHolder;

    public int AccountNumber;

    
    private decimal Balance;

    
    List<string> Transactions = new List<string>();


    
    public BankAccount(string holder, int accNo, decimal openingBalance)
    {
        AccountHolder = holder;
        AccountNumber = accNo;
        Balance = openingBalance;
    }


    
    public void ShowWelcome()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("           KOGUL BANK            ");
        Console.WriteLine("==================================");
        Console.WriteLine("      WELCOME TO OUR BANK");
        Console.WriteLine("==================================");
    }


    
    public void ShowMenu()
    {
        Console.WriteLine("\n========== MENU ==========");
        Console.WriteLine("1. View Account");
        Console.WriteLine("2. Check Balance");
        Console.WriteLine("3. Deposit");
        Console.WriteLine("4. Withdraw");
        Console.WriteLine("5. Transactions");
        Console.WriteLine("6. Exit");
        Console.WriteLine("==========================");
    }


    
    public void ShowAccountDetails()
    {
        Console.WriteLine("\n====== ACCOUNT DETAILS ======");
        Console.WriteLine("Account Holder : " + AccountHolder);
        Console.WriteLine("Account Number : " + AccountNumber);
        Console.WriteLine("Balance         : Rs. " + Balance.ToString("0.00"));
        Console.WriteLine("=============================");
    }


    
    public void CheckBalance()
    {
        Console.WriteLine("\nCurrent Balance : Rs. " + Balance.ToString("0.00"));
    }


    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;

            Transactions.Add("Deposited Rs. " + amount);

            Console.WriteLine("Deposit Successful!");
            Console.WriteLine("Updated Balance : Rs. " + Balance.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("Invalid Deposit Amount!");
        }
    }


    
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid Withdrawal Amount!");
            return false;
        }

        if (amount <= Balance)
        {
            Balance -= amount;

            Transactions.Add("Withdrawn Rs. " + amount);

            Console.WriteLine("Withdrawal Successful!");
            Console.WriteLine("Remaining Balance : Rs. " + Balance.ToString("0.00"));

            return true;
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
            return false;
        }
    }


    
    public void ShowTransactions()
    {
        Console.WriteLine("\n====== TRANSACTION HISTORY ======");

        if (Transactions.Count == 0)
        {
            Console.WriteLine("No Transactions !");
        }
        else
        {
            foreach (string item in Transactions)
            {
                Console.WriteLine(item);
            }
        }

        Console.WriteLine("=================================");
    }
}