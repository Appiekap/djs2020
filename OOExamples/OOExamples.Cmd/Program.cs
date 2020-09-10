using OOExamples.Cmd.Models;
using System;

namespace OOExamples.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to OO");

            // Four pillars of OO:
            // Inheritance.

            var book = new Book();
            var paper = new Paper();
            book.Publish();
            book.ReadBook();
            paper.Publish();


            // Encapsulation.
            // Polymorphism.
            // Abstraction.


        }
    }
}