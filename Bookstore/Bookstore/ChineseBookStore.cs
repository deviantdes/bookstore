using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class ChineseBookStore : BookStore
    {
        public ChineseBookStore(IRepository<ICollection<Book>,Book> r)
        {
            this.repos = r;
        }

        public override ICollection<Book> getBooks()
        {
            var books = repos.getBooks();
            return books.Where(x => x.bookLanguage.ToLower() == "chinese").ToList();
        }
    }
}
