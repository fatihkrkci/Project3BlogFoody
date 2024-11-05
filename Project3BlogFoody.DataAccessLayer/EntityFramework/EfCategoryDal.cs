using Project3BlogFoody.DataAccessLayer.Abstract;
using Project3BlogFoody.DataAccessLayer.Context;
using Project3BlogFoody.DataAccessLayer.Repositories;
using Project3BlogFoody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BlogFoody.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(BlogFoodyContext context) : base(context)
        {
        }
    }
}
