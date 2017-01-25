using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<ICollection<Book>, Book> r = new Repository();

            BookStore a = new EnglishBookStore(r);
            BookStore b = new ChineseBookStore(r);

            foreach (var x in a.getBooks())
            {
                Console.WriteLine(x.bookTitle + "_" + x.bookAuthor + "_" + x.bookPrice + "_" + x.bookLanguage);
            }
            
            Console.WriteLine("\n\n");
            
            foreach (var z in b.getBooks())
            {
                Console.WriteLine(z.bookTitle + "_" + z.bookAuthor + "_" + z.bookPrice + "_" + z.bookLanguage);
            }

            Console.Read();
        }
    }
}
