namespace UI
{
    partial class Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwCategories = new DataGridView();
            btnDelete = new Button();
            gbxAddCategory = new GroupBox();
            txtAddCategoryName = new TextBox();
            btnAddCategory = new Button();
            lblAddCategoryName = new Label();
            gbxUpdateCategory = new GroupBox();
            txtUpdateCategoryName = new TextBox();
            btnUpdateCategoryName = new Button();
            lblUpdateCategoryName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwCategories).BeginInit();
            gbxAddCategory.SuspendLayout();
            gbxUpdateCategory.SuspendLayout();
            SuspendLayout();
            // 
            // dgwCategories
            // 
            dgwCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCategories.Location = new Point(12, 12);
            dgwCategories.Name = "dgwCategories";
            dgwCategories.RowHeadersWidth = 51;
            dgwCategories.Size = new Size(632, 188);
            dgwCategories.TabIndex = 6;
            dgwCategories.CellClick += dgwCategories_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(656, 95);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 93);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbxAddCategory
            // 
            gbxAddCategory.Controls.Add(txtAddCategoryName);
            gbxAddCategory.Controls.Add(btnAddCategory);
            gbxAddCategory.Controls.Add(lblAddCategoryName);
            gbxAddCategory.Location = new Point(12, 206);
            gbxAddCategory.Name = "gbxAddCategory";
            gbxAddCategory.Size = new Size(160, 201);
            gbxAddCategory.TabIndex = 23;
            gbxAddCategory.TabStop = false;
            gbxAddCategory.Text = "Kategori Ekle";
            // 
            // txtAddCategoryName
            // 
            txtAddCategoryName.Location = new Point(19, 66);
            txtAddCategoryName.Name = "txtAddCategoryName";
            txtAddCategoryName.Size = new Size(125, 27);
            txtAddCategoryName.TabIndex = 13;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(13, 99);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(141, 93);
            btnAddCategory.TabIndex = 12;
            btnAddCategory.Text = "Ekle";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // lblAddCategoryName
            // 
            lblAddCategoryName.AutoSize = true;
            lblAddCategoryName.Location = new Point(33, 43);
            lblAddCategoryName.Name = "lblAddCategoryName";
            lblAddCategoryName.Size = new Size(93, 20);
            lblAddCategoryName.TabIndex = 2;
            lblAddCategoryName.Text = "Kategori Adı";
            // 
            // gbxUpdateCategory
            // 
            gbxUpdateCategory.Controls.Add(txtUpdateCategoryName);
            gbxUpdateCategory.Controls.Add(btnUpdateCategoryName);
            gbxUpdateCategory.Controls.Add(lblUpdateCategoryName);
            gbxUpdateCategory.Location = new Point(178, 206);
            gbxUpdateCategory.Name = "gbxUpdateCategory";
            gbxUpdateCategory.Size = new Size(160, 201);
            gbxUpdateCategory.TabIndex = 24;
            gbxUpdateCategory.TabStop = false;
            gbxUpdateCategory.Text = "Kategori Güncelle";
            // 
            // txtUpdateCategoryName
            // 
            txtUpdateCategoryName.Location = new Point(19, 66);
            txtUpdateCategoryName.Name = "txtUpdateCategoryName";
            txtUpdateCategoryName.Size = new Size(125, 27);
            txtUpdateCategoryName.TabIndex = 13;
            // 
            // btnUpdateCategoryName
            // 
            btnUpdateCategoryName.Location = new Point(13, 99);
            btnUpdateCategoryName.Name = "btnUpdateCategoryName";
            btnUpdateCategoryName.Size = new Size(141, 93);
            btnUpdateCategoryName.TabIndex = 12;
            btnUpdateCategoryName.Text = "Güncelle";
            btnUpdateCategoryName.UseVisualStyleBackColor = true;
            btnUpdateCategoryName.Click += btnUpdateCategoryName_Click;
            // 
            // lblUpdateCategoryName
            // 
            lblUpdateCategoryName.AutoSize = true;
            lblUpdateCategoryName.Location = new Point(33, 43);
            lblUpdateCategoryName.Name = "lblUpdateCategoryName";
            lblUpdateCategoryName.Size = new Size(93, 20);
            lblUpdateCategoryName.TabIndex = 2;
            lblUpdateCategoryName.Text = "Kategori Adı";
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxUpdateCategory);
            Controls.Add(gbxAddCategory);
            Controls.Add(btnDelete);
            Controls.Add(dgwCategories);
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCategories).EndInit();
            gbxAddCategory.ResumeLayout(false);
            gbxAddCategory.PerformLayout();
            gbxUpdateCategory.ResumeLayout(false);
            gbxUpdateCategory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwCategories;
        private Button btnDelete;
        private GroupBox gbxAddCategory;
        private TextBox txtAddCategoryName;
        private Button btnAddCategory;
        private Label lblAddCategoryName;
        private GroupBox gbxUpdateCategory;
        private TextBox txtUpdateCategoryName;
        private Button btnUpdateCategoryName;
        private Label lblUpdateCategoryName;
    }
}