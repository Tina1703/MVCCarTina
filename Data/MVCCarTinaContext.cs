using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCCarTina.Models;

namespace MVCCarTina.Data
{
    public class MVCCarTinaContext : DbContext
    {
        public MVCCarTinaContext (DbContextOptions<MVCCarTinaContext> options)
            : base(options)
        {
        }

        public DbSet<MVCCarTina.Models.Car> Car { get; set; } = default!;
    }
}
