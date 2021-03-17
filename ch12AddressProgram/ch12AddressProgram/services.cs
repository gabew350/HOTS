using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch12AddressProgram
{
    class services
    {
        public decimal MINIMUMNALANCE = 25.00m;

        private readonly string _title;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _accountNumber;
        private readonly string _pin;
        private decimal _balance;

        public Account(string title,
                        string firstName,
            string lastName,
            string accountNumber,
            string pin,
            decimal balance)
        {
            _title = title;
            _firstName = firstName;
            _lastName = lastName;
            _accountNumber = accountNumber;
            _pin = pin;
            _balance = balance;
        }
        public string GetTitle()
        {
            return _title;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetAccountNumber()
        {
            return _accountNumber;
        }

        public string GetPin()
        {
            return _pin;
        }

        public string GetBalance()
        {
            return _balance;
        }

        public void MakeDeposit(decimal deposit)
        {
            decimal theDeposit = -1m;

            try
            {

                try
                {
                    theDeposit = deposit;

                    if (theDeposit <= 0)
                    {
                        MessageBox.Show("Illegal Deposit ( 0 or negative Amount) Attempted!",
                            "Illegal Deposit",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    _balance += deposit;
                }
                catch (Exception e)
                {
                    return;
                }
            }


        public void MakeWithdrawl(decimal amount)
            {
                decimal theAmount = amount;

                if (amount <= 0)
                {
                    MessageBox.Show("Illegal Withdrawl ( 0 or negative Amount) Attempted!",
                           "Illegal Withdrawl",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    return;
                }

                temp = _balance - theAmount;
                if (temp >= MINIMUMNALANCE)
                {
                    _balance -= amount;
                }

                else
                {
                    MessageBox.Show("Illegal Withdrawl ( 0 or negative Amount) Attempted!",
                          "Illegal Withdrawl",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception e)
            {

            }

        }


    }
}
    }
}
