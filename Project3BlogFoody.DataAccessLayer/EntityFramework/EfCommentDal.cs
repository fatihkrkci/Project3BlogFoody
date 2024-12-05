using Microsoft.EntityFrameworkCore;
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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(BlogFoodyContext context) : base(context)
        {
        }

        public List<Comment> GetCommentsByAppUserId(int id)
        {
            var context = new BlogFoodyContext();
            var values = context.Comments.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public List<Comment> GetCommentsByArticleId(int id)
        {
            var context = new BlogFoodyContext();
            var values = context.Comments.Where(x => x.ArticleId == id).Include(y => y.AppUser).ToList();
            return values;
        }
    }
}
