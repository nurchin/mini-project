using Library_Management_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services
{
    public interface IBookService
    {
        void Create(Book book);
        void Delete(Book book, int id);
        void Update(Book book,int id);



    }
}
