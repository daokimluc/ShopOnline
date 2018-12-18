using Shop.Data.Infastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {

    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        // Kế thừa contractor, lúc khởi tạo ProductRepository, truyền vào dbFactory đồng thời lấy giá trị đó truyền vào
        //contructor của RepositoryBase để khởi tạo RepositoryBase, thao tác được
        public FooterRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
