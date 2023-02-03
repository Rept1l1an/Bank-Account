string pin = "1234";
string UserInput;
string operation;
bool Pin = true;
bool Account = false;
int Hit = 0;
int Attempt = 0;
int Balance = 1000;
Console.WriteLine("Please enter your PIN: ");
while (Pin)
{
    UserInput = Console.ReadLine();
    if (UserInput == pin)
    {
        Hit++;
        Attempt = 0;
    }
    else
    {
        Hit = 0;
        Attempt++;
        Console.Clear();
        Console.WriteLine("Your pin is wrong");
    }
    if (Hit == 2)
    {
        Pin = false;
        Account = true;
        Console.Clear();
        Console.WriteLine("Wellcome");
    }
    if (Attempt == 5)
    {
        Console.Clear();
        Console.WriteLine("Too many attempts. Your account is locked.");
        Pin = false;
    }

}
while (Account == true)
{
    Console.WriteLine("Please choose an operation");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Withdraw funds");
    Console.WriteLine("3. Deposit funds");
    Console.WriteLine("4. Exit");
    operation = Console.ReadLine();
    switch (operation)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("your bank balance $ " + Balance);
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Enter the amount to withdraw: ");
            int Withdraw = Convert.ToInt32(Console.ReadLine());
            if (Withdraw > Balance)
            {
                Console.WriteLine("Balance is Insufficient.");
            }
            else
            {
                Balance -= Withdraw;
                Console.WriteLine("Withdrawal successful. Your new balance is $" + Balance);
            }
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Enter the amount to deposit: ");
            int Deposit = Convert.ToInt32(Console.ReadLine());
            Balance += Deposit;
            Console.WriteLine("Deposit successful. Your new balance is $" + Balance);
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Thank you for using our system. Have a great day!");
            Account = false;
            break;
    }
}