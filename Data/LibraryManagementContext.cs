using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;

namespace LibraryManagement.Data
{
    public class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext (DbContextOptions<LibraryManagementContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryManagement.Models.User> User { get; set; }

        public DbSet<LibraryManagement.Models.Book> Book { get; set; }

        public DbSet<LibraryManagement.Models.Borrow> Borrow { get; set; }
    }
}
