using Ksiegarnia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ksiegarnia.Data
{
    //klasa kontekstu bazy danych
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<BookModel> Book { get; set; }
    }
}
