using System;

namespace OOExamples.Cmd.Models
{
    public class Comic : Publication
    {
        public readonly string isbn = "sdf";

        public Comic()
        {
            isbn = "sdf";
        }

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
