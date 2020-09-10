using System;

namespace OOExamples.Cmd.Models
{
    public class Book : Publication
    {
        public void ReadBook()
        {
            this.title = "";
            Console.WriteLine("Reading the book!");
        }

        public override sealed void Publish()
        {
            Console.WriteLine("Publishing a book actually!");
        }
    }
}
