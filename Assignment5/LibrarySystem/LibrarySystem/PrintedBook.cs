// Written by Swornashabi
// 2/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class PrintedBook : Book
    {

        //additional property
        private int pageCount = 0;

        //gets and sets
        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount = value; }
        }

        //constructor
        public PrintedBook(string aTitle, string aAuthor, int theYearPublished, int thePageCount): base(aTitle, aAuthor, theYearPublished)
        {
            this.PageCount = thePageCount;
        }

        // overriding ToString()
        public override string ToString()
        {
            return $"{this.Title} by {this.Author}({this.YearPublished}), Page Count: {this.PageCount}";
        }
    }
}
