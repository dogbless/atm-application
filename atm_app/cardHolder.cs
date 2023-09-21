namespace atm_app
{
    public class cardHolder
    {
        string cardNum;
        int pin;
        string firstName;
        string Lastname;
        double balance;

        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.Lastname = lastName;
            this.balance = balance;
             
            
        }

        public string getNum()
        {
            return cardNum;
        }
        public int getPin()
        {
            return pin;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return Lastname;
        }

        public double getbalance()
        {
            return balance;
        }

        public void setNum(string newCardNum)
        {
            cardNum = newCardNum;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;

        }
        public void setLastName(string newLastName)
        {
            Lastname = newLastName;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

    }
}
