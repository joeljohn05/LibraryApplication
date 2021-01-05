using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    public class BookDetailContext:DbContext
    {
        public BookDetailContext(DbContextOptions<BookDetailContext> options):base(options)
        {

        }

        public DbSet<BookDetails> BookDetails { get; set; }
        public DbSet<LoginDetails> LoginDetails { get; set; }
    }
}
