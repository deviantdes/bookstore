using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public abstract class BookStore
    {
        protected IRepository<ICollection<Book>, Book> repos;

        public abstract ICollection<Book> getBooks();
    }
}
