namespace UI
{
    partial class KodlamioDemoProject
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
            cbxCategory = new ComboBox();
            gbxFilter = new GroupBox();
            txtGetCoursesByName = new TextBox();
            lblSearch = new Label();
            lblInstructor = new Label();
            cbxInstructor = new ComboBox();
            lblCategory = new Label();
            dgwCourse = new DataGridView();
            btnCourse = new Button();
            btnInstructor = new Button();
            btnCategory = new Button();
            gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCourse).BeginInit();
            SuspendLayout();
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(6, 57);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(151, 28);
            cbxCategory.TabIndex = 0;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // gbxFilter
            // 
            gbxFilter.Controls.Add(txtGetCoursesByName);
            gbxFilter.Controls.Add(lblSearch);
            gbxFilter.Controls.Add(lblInstructor);
            gbxFilter.Controls.Add(cbxInstructor);
            gbxFilter.Controls.Add(lblCategory);
            gbxFilter.Controls.Add(cbxCategory);
            gbxFilter.Location = new Point(12, 12);
            gbxFilter.Name = "gbxFilter";
            gbxFilter.Size = new Size(674, 125);
            gbxFilter.TabIndex = 1;
            gbxFilter.TabStop = false;
            gbxFilter.Text = "Filtrele";
            // 
            // txtGetCoursesByName
            // 
            txtGetCoursesByName.Location = new Point(366, 57);
            txtGetCoursesByName.Name = "txtGetCoursesByName";
            txtGetCoursesByName.Size = new Size(295, 27);
            txtGetCoursesByName.TabIndex = 5;
            txtGetCoursesByName.TextChanged += txtGetCoursesByName_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(502, 34);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(32, 20);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Ara";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Location = new Point(221, 34);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(64, 20);
            lblInstructor.TabIndex = 3;
            lblInstructor.Text = "Eğitmen";
            // 
            // cbxInstructor
            // 
            cbxInstructor.FormattingEnabled = true;
            cbxInstructor.Location = new Point(182, 57);
            cbxInstructor.Name = "cbxInstructor";
            cbxInstructor.Size = new Size(151, 28);
            cbxInstructor.TabIndex = 2;
            cbxInstructor.SelectedIndexChanged += cbxInstructor_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(45, 34);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(66, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Kategori";
            // 
            // dgwCourse
            // 
            dgwCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCourse.Location = new Point(12, 143);
            dgwCourse.Name = "dgwCourse";
            dgwCourse.RowHeadersWidth = 51;
            dgwCourse.Size = new Size(466, 315);
            dgwCourse.TabIndex = 2;
            // 
            // btnCourse
            // 
            btnCourse.Location = new Point(500, 143);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(173, 101);
            btnCourse.TabIndex = 3;
            btnCourse.Text = "Kurs İşlemleri";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnInstructor
            // 
            btnInstructor.Location = new Point(500, 250);
            btnInstructor.Name = "btnInstructor";
            btnInstructor.Size = new Size(173, 101);
            btnInstructor.TabIndex = 4;
            btnInstructor.Text = "Eğitmen İşlemleri";
            btnInstructor.UseVisualStyleBackColor = true;
            btnInstructor.Click += btnInstructor_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(500, 357);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(173, 101);
            btnCategory.TabIndex = 5;
            btnCategory.Text = "Kategori İşlemleri";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // KodlamioDemoProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 469);
            Controls.Add(btnCategory);
            Controls.Add(btnInstructor);
            Controls.Add(btnCourse);
            Controls.Add(dgwCourse);
            Controls.Add(gbxFilter);
            Name = "KodlamioDemoProject";
            Text = "KodlamioDemoProject";
            Load += KodlamioDemoProject_Load;
            gbxFilter.ResumeLayout(false);
            gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbxCategory;
        private GroupBox gbxFilter;
        private TextBox txtGetCoursesByName;
        private Label lblSearch;
        private Label lblInstructor;
        private ComboBox cbxInstructor;
        private Label lblCategory;
        private DataGridView dgwCourse;
        private Button btnCourse;
        private Button btnInstructor;
        private Button btnCategory;
    }
}