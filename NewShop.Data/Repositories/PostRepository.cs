using NewShop.Data.Infrastructure;
using NewShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        //dùng để hiện thị danh sách bài viết mà có tag
        //kicks vào tag sẽ hiện danh sách categories
        IEnumerable<Post> GetAllPageTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllPageTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            //Phân trang, pageIndex trang hiện tại
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query;

        }
    }
}
