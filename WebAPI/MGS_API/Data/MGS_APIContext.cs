using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MGS_API.Models;

namespace MGS_API.Data
{
    public class MGS_APIContext : DbContext
    {
        public MGS_APIContext (DbContextOptions<MGS_APIContext> options)
            : base(options)
        {
        }

        public DbSet<MGS_API.Models.Person> Person { get; set; }
    }
}
