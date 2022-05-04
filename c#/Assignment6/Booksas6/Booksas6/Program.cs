using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksas6
{
    class Books
    {
        public string Name;
        private int Book_Id { get; set; }

        public int Book_ID
        {
            get { return Book_Id; }
            set { Book_Id = value; }
        }
        public void Display()
        {
            Console.WriteLine("Book id is:{0}", Book_Id);
            Console.WriteLine($"\nBook name is:{Name}");
        }


    }
    class Structbook
    {
        static void Main()
        {
            Books b = new Books();
            b.Book_ID = 01;
            b.Name = "Pride of indian architecture";
            b.Display();
            Console.ReadLine();
        }
    }
}