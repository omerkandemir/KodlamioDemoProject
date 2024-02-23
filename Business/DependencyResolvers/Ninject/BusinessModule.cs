using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
           
            Bind<ICourseService>().To<CourseManager>().InSingletonScope();
            Bind<ICourseDal>().To<EfCourseDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<IInstructorService>().To<InstructorManager>().InSingletonScope();
            Bind<IInstructorDal>().To<EfInstructorDal>().InSingletonScope();
        }
    }
}
