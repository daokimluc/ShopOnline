using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Infastructure
{
    // Giao tiếp khởi tạo các đối tượng Entity, không khởi tạo trực tiếp 
    public interface IDbFactory : IDisposable
    {

        ShopDbContext Init();

    }
}
