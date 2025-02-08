using Library_Management_Application.Models;
using Library_Management_Application.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Repositories.Implementations
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Books.Add(book);
            appDbContext.SaveChanges();
        }

        public void Delete(Book book, int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Books.Remove(book);
            appDbContext.SaveChanges();        
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            AppDbContext appDbContext = new AppDbContext();
            return appDbContext.Books.ToList();
            appDbContext.SaveChanges();
        }

        public Book GetById(int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            return appDbContext.Books.FirstOrDefault(x => x.Id == id);
           
        }

        public void Update(Book book, int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Books.Update(book);
            appDbContext.SaveChanges();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
