using BackGroundService.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundService.Data.DatabaseContext
{
    public class BackgroundContext : DbContext
    {
        public BackgroundContext(DbContextOptions<BackgroundContext> options) : base(options)  { }

            public DbSet<TempData> TempData { get; set; }
            public DbSet<ActualData> ActualData { get; set; }

    }

}
    
