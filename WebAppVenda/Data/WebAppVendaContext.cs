using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppVenda.Models;

namespace WebAppVenda.Data
{
    public class WebAppVendaContext : DbContext
    {
        public WebAppVendaContext (DbContextOptions<WebAppVendaContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppVenda.Models.Department> Department { get; set; }
    }
}
