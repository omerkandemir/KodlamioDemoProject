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
    public partial class Instructors : Form
    {
        IInstructorService _instructorService;
        public Instructors()
        {
            _instructorService = new InstructorManager(new EfInstructorDal());
            InitializeComponent();
        }
        private void Instructors_Load(object sender, EventArgs e)
        {
            LoadInstructors();
        }
        private void LoadInstructors()
        {
            dgwInstructor.DataSource = _instructorService.GetAll();
        }
        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            _instructorService.Add(new Instructor
            {
                FirstName = txtAddName.Text,
                LastName = txtAddSurname.Text,
                BirthDate = Convert.ToDateTime(dtpAddBirthDate.Value),
                Mail = txtAddMailAdress.Text,
            });
            MessageBox.Show("Eğitmen Kaydedildi");
            LoadInstructors();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            _instructorService.Update(new Instructor
            {
                Id = Convert.ToInt32(dgwInstructor.CurrentRow.Cells[4].Value),
                FirstName = txtUpdateName.Text,
                LastName = txtUpdateSurname.Text,
                BirthDate = Convert.ToDateTime(dtpUpdateBirthDate.Value),
                Mail = txtUpdateMailAdress.Text,
            });
            MessageBox.Show("Eğitmen Güncellendi!");
            LoadInstructors();
        }

        private void dgwInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwInstructor.CurrentRow;
            txtUpdateName.Text = row.Cells[0].Value.ToString();
            txtUpdateSurname.Text = row.Cells[1].Value.ToString();
            dtpUpdateBirthDate.Value = Convert.ToDateTime(row.Cells[2].Value);
            txtUpdateMailAdress.Text = row.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwInstructor.CurrentRow != null)
            {
                try
                {
                    _instructorService.Delete(new Instructor
                    {
                        Id = Convert.ToInt32(dgwInstructor.CurrentRow.Cells[4].Value)
                    });
                    MessageBox.Show("Ürün Silindi!");
                    LoadInstructors();//Ürün Kaydedildikten sonra eklenen ürünün gösterilmesi
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
