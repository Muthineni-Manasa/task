using System;

 class Gpay // intence class
{
    string password;
    double money;
    double transferAmount;
    int pin;
    int oldPin;
    int newPin;
    string accountNumber;

     string Password // intence property
    {
        get 
        { 
            return password; 
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                 Console.WriteLine("Password cannot be empty");
            }
            password = value;
        }
    }

     double Money // prpperty
    {
        get 
        { 
            return money; 
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Money cannot be negative");
            }
            money = value;
        }
    }

     double TransferAmount
    {
        get 
        { 
            return transferAmount; 
        }
        set
        {
            if (value < 0)
            {
                 Console.WriteLine("Transfer amount cannot be negative");
            }
            transferAmount = value;
        }
    }

     int Pin
    {
        get 
        { 
            return pin; 
        }
        set
        {
            if (value < 0 || value > 9999)
            {
                Console.WriteLine("Pin must be a 4-digit number");
            }
            pin = value;
        }
    }

     int OldPin
    {
        get 
        { 
            return oldPin; 
        }
        set
        {
            if (value < 0 || value > 9999)
            {
                 Console.WriteLine("Old pin must be a 4-digit number");
            }
            oldPin = value;
        }
    }

     int NewPin
    {
        get 
        { 
            return newPin; 
        }
        set
        {
            if (value < 0 || value > 9999)
            {
               Console.WriteLine("New pin must be a 4-digit number");
            }
            newPin = value;
        }
    }
     double CurrentBalance { get; set; }

     string AccountNumber
    {
        get { return accountNumber; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length != 16)
            {
                Console.WriteLine("Account number must be a 16-digit number");
            }
            
            accountNumber = value;
        }
    }

    internal void Accept() // method 1
    {
        Console.Write("Enter the account number: ");
      this.AccountNumber = Console.ReadLine();
        Console.Write("Enter the Gpay password: ");
      this. Password = Console.ReadLine();
        Console.Write("Total amount in gpay: ");
       this. Money = double.Parse(Console.ReadLine());
    }

    internal void TransferMoney() // method 2
    {
        Console.Write("Enter the amount to transfer: ");
       this .TransferAmount = double.Parse(Console.ReadLine());
        Console.Write("Enter the pin number: ");
      this.  Pin = int.Parse(Console.ReadLine());
        if (TransferAmount <= Money)
        {
            Console.WriteLine("Money transferred successfully!");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

    internal void CheckBalance() // method 3
    {
       this. CurrentBalance = Money - TransferAmount;
        Console.WriteLine("Current balance: " +this. CurrentBalance);
    }

    internal void ChangePin() // method 4
    {
        Console.Write("Enter the old pin: ");
      this.  OldPin = int.Parse(Console.ReadLine());
        if (OldPin == Pin)
        {
            Console.Write("Enter the new pin: ");
           this. NewPin = int.Parse(Console.ReadLine());
           this. Pin = NewPin;
            Console.WriteLine("Pin changed successfully!");
        }
        else
        {
            Console.WriteLine("Invalid old pin!");
        }
    }

    internal void Display() // method 5
    {
        Console.WriteLine("Object reference: " +this .GetHashCode());
        Console.WriteLine("Gpay password: " +this. Password);
        Console.WriteLine("Account Number: " +this. AccountNumber);
        Console.WriteLine("Money: " + this. Money);
        Console.WriteLine("Transfer Amount: " + this.TransferAmount);
        Console.WriteLine("Pin number: " +this. Pin);
        Console.WriteLine("Current Balance: " +this. CurrentBalance);
        Console.WriteLine("Old Pin number: " +this. OldPin);
        Console.WriteLine("New Pin number: " +this. NewPin);
    }
}

internal class google     // main class                                                                                                                       
{
    static void Main(string[] args) // main method
    {
        Gpay g = new Gpay();
        Console.WriteLine("Reference of g: " + g.GetHashCode());
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Accept");
            Console.WriteLine("2. Transfer Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Change Pin");
            Console.WriteLine("5. Display");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    g.Accept();
                    break;
                case 2:
                    g.TransferMoney();
                    break;
                 case 3:
                    g.CheckBalance();
                    break;
                case 4:
                    g.ChangePin();
                    break;
                case 5:
                    g.Display();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
 