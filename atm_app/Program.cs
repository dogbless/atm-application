using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_app
{

    internal class Program
    {
        static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose from one of the following options.......");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
            }

            void Deposit(cardHolder currentuser)
            {
                Console.WriteLine("how much $$ do you want to deposit");
                double deposit = Double.Parse(Console.ReadLine());
                currentuser.setBalance(currentuser.getbalance()+deposit);
                Console.WriteLine("Thank you for your $$. Your new balance is: "+ currentuser.getbalance());
            }

            void withdraw(cardHolder currentuser)
            {
                Console.WriteLine("How much $$ would you like to withdraw: ");
                double withdrawal = Double.Parse(Console.ReadLine());
                if (currentuser.getbalance() < withdrawal)
                {
                    Console.WriteLine("insufficient balance :( ");



                }
                else
                {
                    
                    currentuser.setBalance(currentuser.getbalance() - withdrawal);
                    Console.WriteLine(" you are good to go thank you!");
                }





            }  
            void balance(cardHolder currentuser)
            {
                Console.WriteLine("current balance: " + currentuser.getbalance());
            }

            List<cardHolder> cardholders = new List<cardHolder>();
            cardholders.Add(new cardHolder("12311212313123", 1234, "john", "johnsons", 150.43));
            cardholders.Add(new cardHolder("1231121222323", 3334, "sue", "phillips", 1500.43));
            cardholders.Add(new cardHolder("12311213232233", 1235, "jeff", "segal", 1444.43));
            cardholders.Add(new cardHolder("1232323098313123", 1834, "jason", "sulek", 20000.43));
            cardholders.Add(new cardHolder("123112139483123", 1288, "ryan", "tate", 15.43));
            cardholders.Add(new cardHolder("12311212328933123", 1674, "amber", "Herman", 150.43));

            Console.WriteLine("welcome to the ATM");
            Console.WriteLine("Please insert your debit card: ");
            string debitCardNum = "";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    currentUser = cardholders.FirstOrDefault(a => a.getNum()== debitCardNum);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("card not recgnized try again"); }
                }
                catch { Console.WriteLine("card not recognized pls try again"); }
                
            }

            Console.WriteLine("please enter your pin: ");
            int userPin = 0;

            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                
                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("pin not recgnized try again"); }
                }
                catch { Console.WriteLine("pin not recognized pls try again"); }

            }


            Console.WriteLine("welcome " + currentUser.getFirstName()+ " :)");
            int option = 0;

            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if(option == 1) { Deposit(currentUser); }
                else if(option == 2) { withdraw(currentUser); }
                else if(option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else
                {
                    option = 0;
                }




            }
            while (option != 4);
            Console.WriteLine("thank you have a nice day ");







        }
    }
}
