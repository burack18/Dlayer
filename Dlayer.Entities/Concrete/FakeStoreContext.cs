using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer.Entities.Concrete
{
   public class FakeStoreContext:IdentityDbContext
    {
        public FakeStoreContext(DbContextOptions<FakeStoreContext>options):base(options)
        {
            
        }
      
        public DbSet<Product> Products { get; set; }
    }
}
