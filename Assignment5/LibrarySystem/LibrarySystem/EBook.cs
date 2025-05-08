using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class EBook: Book
    {
        //additional property
        private int fileSizeMB = 0;

        //bets and sets
        public int FileSizeMB
        {
            get { return this.fileSizeMB; }
            set { this.fileSizeMB = value; }
        }

        //constructor
        public EBook(string aTitle, string aAuthor, int theYearPublished, int aFileSizeMB):base(aTitle, aAuthor, theYearPublished)
        {
            this.FileSizeMB = aFileSizeMB;
        }

        //overriding ToString()
        public override string ToString()
        {
            return $"{this.Title} by {this.Author}({this.YearPublished}), File Size: {this.FileSizeMB}";
        }
    }
}
