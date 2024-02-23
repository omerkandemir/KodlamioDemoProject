namespace UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void RemoveColumn(DataGridView dataGridView, string columnName)
        {
            DataGridViewColumn column = dataGridView.Columns[columnName];
            if (column != null)
            {
                dataGridView.Columns.Remove(column);
            }
        }   
    }
}
