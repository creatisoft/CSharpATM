using System.Diagnostics;

namespace CSharpATM;
using System.Timers;

class Program {
    static void Main(string[] args) {
        
        ATMSim atmSim = new ATMSim();
        
        atmSim.StartEarningInterest();
        
        int userOption = 0;
        float amountToPass = 0.0f;
        
        Console.WriteLine("***************************");
        Console.WriteLine("Welcome to C# ATM Sim!");
        Console.WriteLine("Written by: Christopher M.");
        Console.WriteLine("**************************");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1., Deposit | 2., Withdraw | 0., Check Balance");
        Console.WriteLine("**************************");
        
        while (userOption != 99) {
            
            userOption = Convert.ToInt32(Console.ReadLine());

            switch (userOption) {

                case 0:
                    atmSim.CheckBalance();
                    break;
                case 1:
                    Console.WriteLine("Input the amount you want to deposit: ");
                    amountToPass = Convert.ToInt32(Console.ReadLine());
                    atmSim.Deposit(amountToPass);
                    break;
                case 2:
                    Console.WriteLine("Input the amount you want to withdraw: ");
                    amountToPass = Convert.ToInt32(Console.ReadLine());
                    atmSim.Withdraw(amountToPass);
                    break;
                default:
                    break;
            }
            
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome to C# ATM Sim!");
            Console.WriteLine("**************************");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1., Deposit | 2., Withdraw | 0., Check Balance");
            Console.WriteLine("**************************");
            
            
        }
    }
    
}
