using System;

namespace OOExamples.Cmd.Models
{
    public class Comic : Publication
    {
        public override void CleanPublication()
        {
            Console.WriteLine("Cleaning the comic!");
        }

        public void PutInZiplock()
        {
            Console.WriteLine("Put in bag!");
        }
    }
}
