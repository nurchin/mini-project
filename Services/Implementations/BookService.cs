using Library_Management_Application.Models;
using Library_Management_Application.PossibleExceptions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Implementations
{
    public class BookService: IBookService
    {
        public void Create(Book book)
        {
            book.CreatedDate = DateTime.UtcNow.AddHours(4);
            book.UpdatedDate = DateTime.UtcNow.AddHours(4);

            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Books.Add(book);
            appDbContext.SaveChanges();

        }

        public void Delete(Book book, int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            var data= appDbContext.Books.FirstOrDefault (x=>x.Id==id);
            if(data is null ) throw new EntityNotFound("Book is not found");
            data.IsDeleted = true;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            appDbContext.SaveChanges();
        }

        public void Update(Book book, int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Books.FirstOrDefault(x => x.Id == id);
            if (book is null) throw new EntityNotFound("Book is not found");
            book.CreatedDate = DateTime.UtcNow.AddHours(4);
            appDbContext.Books.Remove(book);
            appDbContext.SaveChanges();
        }

            

    }
}
