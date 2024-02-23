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
    public partial class Courses : BaseForm
    {
        ICourseService _courseService;
        IInstructorService _instructorService;
        ICategoryService _categoryService;
        public Courses()
        {
            _courseService = new CourseManager(new EfCourseDal());
            _instructorService = new InstructorManager(new EfInstructorDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadInstructors();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxAddCourseFromCategory.DataSource = _categoryService.GetAll();
            cbxAddCourseFromCategory.DisplayMember = "Name";
            cbxAddCourseFromCategory.SelectedIndex = 0;
            cbxAddCourseFromCategory.ValueMember = "Id";

            cbxUpdateCourseFromCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCourseFromCategory.DisplayMember = "Name";
            cbxUpdateCourseFromCategory.SelectedIndex = 0;
            cbxUpdateCourseFromCategory.ValueMember = "Id";
        }

        private void LoadInstructors()
        {
            cbxAddCourseFromInstructor.DataSource = _instructorService.GetAll();
            cbxAddCourseFromInstructor.DisplayMember = "FirstName";
            cbxAddCourseFromInstructor.SelectedIndex = 0;
            cbxAddCourseFromInstructor.ValueMember = "Id";

            cbxUpdateCourseFromInstructor.DataSource = _instructorService.GetAll();
            cbxUpdateCourseFromInstructor.DisplayMember = "FirstName";
            cbxUpdateCourseFromInstructor.SelectedIndex = 0;
            cbxUpdateCourseFromInstructor.ValueMember = "Id";
        }

        private void LoadCourses()
        {
            dgwCourses.DataSource = _courseService.GetAll();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _courseService.Add(new Course
                {
                    Name = txtAddCourseName.Text,
                    CategoryId = Convert.ToInt32(cbxAddCourseFromCategory.SelectedValue),
                    InstructorId = Convert.ToInt32(cbxAddCourseFromInstructor.SelectedValue),
                });
                MessageBox.Show("Kurs Kaydedildi");
                LoadCourses();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _courseService.Update(new Course
                {
                    Id = Convert.ToInt32(dgwCourses.CurrentRow.Cells[3].Value),
                    Name = txtUpdateCourseName.Text,
                    CategoryId = Convert.ToInt32(cbxUpdateCourseFromCategory.SelectedValue),
                    InstructorId = Convert.ToInt32(cbxUpdateCourseFromInstructor.SelectedValue),
                });
                MessageBox.Show("Kurs Güncellendi");
                LoadCourses();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwCourses.CurrentRow != null)
            {
                try
                {
                    _courseService.Delete(new Course
                    {
                        Id = Convert.ToInt32(dgwCourses.CurrentRow.Cells[3].Value)
                    });
                    MessageBox.Show("Kurs Silindi!");
                    LoadCourses();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void dgwCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCourses.CurrentRow;
            txtUpdateCourseName.Text = row.Cells[0].Value.ToString();
            cbxUpdateCourseFromCategory.SelectedValue = row.Cells[1].Value;
            cbxUpdateCourseFromInstructor.SelectedValue = row.Cells[2].Value;
        }
    }
}
