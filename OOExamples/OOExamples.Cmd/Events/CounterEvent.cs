using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Events
{
    public class CounterEvent : EventArgs
    {
        public string Message { get; set; }
    }
}
