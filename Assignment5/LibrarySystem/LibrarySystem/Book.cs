//Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        //class variables
        private string title = "n/a";
        private string author = "n/a";
        private int yearPublished = -1;

        // gets and sets
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        //constructor
        public Book(string aTitle, string aAuthor, int theYearPublished)
        {
            this.Title = aTitle;
            this.Author = aAuthor;
            this.YearPublished = theYearPublished;
        }

        // overriding ToString()
        public override string ToString()
        {
            return $"{this.Title} by {this.Author}({this.YearPublished})";
        }
    }
}
