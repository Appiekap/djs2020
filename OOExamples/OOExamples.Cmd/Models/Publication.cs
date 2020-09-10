using System;

namespace OOExamples.Cmd.Models
{
    public class Publication
    {
        protected string title;
        string text;

        public virtual void Publish()
        {
            Console.WriteLine("It has been published!");
        }

        public virtual void DoSomething()
        {
            Console.WriteLine("Do Something!");
        }
    }
}
