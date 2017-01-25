using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Repository : IRepository<ICollection<Book>,Book>
    {
        ICollection<Book> temp = new List<Book>();

        public Repository()
        {
            
            temp.Add(new Book() { bookTitle = "3 little pigs", bookAuthor = "Piggy", bookPrice = 11, bookLanguage = "English" });
            temp.Add(new Book() { bookTitle = "Cinderella", bookAuthor = "cindy", bookPrice = 13, bookLanguage = "English" });
            temp.Add(new Book() { bookTitle = "Sangou", bookAuthor = "wong", bookPrice = 18, bookLanguage = "Chinese" });
            temp.Add(new Book() { bookTitle = "Red riding hood", bookAuthor = "rae", bookPrice = 15, bookLanguage = "English" });
            temp.Add(new Book() { bookTitle = "Yeng yi", bookAuthor = "wong", bookPrice = 18, bookLanguage = "Chinese" });
        }

        public ICollection<Book> getBooks()
        {     
            return temp;
        }

        public void addBook(Book b)
        {
            temp.ToList().Add(b);
        }
    }
}
