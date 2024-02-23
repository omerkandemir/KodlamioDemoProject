using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, KodlamioDemoProjectContext>, ICategoryDal
    {
    }
}
