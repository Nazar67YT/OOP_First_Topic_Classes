using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_First_Topic_Classes
{
    class ATM
    {
        static void Main(string[] args)
        {
            int balance = 1000;
            int pin = 123456789;

            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("1. Show balance");
            Console.WriteLine("2. Withdraw funds");
            Console.WriteLine("3. Add funds");
            Console.WriteLine("4. Change PIN");
            Console.WriteLine("5. Help");
            Console.WriteLine("Select one of the options");


            int Choice = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (Choice == 1)
                {
                    Console.WriteLine("Enter PIN to show balance");

                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Your Balance: $" + balance);
                    }

                }

                if (Choice == 2)
                {
                    Console.WriteLine("Enter PIN to Withdraw punts");

                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Your Balance: $" + balance);
                        Console.WriteLine("Enter amount to withdraw");

                        int Amount = Convert.ToInt32(Console.ReadLine());

                        if (Amount <= balance)
                        {
                            Console.WriteLine("Removed: $" + balance);
                            balance -= Amount;
                        }
                        else
                        {
                            Console.WriteLine("ERROR! Cant removed more for your balance");
                        }
                    }
                }
                if (Choice == 3)
                {
                    Console.WriteLine("Enter PIN to add funds");

                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Your Balance: $" + balance);
                        Console.WriteLine("Enter amount to add:");

                        int AmountToAdd = Convert.ToInt32(Console.ReadLine());

                        balance += AmountToAdd;
                        Console.WriteLine("Your balance: $" + balance);

                    }

                }
                if (Choice == 4)
                {
                    Console.WriteLine("Enter PIN to contine");

                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Enter new PIN:");

                        int NewPin = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Changed PIN from:" + pin + NewPin);
                        pin = NewPin;

                    }

                    if (Choice == 5)
                    {
                        Console.WriteLine("Welcome to the ATM\\r\n\"1. Show balance\\r\n2. Withdraw funds\\r\n3. Add funds\r\n4. Change PIN\\r\n 5. Help\\r\n Select one of the options...");

                    }



                }

            }
        }
    }
}
