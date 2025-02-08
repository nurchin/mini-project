using Library_Management_Application.Models;
using Library_Management_Application.Services.Implementations;
using Library_Management_Application.Services.Interfaces;

namespace Library_Management_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookService bookService = new BookService();
            bookService.Create(new Book() { Title = "White Nights" });
            bookService.Create(new Book() { Title = "Les Miserables" });
            bookService.Create(new Book() { Title = "Pride and Prejudice" });
            bookService.Create(new Book() { Title = "Little Women" });
            bookService.Create(new Book() { Title = "The picture of Dorian Gray" });


        }


    }
}