using OOExamples.Cmd.Controllers;
using OOExamples.Cmd.Exceptions;
using System;

namespace OOExamples.Cmd.Models
{
    public class Dog
    {
        int bones = 0;

        public void Bark()
        {
            Console.WriteLine("Woof!");
            string[] vars = new string[1];
            vars[2] = "asd";
        }

        public void DoRoll()
        {
            Console.WriteLine("Roll on its back");
            throw new Exception();
        }

        public void ChewOnBone()
        {
            if (bones <= 0)
                throw new NoBonesException();
            Console.WriteLine("Chew on my bone!");
            bones--;
        }
    }
}
