using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewShop.Data.Infrastructure;
using NewShop.Model.Models;

namespace NewShop.Data.Repositories
{
    public interface IContactDetailRepository : IRepository<ContactDetail>
    {
    }

    public class ContactDetailRepository : RepositoryBase<ContactDetail>, IContactDetailRepository
    {
        public ContactDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
