using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /*
     
       Code Reusability: The Book class contains common properties (Title, Author, ISBN), reducing redundancy.
       Extensibility: New types of books  can be added with minimal changes.
       Encapsulation: Each class encapsulates its specific attributes while sharing common ones.
     */
    internal class Book
    {

        #region Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        #endregion

        #region Constructor
        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }
        #endregion



    }
}
