 using System ;
   namespace Project
   {

  public class BankAccount{

private string accountHolder;
private decimal balance;


public string AccountHolder{
    get {return accountHolder;}
    set {accountHolder=value;}
}


  public decimal Balance
        {
            get { return balance; }
            set {balance=value;}

        }

  
  public BankAccount(string holder, decimal initialBalance){
     AccountHolder = holder;
     Balance = initialBalance;
     Console.WriteLine($"Account created for {AccountHolder} with initial balance {Balance:C}");
  }


   

   public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
            }
        }

        // Public method to withdraw money
        public void Withdraw(decimal amount) 
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. Remaining balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }

        ~BankAccount()
        {
            Console.WriteLine($"Account for {AccountHolder} is being closed.");
        }
  }


    class Program
    {
        static void Main (string[]args)
        {
            
            BankAccount myAccount = new BankAccount("Kavya", 5000000);
            myAccount.Deposit(100000);
            myAccount.Withdraw(50000);




        }
    }
   }