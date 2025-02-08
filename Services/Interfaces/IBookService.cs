using Library_Management_Application.DTOs.BookDTOs;
using Library_Management_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Interfaces
{
    public interface IBookService
    {
        void Create(BookCreateDTO book);
        void Delete(Book book, int id);
        void Update(Book book, int id);
        BookGetDTO GetById(int id);
        List<BookGetDTO> GetAll();

    }


}
