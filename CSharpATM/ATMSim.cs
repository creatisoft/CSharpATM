namespace CSharpATM;

public class ATMSim {
    
    public static float startingAmount = 100;
    
    public static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e) {
        
        
        Console.WriteLine("It should have updated");

    }
    public void CheckBalance() {
        
        Console.WriteLine("Your balance is: " + startingAmount);
        
    }

    public void Deposit(float amount) {
        
        startingAmount = startingAmount + amount;
        
    }

    public void Withdraw(float amount) {

        if (amount > startingAmount) {
            
            Console.WriteLine("Please Try Again...");
            
        } else {
            
            startingAmount = startingAmount - amount;

        }
        
    }
    
}