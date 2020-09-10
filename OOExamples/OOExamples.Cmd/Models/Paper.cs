using System;

namespace OOExamples.Cmd.Models
{
    public class Paper : Publication
    {
        public override void CleanPublication()
        {
            Console.WriteLine("Cleaning the paper!");
        }

        // Hides publication method.
        public new void Publish()
        {

        }


    }
}
