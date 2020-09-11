using OOExamples.Cmd.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Controllers
{
    public class AccountController
    {
        public bool TransferToAccount(Account from, Account to, int amount)
        {
            if(from.Balance >= amount) // There is enough in the account.
            {
                from.Balance -= amount;
                to.Balance += amount;
                return true;
            }
            return false;            
        }
    }
}
