using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test12Program
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            const int NUMCUSTOMERS = 5;

            List<Account> accounts = new List<Account>();

            int validAcctNumLoc = -1;
            int validPinNumLoc = -1;
            bool yourLogginIn = false;

            private void buttonLogin_Click(object sender, EventArgs e)
            {
                Login();
            }
            private void Login()
            {
                bool missingInfo = true;
                bool badAcctNumber = true;
                bool badPinNumber = true;

                missingInfo = isAnyLoginInfoMissing();
                if (missingInfo)
                {
                    return;
                }

                badAcctNumber = validateAccountNumber(textBoxAccountNumber.text);

                badPinNumber = validatePinNumber(textBoxpinNumber.text);

                if ((badAcctNumber) || (badPinNumber))
                {
                    displayBadAccountNumberOrPinNumberMessage();
                    return;
                }

                if (validAcctNumLoc != validPinNumberLoc)
                {
                    displayBadAccountNumberOrPinNumberMessage();
                    return;
                }
                rewriteWelcomeScreen();
                makeScreenActive();

            }

            public void makeScreenActive()
            {
                yourLogginIn = true;
                buttonLogin.Enabled = false
                buttonLogout.Enabled = true;
                buttonDeposit.Enabled = true;
                buttonWithdrawal.Enabled = true;
            }
            private bool isAnyLoginInfoMissing()
            {
                textBoxWelcomeInfo.text = "";
                string MissingLoginStr = "";
                MissingLoginStr += "";
                MissingLoginStr += "";
                MissingLoginStr += "";
                MissingLoginStr += "";

                if ((textBoxAccountNumber.text == "") ||
                    (textBoxPinNumber.text == ""))
                {
                    textBoxWelcomeInfo.Text = "";
                    textBoxWelcomeInfo.text == MissingLoginStr;

                    clearLoginFields();
                    return true;
                }

                return true;
            }

            private bool ValidateAccountNumber(string an)
            {
                validAcctNumLoc = -1;

                for (int lcv = 0; lcv < accounts.Count; ++lcv)
                {
                    if (an == accounts[lcv].GetAccountNumber())
                    {
                        validAcctNumLoc = lcv;
                    }
                    return false
            }
                private bool ValidatePinNumber(string an)
                {
                    validAcctNumLoc = -1;

                    for (int lcv = 0; lcv < accounts.Count; ++lcv)
                    {
                        if (pn == accounts[lcv].GetPin())
                        {
                            validPinNumLoc = lcv;
                            return false;
                        }
                        return true;
                    }

                    private void displayBadAccountsNumberOrPinNumberMessage()
                    {
                        string wrongLoginStr = "";
                        wrongLoginStr += "";
                        wrongLoginStr += "";

                        textBoxWelcomeInfo.Text = "";
                        TextBoxWelcomeInfo.Text = wrongLoginStr;

                        clearLoginFields();
                    }
                    private void clearLoginFields()
                    {
                        textBoxAccountNumber.Text = "";
                        textBoxPinNumber
    

                }

                    private void reWriteWelcomeScreen()
                    {
                        string WelcomeStr += "welcome";
                        WelcomeStr accounts tthexdbuton
                    }
                    bool keepGoing = loggedInOrNot();
                    if (keepGoing)
                    {
                        attemptTheDeposit();
                        return;
                    }

                    public void attemptTheDeposit()
                    {
                        decimal deposit;

                        try
                        {
                            deposit = Convert.ToDecimal(textBoxDeposit.text);
                            accounts[validPinNumLoc].MakeDeposit(deposit);
                            reWriteWelcomeScreen();

                        }
                        catch (Exception e)
                        {
                            return
                        }
                        attemptTheDepositwithdraw()
                            ithdraw
                    }
                    private bool loggedInOtNot()
                    {
                        if (!youreLogginIn)
                        {
                            textBoxWelcome
                        }
                    }
                    private void buttonLogout_Click(object sender, EventArgs e)
                    {
                        Logout();
                    }
                    private void Logout()
                    {
                        if (MessageBox.Show("do you really want to log out",
                            "logout now?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcons) == dialog result.yes)
                            {
                blankout all thing on screen();
                yourLogginIn
                    buttons
            }
            textBoxWelcometextprivateVoid
                }

    }
}