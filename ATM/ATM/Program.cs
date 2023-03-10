using ATM;
using System;

    void printOptions()
    {
        Console.WriteLine("Please choose from one of the following options.");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
    }

    void deposit(Cardholder currentUser)
    {
        Console.WriteLine("How much money would you like to deposit? ");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.setBalance(deposit);
        Console.WriteLine("Thank you for your money. Your new balance is " + currentUser.getBalance);
    }

    void withdraw(Cardholder currentUser)
    {
        Console.WriteLine("How much money would you like to withdraw? ");
        double withdrawal = Double.Parse(Console.ReadLine());
        if (currentUser.getBalance() > withdrawal)
        {
            Console.WriteLine("Insufficent Funds.");
        }
        else
        {
            currentUser.setBalance(currentUser.getBalance() - withdrawal);
            Console.WriteLine("You're good to go! Thank you!");
        }

    }

    void balance(Cardholder currentUser)
    {
        Console.WriteLine("Current Balance is " + currentUser.getBalance());
    }


List<Cardholder> cardholders= new List<Cardholder>();
cardholders.Add(new Cardholder("1234567890123456", 1234, "Don", "Lemon", 150.31));
cardholders.Add(new Cardholder("1234567890123457", 1234, "Millie", "Vanilli", 300.42));

Console.WriteLine("Welcome to SimpleATM");
Console.WriteLine("Please insert your debit card.");
String debitCardNum = "";
Cardholder currentUser;

while(true)
{
    try
    {
        debitCardNum = Console.ReadLine();
        currentUser = cardholders.FirstOrDefault(a => a.getNum() == debitCardNum);

    }
    catch 
    {
        Console.WriteLine("Card not recognized. Try again.");
    }
}

Console.WriteLine("Please enter your pin. ");
int userPin = 0;

while (true)
{
    try
    {
        userPin = int.Parse(Console.ReadLine());
        if (currentUser.getPin() == userPin) { break; }
        else { Console.WriteLine("User PIN is not recognized. Please try again."); }

    }
    catch
    {
        Console.WriteLine("User PIN is not recognized. Try again.");
    }
}

Console.WriteLine("Welcome " + currentUser.getfirstName);
int option = 0;

do
{
    printOptions();
    try
    {
        option = int.Parse(Console.ReadLine());
    }
    catch
    {

    }
    if (option == 1) { deposit(currentUser); }
    else if (option == 2) { withdraw(currentUser); }
    else if (option == 3) { balance(currentUser); }
    else if (option == 4) { break; }
    else { option = 0; }
}
while (option != 4);
Console.WriteLine("Have a good day!!!");

