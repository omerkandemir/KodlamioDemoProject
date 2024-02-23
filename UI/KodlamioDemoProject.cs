using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class KodlamioDemoProject : Form
    {
        IInstructorService _instructorService;
        ICategoryService _categoryService;
        ICourseService _courseService;
        public KodlamioDemoProject()
        {
            _instructorService = new InstructorManager(new EfInstructorDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            _courseService = new CourseManager(new EfCourseDal());
            InitializeComponent();
        }

        private void KodlamioDemoProject_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadCourses();
            LoadInstructors();

        }

        private void LoadCourses()
        {
            dgwCourse.DataSource = _courseService.GetAll();
        }

        private void LoadInstructors()
        {
            cbxInstructor.Name = "cbxInstructor";
            cbxInstructor.ValueMember = "Id";
            cbxCategory.DisplayMember = "FirstName";
            cbxInstructor.DataSource = _instructorService.GetAll();
            cbxInstructor.SelectedIndex = 0;
        }

        private void LoadCategories()
        {
            cbxCategory.Name = "cbxCategory";
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.SelectedIndex = 0;
            cbxCategory.ValueMember = "Id";
            cbxCategory.DisplayMember = "Name";
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            Instructors form = new Instructors();
            form.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Categories form = new Categories();
            form.ShowDialog();

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Courses form = new Courses();
            form.ShowDialog();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwCourse.DataSource = _courseService.GetCoursesByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void cbxInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwCourse.DataSource = _courseService.GetCoursesByInstructor(Convert.ToInt32(cbxInstructor.SelectedValue));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }


        private void txtGetCoursesByName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtGetCoursesByName.Text))
            {
                dgwCourse.DataSource = _courseService.GetCoursesByCourseName(txtGetCoursesByName.Text);
            }
            else
            {
                LoadCourses();
            }
        }
    }
}
