using Dlayer.Core.DataAccess.EfRepository;
using Dlayer.Entities;
using Dlayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer.DataAccess.Concrete
{
   public class ProductService:EfRepositoryBase<Product>
    {
        private readonly FakeStoreContext _context;
        public ProductService(FakeStoreContext context):base(context)
        {
            _context = context;
        }
    }
}
