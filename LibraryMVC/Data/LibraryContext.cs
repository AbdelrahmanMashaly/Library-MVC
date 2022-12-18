using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryMVC.Models;

namespace LibraryMVC.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryMVC.Models.Book> Book { get; set; } = default!;

        public DbSet<LibraryMVC.Models.usersaccounts> usersaccounts { get; set; }

        public DbSet<LibraryMVC.Models.orders> orders { get; set; }
    }
}
