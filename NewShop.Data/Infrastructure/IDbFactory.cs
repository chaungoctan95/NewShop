using NewShop.Data.Infrastructure;
using System;

namespace NewShop.Data.Infrastructure
{
    //giao tiep de khoi tao cac doi tuong entity

    public interface IDbFactory : IDisposable
    {
        //phuong thuc de init dbcontext
        NewShopDbContext Init();
        
    }
}