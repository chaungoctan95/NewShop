using NewShop.Data.Infrastructure;
using NewShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop.Data.Repositories
{
    public interface IProductRepository
    {
    }
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory): base(dbFactory)
        {
        }
    }
}
