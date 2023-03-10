using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Cardholder
    {
        String cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public Cardholder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getNum()
        { return cardNum; }

        public int getPin() { return pin; }

        public string getfirstName()
        { return firstName; }

        public string getLastName() { return lastName; }

        public double getBalance() { return balance; }

        public void setNum(string newCardNum)
        {
            cardNum = newCardNum;
        }

        public void setPin(int newpin)
        {
            pin = newpin;
        }

        public void setFirstName(string newfirstName) { firstName = newfirstName; }

        public void setLastName(string newlastName) { lastName = newlastName; }

        public void setBalance(double newbalance) { balance = newbalance; }


    }
}
