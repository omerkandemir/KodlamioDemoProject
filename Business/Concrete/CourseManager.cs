using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            ValidationTool.Validate(new CourseValidator(), course);
            _courseDal.Add(course);
        }
        public void Update(Course course)
        {
            ValidationTool.Validate(new CourseValidator(), course);
            _courseDal.Update(course);
        }
        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            return _courseDal.GetAllInclude(filter, x => x.Instructor, x => x.Category);
            
        }

        public List<Course> GetCoursesByCategory(int categoryId)
        {
            return _courseDal.GetAll(x => x.CategoryId == categoryId);
        }
        public List<Course> GetCoursesByInstructor(int instructorId)
        {
            return _courseDal.GetAll(x => x.InstructorId == instructorId);
        }
        public List<Course> GetCoursesByCourseName(string courseName)
        {
            return _courseDal.GetAll(x => x.Name.ToLower().Contains(courseName.ToLower()));
        }
    }
}
