using NewShop.Data.Infrastructure;
using NewShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace NewShop.Data.Repositories
{
    //khoi tao 1 interface khong co trong IRepository
    public interface IProductCategoryRespository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRespository : RepositoryBase<ProductCategory>,IProductCategoryRespository
    {
        public  ProductCategoryRespository(IDbFactory dbFactory):base(dbFactory)
        {
        }

        //phuong thuc dinh nghia them khong co trong repository
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
