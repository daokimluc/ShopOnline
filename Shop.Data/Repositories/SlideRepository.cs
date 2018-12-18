using Shop.Data.Infastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {

    }
    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
         public SlideRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
