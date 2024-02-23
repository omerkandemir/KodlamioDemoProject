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
    public partial class Categories : Form
    {
        ICategoryService _categoryService;
        public Categories()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            dgwCategories.DataSource = _categoryService.GetAll();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            _categoryService.Add(new Category
            {
                Name = txtAddCategoryName.Text,
            });
            MessageBox.Show("Kategori Kaydedildi");
            LoadCategories();
        }

        private void btnUpdateCategoryName_Click(object sender, EventArgs e)
        {
            _categoryService.Update(new Category
            {
                Id = Convert.ToInt32(dgwCategories.CurrentRow.Cells[1].Value),
                Name = txtUpdateCategoryName.Text,
            });
            MessageBox.Show("Kategori Güncellendi!");
            LoadCategories();
        }

        private void dgwCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCategories.CurrentRow;
            txtUpdateCategoryName.Text = row.Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwCategories.CurrentRow != null)
            {
                try
                {
                    _categoryService.Delete(new Category
                    {
                        Id = Convert.ToInt32(dgwCategories.CurrentRow.Cells[1].Value)
                    });
                    MessageBox.Show("Kategori Silindi!");
                    LoadCategories();//Ürün Kaydedildikten sonra eklenen ürünün gösterilmesi
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
