using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_First_Topic_Classes
{
    class ATM
    {
        static Dictionary<string, Dictionary<string, string>> messages = new Dictionary<string, Dictionary<string, string>>()
    {

        {"ukrainian", new Dictionary<string, string>()
        {
            {"welcome","Ласкаво просимо в банкомат"},
            {"show_balance", "1. Показати баланс" },
            {"withdraw_funds", "2. Зняти гроші " },
            {"add_funds", "3. Покласти гроші" }, 
            {"Change_pin","4. Поміняти пін-код" },
            {"Change_laguage","5. Змінити мову" },
            {"Exit","6. Вийти"},
            {"Select_options", "Виберіть один з варіантів..." },
            {"Enter_pin", "Ведіть пін-код для перегляду балансу" },
            {"your_bal","Ваш баланс: $" },
            {"enter_withd","Ведіть суму для зняття" },
            {"removed", "Знято: $"},
            {"error_remove", "ПОМИЛКА! Неможливо зняти більше, ніж на вашому балансі"},
            {"add_funds_pin", "Введіть PIN для додавання коштів"},
            {"add_amount", "Введіть суму для додавання:"},
            {"balance_updated", "Ваш баланс: $"},
            {"Enter_to_contine","Ведіть пін-код щоб продовжити" },
            {"new_pin","Ведіть новий пін-код"},
            {"pin_changed", "PIN-код змінено з:"},
            {"invalid_choice", "Ви можете обрати 1-6"},
            {"change_language","Змінити мову" },
            {"loading","Загрузка" },
            {"Fatal","Критична помилка" }
            
        }
        },
        {"english", new Dictionary<string, string>(){

            {"welcome", "Welcome to the ATM"},
            {"show_balance", "1. Show balance" },
            {"withdraw_funds", "2. Withdraw funds" },
            {"add_funds", "3. Add funds" },
            {"Change_pin","4. Change PIN" },
            {"Change_laguage","5. Change language" },
            {"Exit","6. Exit"},
            {"Select_options", "Select one of the options..." },
            {"Enter_pin", "Enter PIN to show balance" },
            {"your_bal","Your Balance: $" },
            {"enter_with","Enter PIN to Withdraw punts" },
            {"removed", "Removed: $"},
            {"enter_withd", "Enter amount to withdaw" },
            {"error_remove", "ERROR! Cant removed more for your balance"},
            {"add_funds_pin", "Enter PIN to add funds"},
            {"add_amount", "Enter amount to add:"},
            {"balance_updated", "Your Balance: $"},
            {"Enter_to_contine","Enter PIN to contine" },
            {"new_pin","Enter new PIN:" },
            {"pin_changed", "Changed PIN from:"},
            {"invalid_choice", "You can choice 1-6"},
            {"change_language","Change language" },
            {"loading","Loading..." },
            {"Fatal","Fatal ERROR" }



        } }




        
    };








        static void ShowMenu(string lenguage)
        {
            
            Console.WriteLine(messages[lenguage]["welcome"]);
            Console.WriteLine(messages[lenguage]["show_balance"]);
            Console.WriteLine(messages[lenguage]["withdraw_funds"]);
            Console.WriteLine(messages[lenguage]["add_funds"]);
            Console.WriteLine(messages[lenguage]["Change_pin"]);
            Console.WriteLine(messages[lenguage]["Change_laguage"]);
            Console.WriteLine(messages[lenguage]["Exit"]);
            Console.WriteLine(messages[lenguage]["Select_options"]);
           
        }

        static int UserInput() {
            int user = Convert.ToInt32(Console.ReadLine());
            return user;
        }







        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
             User user1 = new User();
            string lenguage = "ukrainian";
            try {
                while (true)
                {

                    ShowMenu(lenguage);
                    int Choice = UserInput();
                    if (Choice == 1)
                    {
                        Console.WriteLine(messages[lenguage]["Enter_pin"]);

                        int PinInput = UserInput();

                        if (PinInput == user1.setpin)
                        {
                            Console.WriteLine(messages[lenguage]["your_bal"] + user1.setbalance);
                        }

                    }

                    else if (Choice == 2)
                    {
                        Console.WriteLine(messages[lenguage]["enter_with"]);

                        int PinInput = UserInput();

                        if (PinInput == user1.setpin)
                        {
                            Console.WriteLine(messages[lenguage]["your_bal"] + user1.setbalance);
                            Console.WriteLine(messages[lenguage]["enter_withd"]);

                            int Amount = UserInput();

                            if (Amount <= user1.setbalance)
                            {
                                Console.WriteLine(messages[lenguage]["your_bal"] + user1.setbalance);
                                user1.setbalance -= Amount;
                            }
                            else
                            {
                                Console.WriteLine(messages[lenguage]["error_remove"]);
                            }
                        }
                    }
                    else if (Choice == 3)
                    {
                        Console.WriteLine(messages[lenguage]["add_funds_pin"]);

                        int PinInput = UserInput();

                        if (PinInput == user1.setpin)
                        {
                            Console.WriteLine(messages[lenguage]["balance_updated"] + user1.setbalance);
                            Console.WriteLine(messages[lenguage]["add_amount"]);

                            int AmountToAdd = UserInput();

                            user1.setbalance += AmountToAdd;
                            Console.WriteLine(messages[lenguage]["balance_updated"] + user1.setbalance);

                        }

                    }
                    else if (Choice == 4)
                    {
                        Console.WriteLine(messages[lenguage]["Enter_to_contine"]);

                        int PinInput = UserInput();

                        if (PinInput == user1.setpin)
                        {
                            Console.WriteLine(messages[lenguage]["new_pin"]);

                            int NewPin = UserInput();

                            Console.WriteLine(messages[lenguage]["pin_changed"] + user1.setpin + NewPin);
                            user1.setpin = NewPin;

                        }
                    }
                    else if (Choice == 5)
                    {
                        Console.WriteLine("Enter 1 - to Ukr \n Enter 2 - to Eng");
                        int userChoiceLenguage = Convert.ToInt32(Console.ReadLine());
                        if (userChoiceLenguage == 1)
                        {
                            lenguage = "ukrainian";
                        }
                        else if (userChoiceLenguage == 2)
                        {
                            lenguage = "english";
                        }
                        else
                        {

                            Console.WriteLine("TRY AGAIN");
                        }

                    }

                    else if (Choice == 6)
                    {
                        Console.Write("\t\t\t\t\t\t" + messages[lenguage]["loading"]);
                        for (int i = 0; i < 5; i++) {
                            Console.Write(".");
                            Thread.Sleep(500);
                        }
                        Thread.Sleep(2000);
                        break;
                    }
                    else if (Choice < 1 || Choice > 6)
                    {
                        Console.WriteLine(messages[lenguage]["invalid_choice"]);
                    }

                }

            }
            catch (Exception) { Console.WriteLine("\t\t\t\t"+messages[lenguage]["loading"]); Thread.Sleep(3000);
                Console.WriteLine("\t\t\t"+messages[lenguage]["Fatal"]); }
        }
    }
}
