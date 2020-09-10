using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Data
{
    public interface IDataConnection
    {
        void GetData();
        void PushData();
    }
}
