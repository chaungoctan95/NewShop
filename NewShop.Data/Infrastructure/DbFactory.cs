namespace NewShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NewShopDbContext dbContext;

        public NewShopDbContext Init()
        {
            //kiem tra neu null khoi tao 1 dbcoontext
            return dbContext ?? (dbContext = new NewShopDbContext());
        }

        protected override void DisposeCore()
        {
            //neu khong dispose
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}