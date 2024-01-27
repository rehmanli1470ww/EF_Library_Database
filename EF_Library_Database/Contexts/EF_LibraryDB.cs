using EF_Library_Database.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library_Database.Contexts
{
    public class EF_LibraryDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=RUBAIL\\SQLEXPRESS;Initial Catalog=EF_LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Author> ?Authors { get; set; }
        public DbSet<Book> ?Books { get; set; }
        public DbSet<BookType> ? BookTypes { get; set; }
        public DbSet<Operation> ?Operations { get; set; }
        public DbSet<Student> ? Students { get; set; }


    }
}
