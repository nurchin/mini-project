using Library_Management_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Repositories.Interfaces
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book); 
        Book GetById(int id);
        List <Book> GetAll();
           
    }
}
