using OOExamples.Cmd.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Models
{
    public class Person
    {
        private readonly DateTime birthDate;

        public Person()
        {
            birthDate = DateTime.Now;
        }

        public void CelebrateBday()
        {
            Console.WriteLine("Jaj, it's my birthday!");
            //birthDate = DateTime.Now; // cannot do because readonly
        }
    }
}
