using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public interface IRepository<T,E>
    {
        T getBooks();
        void addBook(E b);
    }
}
