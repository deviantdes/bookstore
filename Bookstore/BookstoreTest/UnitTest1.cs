using System;
using Xunit;
using Moq;
using Bookstore;
using System.Collections.Generic;

namespace BookstoreTest
{
    public class UnitTest1
    {
        [Fact]
        public void Should_BE_TRUE_as_Return_3_EnglishBook()
        {
            Mock<IRepository<ICollection<Book>, Book>> mockRepos = new Mock<IRepository<ICollection<Book>, Book>>();
            BookStore bs = new EnglishBookStore(mockRepos.Object);
            
            ICollection<Book> e = new List<Book>(){
            new Book(){bookTitle="123",bookPrice=123,bookAuthor="123",bookLanguage="english"},
            new Book(){bookTitle="123",bookPrice=123,bookAuthor="123",bookLanguage="english"},
            new Book(){bookTitle="123",bookPrice=123,bookAuthor="123",bookLanguage="english"},
            new Book(){bookTitle="123",bookPrice=123,bookAuthor="123",bookLanguage="chinese"}
            };
            
            mockRepos.Setup(x => x.getBooks()).Returns(e);

            var result = bs.getBooks().Count;

            Assert.Equal(3,result);
        }
    }
}
