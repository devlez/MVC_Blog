using Blog.Entities.Concrete;
using Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
        
    }
}
