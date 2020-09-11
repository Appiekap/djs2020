using OOExamples.Cmd.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Controllers
{
    public class Kennel
    {
        Dog dog;

        public Kennel()
        {
            dog = new Dog();
        }

        public bool WalkBy() 
        {
            try
            {
                dog.Bark();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught");
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }
    }
}
