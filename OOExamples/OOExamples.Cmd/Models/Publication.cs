using System;

namespace OOExamples.Cmd.Models
{
    public abstract class Publication
    {
        protected string title;
        private string text;

        public virtual void Publish()
        {
            Console.WriteLine("It has been published!");
        }

        public virtual void DoSomething()
        {
            Console.WriteLine("Do Something!");
        }

        public abstract void CleanPublication();
    }
}
