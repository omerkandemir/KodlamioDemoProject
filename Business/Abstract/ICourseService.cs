using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
        List<Course> GetAll(Expression<Func<Course, bool>> filter = null);
        List<Course> GetCoursesByCategory(int categoryId);
        List<Course> GetCoursesByInstructor(int instructorId);
        List<Course> GetCoursesByCourseName(string courseName);

    }
}
