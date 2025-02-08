using Library_Management_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Interfaces
{
    internal interface IAuthorService
    {
        public interface IAuthorService
        {
            void Create(Author author);
            void Delete(Author author, int id);
            void Update(Author author, int id);

        }
    }
}
