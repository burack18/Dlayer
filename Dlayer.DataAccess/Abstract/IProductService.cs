using Dlayer.Core.DataAccess;
using Dlayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer.DataAccess.Abstract
{
   public interface IProductService:IEntityRepository<Product>
    {
    }
}
