using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class EBook: Book
    {
        public double FileSize { get; set; }

        public EBook (double fileSize, string title, string author, string isbn) : base(title, author, isbn)
        {
            FileSize = fileSize;
        }   
    }
}
