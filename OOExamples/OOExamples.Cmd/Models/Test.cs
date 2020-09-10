using System;
using System.Collections.Generic;
using System.Text;

namespace OOExamples.Cmd.Models
{
    class Test
    {
        private string description;

        public string Description
        { 
            get
            {
                return description;
            }
            set
            {
                if (value == null)
                    description = "There is no value";
                else
                    description = value;
            }
        }

        public int PublishedYear { get; private set; }


        public void Lalala()
        {
            var book = new Book();
        }
    }
}
