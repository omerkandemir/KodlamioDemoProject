namespace UI
{
    partial class Courses
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
            btnDelete = new Button();
            gbxAddCourse = new GroupBox();
            btnAdd = new Button();
            lblAddInstructorId = new Label();
            cbxAddCourseFromInstructor = new ComboBox();
            cbxAddCourseFromCategory = new ComboBox();
            txtAddCourseName = new TextBox();
            lblAddCategoryId = new Label();
            lblAddCourseName = new Label();
            gbxUpdateCourse = new GroupBox();
            cbxUpdateCourseFromInstructor = new ComboBox();
            cbxUpdateCourseFromCategory = new ComboBox();
            txtUpdateCourseName = new TextBox();
            btnUpdate = new Button();
            lblUpdateInstructorId = new Label();
            lblUpdateCategoryId = new Label();
            lblUpdateCourseName = new Label();
            dgwCourses = new DataGridView();
            gbxAddCourse.SuspendLayout();
            gbxUpdateCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCourses).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(656, 49);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 93);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbxAddCourse
            // 
            gbxAddCourse.Controls.Add(btnAdd);
            gbxAddCourse.Controls.Add(lblAddInstructorId);
            gbxAddCourse.Controls.Add(cbxAddCourseFromInstructor);
            gbxAddCourse.Controls.Add(cbxAddCourseFromCategory);
            gbxAddCourse.Controls.Add(txtAddCourseName);
            gbxAddCourse.Controls.Add(lblAddCategoryId);
            gbxAddCourse.Controls.Add(lblAddCourseName);
            gbxAddCourse.Location = new Point(12, 282);
            gbxAddCourse.Name = "gbxAddCourse";
            gbxAddCourse.Size = new Size(398, 156);
            gbxAddCourse.TabIndex = 23;
            gbxAddCourse.TabStop = false;
            gbxAddCourse.Text = "Yeni Kurs Ekle";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(252, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 102);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAddInstructorId
            // 
            lblAddInstructorId.AutoSize = true;
            lblAddInstructorId.Location = new Point(26, 110);
            lblAddInstructorId.Name = "lblAddInstructorId";
            lblAddInstructorId.Size = new Size(66, 20);
            lblAddInstructorId.TabIndex = 17;
            lblAddInstructorId.Text = "Kategori";
            // 
            // cbxAddCourseFromInstructor
            // 
            cbxAddCourseFromInstructor.FormattingEnabled = true;
            cbxAddCourseFromInstructor.Location = new Point(105, 110);
            cbxAddCourseFromInstructor.Name = "cbxAddCourseFromInstructor";
            cbxAddCourseFromInstructor.Size = new Size(125, 28);
            cbxAddCourseFromInstructor.TabIndex = 16;
            // 
            // cbxAddCourseFromCategory
            // 
            cbxAddCourseFromCategory.FormattingEnabled = true;
            cbxAddCourseFromCategory.Location = new Point(105, 76);
            cbxAddCourseFromCategory.Name = "cbxAddCourseFromCategory";
            cbxAddCourseFromCategory.Size = new Size(125, 28);
            cbxAddCourseFromCategory.TabIndex = 15;
            // 
            // txtAddCourseName
            // 
            txtAddCourseName.Location = new Point(105, 40);
            txtAddCourseName.Name = "txtAddCourseName";
            txtAddCourseName.Size = new Size(125, 27);
            txtAddCourseName.TabIndex = 14;
            // 
            // lblAddCategoryId
            // 
            lblAddCategoryId.AutoSize = true;
            lblAddCategoryId.Location = new Point(26, 79);
            lblAddCategoryId.Name = "lblAddCategoryId";
            lblAddCategoryId.Size = new Size(66, 20);
            lblAddCategoryId.TabIndex = 4;
            lblAddCategoryId.Text = "Kategori";
            // 
            // lblAddCourseName
            // 
            lblAddCourseName.AutoSize = true;
            lblAddCourseName.Location = new Point(24, 43);
            lblAddCourseName.Name = "lblAddCourseName";
            lblAddCourseName.Size = new Size(64, 20);
            lblAddCourseName.TabIndex = 2;
            lblAddCourseName.Text = "Kurs Adı";
            // 
            // gbxUpdateCourse
            // 
            gbxUpdateCourse.Controls.Add(cbxUpdateCourseFromInstructor);
            gbxUpdateCourse.Controls.Add(cbxUpdateCourseFromCategory);
            gbxUpdateCourse.Controls.Add(txtUpdateCourseName);
            gbxUpdateCourse.Controls.Add(btnUpdate);
            gbxUpdateCourse.Controls.Add(lblUpdateInstructorId);
            gbxUpdateCourse.Controls.Add(lblUpdateCategoryId);
            gbxUpdateCourse.Controls.Add(lblUpdateCourseName);
            gbxUpdateCourse.Location = new Point(416, 292);
            gbxUpdateCourse.Name = "gbxUpdateCourse";
            gbxUpdateCourse.Size = new Size(398, 156);
            gbxUpdateCourse.TabIndex = 24;
            gbxUpdateCourse.TabStop = false;
            gbxUpdateCourse.Text = "Yeni Kurs Ekle";
            // 
            // cbxUpdateCourseFromInstructor
            // 
            cbxUpdateCourseFromInstructor.FormattingEnabled = true;
            cbxUpdateCourseFromInstructor.Location = new Point(98, 110);
            cbxUpdateCourseFromInstructor.Name = "cbxUpdateCourseFromInstructor";
            cbxUpdateCourseFromInstructor.Size = new Size(125, 28);
            cbxUpdateCourseFromInstructor.TabIndex = 14;
            // 
            // cbxUpdateCourseFromCategory
            // 
            cbxUpdateCourseFromCategory.FormattingEnabled = true;
            cbxUpdateCourseFromCategory.Location = new Point(97, 76);
            cbxUpdateCourseFromCategory.Name = "cbxUpdateCourseFromCategory";
            cbxUpdateCourseFromCategory.Size = new Size(125, 28);
            cbxUpdateCourseFromCategory.TabIndex = 2;
            // 
            // txtUpdateCourseName
            // 
            txtUpdateCourseName.Location = new Point(97, 40);
            txtUpdateCourseName.Name = "txtUpdateCourseName";
            txtUpdateCourseName.Size = new Size(125, 27);
            txtUpdateCourseName.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 36);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 102);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblUpdateInstructorId
            // 
            lblUpdateInstructorId.AutoSize = true;
            lblUpdateInstructorId.Location = new Point(24, 113);
            lblUpdateInstructorId.Name = "lblUpdateInstructorId";
            lblUpdateInstructorId.Size = new Size(64, 20);
            lblUpdateInstructorId.TabIndex = 5;
            lblUpdateInstructorId.Text = "Eğitmen";
            // 
            // lblUpdateCategoryId
            // 
            lblUpdateCategoryId.AutoSize = true;
            lblUpdateCategoryId.Location = new Point(26, 79);
            lblUpdateCategoryId.Name = "lblUpdateCategoryId";
            lblUpdateCategoryId.Size = new Size(66, 20);
            lblUpdateCategoryId.TabIndex = 4;
            lblUpdateCategoryId.Text = "Kategori";
            // 
            // lblUpdateCourseName
            // 
            lblUpdateCourseName.AutoSize = true;
            lblUpdateCourseName.Location = new Point(24, 43);
            lblUpdateCourseName.Name = "lblUpdateCourseName";
            lblUpdateCourseName.Size = new Size(64, 20);
            lblUpdateCourseName.TabIndex = 2;
            lblUpdateCourseName.Text = "Kurs Adı";
            // 
            // dgwCourses
            // 
            dgwCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCourses.Location = new Point(12, 9);
            dgwCourses.Name = "dgwCourses";
            dgwCourses.RowHeadersWidth = 51;
            dgwCourses.Size = new Size(626, 267);
            dgwCourses.TabIndex = 25;
            dgwCourses.CellClick += dgwCourses_CellClick;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 450);
            Controls.Add(dgwCourses);
            Controls.Add(gbxUpdateCourse);
            Controls.Add(gbxAddCourse);
            Controls.Add(btnDelete);
            Name = "Courses";
            Text = "Courses";
            Load += Courses_Load;
            gbxAddCourse.ResumeLayout(false);
            gbxAddCourse.PerformLayout();
            gbxUpdateCourse.ResumeLayout(false);
            gbxUpdateCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwInstructor;
        private Button btnDelete;
        private GroupBox gbxAddCourse;
        private Label lblAddCategoryId;
        private Label lblAddCourseName;
        private GroupBox gbxUpdateCourse;
        private ComboBox cbxUpdateCourseFromInstructor;
        private ComboBox cbxUpdateCourseFromCategory;
        private TextBox txtUpdateCourseName;
        private Button btnUpdate;
        private Label lblUpdateInstructorId;
        private Label lblUpdateCategoryId;
        private Label lblUpdateCourseName;
        private TextBox txtAddCourseName;
        private DataGridView dgwCourses;
        private ComboBox cbxAddCourseFromInstructor;
        private ComboBox cbxAddCourseFromCategory;
        private Label lblAddInstructorId;
        private Button btnAdd;
    }
}