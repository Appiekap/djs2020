using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Data
{
    public class DummyFileConnection : IDataConnection
    {
        public void GetData()
        {
            Console.WriteLine("Getting data from the file");
        }

        public void PushData()
        {
            Console.WriteLine("Pushing data to the file");
        }
    }
}
