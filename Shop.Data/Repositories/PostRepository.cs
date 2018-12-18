using Shop.Data.Infastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int PageSize, out int totalRow);
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        // Kế thừa contractor, lúc khởi tạo ProductRepository, truyền vào dbFactory đồng thời lấy giá trị đó truyền vào
        //contructor của RepositoryBase để khởi tạo RepositoryBase, thao tác được
        public PostRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int PageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status == true
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip(pageIndex - 1 * PageSize).Take(PageSize);
            return query;
        }

    }
}
