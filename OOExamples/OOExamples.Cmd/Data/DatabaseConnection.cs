using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Data
{
    public class DatabaseConnection : IDataConnection
    {
        public void GetData()
        {
            Console.WriteLine("Getting data from the database");
        }

        public void PushData()
        {
            Console.WriteLine("Pushing data to the database");
        }
    }
}
