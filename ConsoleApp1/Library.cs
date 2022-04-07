using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public List<Book> Books { get; set; } = new List<Book>();
        public void AddBook(Book book1)
        {
            Books.Add(book1);
        }
        public List<Book> GetBookById(int? _Id)
        {
            return Books.FindAll(x => x.Id == _Id);
        }
        public void  RemoveBook(int _Id)
        {
            var resalt=Books.FindAll(x => x.Id == _Id);
            Books.Remove(resalt);
        }
    }
}
