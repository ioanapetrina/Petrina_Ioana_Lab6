using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Petrina_Ioana_Lab6.Models;

namespace Petrina_Ioana_Lab6.Data
{
    public class Petrina_Ioana_Lab6Context : DbContext
    {
        public Petrina_Ioana_Lab6Context (DbContextOptions<Petrina_Ioana_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Petrina_Ioana_Lab6.Models.Book> Book { get; set; }
    }
}
