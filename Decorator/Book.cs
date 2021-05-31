using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Book : Goods
    {
        private string _author;
        private string _nameBook;

        public Book(string author, string nameBook, int amout)
        {
            _author = author;
            _nameBook = nameBook;
            _amout = amout;
        }
        public override void Output()
        {
            Console.WriteLine("Author: " + _author);
            Console.WriteLine("BookName: " + _nameBook);
            Console.WriteLine("Amout: " + _amout);
        }
    }
}
