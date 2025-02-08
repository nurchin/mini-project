using Library_Management_Application.DTOs.BookDTOs;
using Library_Management_Application.Models;
using Library_Management_Application.PossibleExceptions.Common;
using Library_Management_Application.Repositories.Implementations;
using Library_Management_Application.Repositories.Interfaces;
using Library_Management_Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Implementations
{
    public class BookService: IBookService
    {
        public void Create(BookCreateDTO book)
        {
            if (book is null) throw new ArgumentNullException(nameof(book));
            if (string.IsNullOrWhiteSpace(book.Name)) throw new Exception("Book can't be null or empty");
            IBookRepository bookRepository = new BookRepository();
            Book bookData = new Book()
            {
                Name = book.Title,
                IsDeleted = book.IsDeleted,
                UpdatedAt = book.UpdatedAt,
                CreatedAt = book.CreatedAt

            };
            bookRepository.Add;
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

        public List<BookGetDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public BookGetDTO GetById(int id)
        {
            IBookRepository bookRepository = new BookRepository();
            var data = bookRepository.GetById(id);
            if (data is null) throw new EntityNotFound("Book not found");

            var BookGetDTO = new BookGetDTO()
            {
                Id = data.Id,
                Name = data.Name,
            };
            return BookGetDTO;

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
