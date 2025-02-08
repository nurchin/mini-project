using Library_Management_Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application
{
    internal class AppDbContext:DbContext
    { 
        public DbSet<Author> Authors { get; set; }   
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanItem> LoanItems { get; set; }
        public DbSet<BookAuthors> BookAuthors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JC7OHVQ\\MSSQLSERVER01; Database = PB503MiniProject; Trusted_Connection = True; TrustServerCertificate= True");
            base.OnConfiguring(optionsBuilder);

        }

    }
}
