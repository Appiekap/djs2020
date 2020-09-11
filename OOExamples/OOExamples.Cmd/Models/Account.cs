using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Models
{
    public class Account
    {  
        public int Iban { get; private set; }
        public int Balance { get; set; }

        public Account(int iban)
        {
            this.Iban = iban;
            this.Balance = 0;
        }
    }
}
