﻿using OOExamples.Cmd.Controllers;
using OOExamples.Cmd.Data;
using OOExamples.Cmd.Events;
using OOExamples.Cmd.Exceptions;
using OOExamples.Cmd.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

            var test = new Test();
            test.Description = "Something!";
            Console.WriteLine(test.Description);

            // Polymorphism.

            Publication bookTwo = new Book();
            //bookTwo.ReadBook(); // method from book
            if(bookTwo is Book)
            {
                ((Book)bookTwo).ReadBook();
            }

            bookTwo.Publish(); // method from publication
            bookTwo.ToString(); // method from object

            IList<Publication> publications = new List<Publication>();
            publications.Add(new Book());
            publications.Add(new Book());
            publications.Add(new Paper());
            publications.Add(new Paper());
            publications.Add(new Comic());
            publications.Add(new Comic());

            foreach (var currentPublication in publications)
            {
                currentPublication.CleanPublication();
                if (currentPublication is Comic)
                {
                    ((Comic)currentPublication).PutInZiplock();
                }
            }

            // Abstraction.
            IDataConnection connection;
            bool isTest = true;

            if(isTest)
            {
                connection = new DummyFileConnection();
            }    
            else
            {
                connection = new DatabaseConnection();
            }            

            // code code code
            connection.GetData();
            // code code code
            connection.PushData();

            //var publication = new Publication(); not possible cause abstract.

            // Other topics.
            // DateTime.

            var date = DateTime.Now;
            Console.WriteLine(date);

            // Stringbuilder / String.Format

            string wat = "fdsgdfg";
            wat = "sddsfdaaf";
            wat = wat + "1df";

            var builder = new StringBuilder("Hello World!", 25);
            builder.Append("wat");

            var niceString = string.Format("There is a {0} at {1}", "Dog", "The Farm");
            Console.WriteLine(niceString);

            // Structs

            var coords = new Coordinate(10,20);
            Console.WriteLine(coords);

            // User input.

            //Console.Write("Select Country (USA or BEL): ");
            //string country = Console.ReadLine();

            // Dictionary.

            var dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(5, "Five");

            foreach(var kvp in dictionary)
            {
                Console.WriteLine(string.Format("For key: {0} there is the value: {1}", kvp.Key, kvp.Value));
            }

            string country = "USA"; // user input

            var countries = new Dictionary<string, string>();
            countries.Add("USA", "Star Spangled Banner");
            countries.Add("BEL", "Yellow-Red-Black");

            Console.WriteLine(countries[country]);

            // Exceptions
            
            var kennel = new Kennel();
            var success = kennel.WalkBy();
            if (!success)
                Console.WriteLine("Could not walk by the kennel!");

            var dog = new Dog();
            try
            {
                dog.DoRoll();
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Roll Exception!");
            }

            // var connection = new DBConnection();
            try
            {
                dog.ChewOnBone();
                dog.ChewOnBone();
                // connection.Connect();
                // var result = connection.Execute("SELECT * FROM");
            }
            catch(NoBonesException ex)
            {
                Console.WriteLine("The dog is out of bones...");
            }
            finally
            {
                // connection.Close();
                Console.WriteLine("This happens regardless of exc or not");
            }

            // Events

            var counter = new Counter();
            counter.GoalReached += CounterGoalReached;
            counter.GoalReached += CounterGoalReachedAgain;
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("Adding one to the counter");
                counter.Add(1);
            }

            // Types of .Net Core Projects.
            // .NET Core Console
            // ASP.NET Core
                // MVC (actually uses razor for the frontend) <-- Focus
                // Razorpages (razor html - class)
                // Blazor
                // ASP.NET API
                // ASP.NET API - Angular Frontend / React Frontend
            // Xamarin (Mobile)
            // Windows Clients Apps (Windows Forms, WPF, UWP, GTK)
            // IoT / Machine Learning (GPIO, ML.NET)

        }

        private static void CounterGoalReachedAgain(object sender, CounterEvent e)
        {
            Console.WriteLine(e.Message);
        }

        private static void CounterGoalReached(object sender, CounterEvent e)
        {
            Console.WriteLine("Counter reached its goal!");
        }
    }
}