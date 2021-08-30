using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string pin = "1234";
            BankAccount myAccount = new BankAccount();
            WelcomeScreen();

              void WelcomeScreen()
            {
                Console.WriteLine("BANK OF ALABAMA."); 
                Console.WriteLine("Enter pin: ");
                string enteredPin =Console.ReadLine();
                if (enteredPin == pin)

                {
                    Console.WriteLine("Do you want to enter money in account? Enter: YES or NO");
                    var answer = Console.ReadLine();
                    switch (answer.ToLower())
                    {
                        case "yes":
                        case "y":

                            Console.WriteLine("Enter in amount you would like to deposit");
                            var amount = Convert.ToDouble(Console.ReadLine());
                            myAccount.Deposit(amount);
                            break;

                        case "no":
                        case "n":
                            Console.WriteLine("Your total balance is: ");
                            Console.WriteLine(myAccount.GetBalance());
                            break;

                        default:
                            Console.WriteLine("You have exited application");
                            break;
                    }
                }
                else if (pin != enteredPin)
                {
                    Console.WriteLine("Incorrect Pin Number. Try again");
                    WelcomeScreen();
                }
                    
                else
                    Console.WriteLine("You have exited program");

            }
             
        }
    }
}
