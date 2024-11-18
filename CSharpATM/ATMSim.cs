namespace CSharpATM;
using System.Timers;
public class ATMSim {
    
    public static float amountInSavings = 0;
    public static float startingAmount = 1000;
    
    Timer interestTimer = new Timer();

    public void StartEarningInterest() {
        
        interestTimer.Interval = 1 * (1000);
        interestTimer.Elapsed += OnTimedEvent;
        interestTimer.Enabled = true;
        
    }

    private void OnTimedEvent(Object source, ElapsedEventArgs e) {
        
        //Console.WriteLine("**Interest should have updated**");
        
        if (amountInSavings > 0) {
            
            amountInSavings = amountInSavings + (amountInSavings * 0.04f);
            
        } 

    }
    public void CheckBalance() {
        
        Console.WriteLine("Your balance is: " + amountInSavings);
    }

    public void Deposit(float amount) {
        
        amountInSavings += amount;
        startingAmount -= amount;
    }

    public void Withdraw(float amount) {
        
        amountInSavings -= amount;
        amount += startingAmount;

    }
    
}