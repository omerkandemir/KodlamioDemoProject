namespace UI
{
    partial class Instructors
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
            gbxAddInstructor = new GroupBox();
            txtAddMailAdress = new TextBox();
            txtAddSurname = new TextBox();
            lblBirthDate = new Label();
            dtpAddBirthDate = new DateTimePicker();
            txtAddName = new TextBox();
            btnAddInstructor = new Button();
            lblAddSurname = new Label();
            lblAddMailAdress = new Label();
            lblAddInstructorName = new Label();
            dgwInstructor = new DataGridView();
            gbxUpdateInstructor = new GroupBox();
            txtUpdateMailAdress = new TextBox();
            txtUpdateSurname = new TextBox();
            lblUpdateBirthDate = new Label();
            dtpUpdateBirthDate = new DateTimePicker();
            txtUpdateName = new TextBox();
            Update = new Button();
            lblUpdateSurname = new Label();
            llblUpdateMailAdress = new Label();
            lblUpdateName = new Label();
            btnDelete = new Button();
            gbxAddInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwInstructor).BeginInit();
            gbxUpdateInstructor.SuspendLayout();
            SuspendLayout();
            // 
            // gbxAddInstructor
            // 
            gbxAddInstructor.Controls.Add(txtAddMailAdress);
            gbxAddInstructor.Controls.Add(txtAddSurname);
            gbxAddInstructor.Controls.Add(lblBirthDate);
            gbxAddInstructor.Controls.Add(dtpAddBirthDate);
            gbxAddInstructor.Controls.Add(txtAddName);
            gbxAddInstructor.Controls.Add(btnAddInstructor);
            gbxAddInstructor.Controls.Add(lblAddSurname);
            gbxAddInstructor.Controls.Add(lblAddMailAdress);
            gbxAddInstructor.Controls.Add(lblAddInstructorName);
            gbxAddInstructor.Location = new Point(12, 237);
            gbxAddInstructor.Name = "gbxAddInstructor";
            gbxAddInstructor.Size = new Size(375, 201);
            gbxAddInstructor.TabIndex = 4;
            gbxAddInstructor.TabStop = false;
            gbxAddInstructor.Text = "Eğitmen Ekle";
            // 
            // txtAddMailAdress
            // 
            txtAddMailAdress.Location = new Point(96, 165);
            txtAddMailAdress.Name = "txtAddMailAdress";
            txtAddMailAdress.Size = new Size(273, 27);
            txtAddMailAdress.TabIndex = 20;
            // 
            // txtAddSurname
            // 
            txtAddSurname.Location = new Point(97, 129);
            txtAddSurname.Name = "txtAddSurname";
            txtAddSurname.Size = new Size(125, 27);
            txtAddSurname.TabIndex = 19;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(6, 38);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(98, 20);
            lblBirthDate.TabIndex = 18;
            lblBirthDate.Text = "Doğum Tarihi";
            // 
            // dtpAddBirthDate
            // 
            dtpAddBirthDate.Location = new Point(119, 33);
            dtpAddBirthDate.Name = "dtpAddBirthDate";
            dtpAddBirthDate.Size = new Size(250, 27);
            dtpAddBirthDate.TabIndex = 17;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(97, 96);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(125, 27);
            txtAddName.TabIndex = 13;
            // 
            // btnAddInstructor
            // 
            btnAddInstructor.Location = new Point(228, 66);
            btnAddInstructor.Name = "btnAddInstructor";
            btnAddInstructor.Size = new Size(141, 93);
            btnAddInstructor.TabIndex = 12;
            btnAddInstructor.Text = "Ekle";
            btnAddInstructor.UseVisualStyleBackColor = true;
            btnAddInstructor.Click += btnAddInstructor_Click;
            // 
            // lblAddSurname
            // 
            lblAddSurname.AutoSize = true;
            lblAddSurname.Location = new Point(26, 132);
            lblAddSurname.Name = "lblAddSurname";
            lblAddSurname.Size = new Size(54, 20);
            lblAddSurname.TabIndex = 7;
            lblAddSurname.Text = "Soyadı";
            // 
            // lblAddMailAdress
            // 
            lblAddMailAdress.AutoSize = true;
            lblAddMailAdress.Location = new Point(6, 168);
            lblAddMailAdress.Name = "lblAddMailAdress";
            lblAddMailAdress.Size = new Size(84, 20);
            lblAddMailAdress.TabIndex = 6;
            lblAddMailAdress.Text = "Mail Adresi";
            // 
            // lblAddInstructorName
            // 
            lblAddInstructorName.AutoSize = true;
            lblAddInstructorName.Location = new Point(26, 96);
            lblAddInstructorName.Name = "lblAddInstructorName";
            lblAddInstructorName.Size = new Size(32, 20);
            lblAddInstructorName.TabIndex = 2;
            lblAddInstructorName.Text = "Adı";
            // 
            // dgwInstructor
            // 
            dgwInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwInstructor.Location = new Point(18, 43);
            dgwInstructor.Name = "dgwInstructor";
            dgwInstructor.RowHeadersWidth = 51;
            dgwInstructor.Size = new Size(632, 188);
            dgwInstructor.TabIndex = 5;
            dgwInstructor.CellClick += dgwInstructor_CellClick;
            // 
            // gbxUpdateInstructor
            // 
            gbxUpdateInstructor.Controls.Add(txtUpdateMailAdress);
            gbxUpdateInstructor.Controls.Add(txtUpdateSurname);
            gbxUpdateInstructor.Controls.Add(lblUpdateBirthDate);
            gbxUpdateInstructor.Controls.Add(dtpUpdateBirthDate);
            gbxUpdateInstructor.Controls.Add(txtUpdateName);
            gbxUpdateInstructor.Controls.Add(Update);
            gbxUpdateInstructor.Controls.Add(lblUpdateSurname);
            gbxUpdateInstructor.Controls.Add(llblUpdateMailAdress);
            gbxUpdateInstructor.Controls.Add(lblUpdateName);
            gbxUpdateInstructor.Location = new Point(393, 237);
            gbxUpdateInstructor.Name = "gbxUpdateInstructor";
            gbxUpdateInstructor.Size = new Size(373, 201);
            gbxUpdateInstructor.TabIndex = 21;
            gbxUpdateInstructor.TabStop = false;
            gbxUpdateInstructor.Text = "Eğitmen Güncelle";
            // 
            // txtUpdateMailAdress
            // 
            txtUpdateMailAdress.Location = new Point(96, 165);
            txtUpdateMailAdress.Name = "txtUpdateMailAdress";
            txtUpdateMailAdress.Size = new Size(264, 27);
            txtUpdateMailAdress.TabIndex = 20;
            // 
            // txtUpdateSurname
            // 
            txtUpdateSurname.Location = new Point(97, 129);
            txtUpdateSurname.Name = "txtUpdateSurname";
            txtUpdateSurname.Size = new Size(125, 27);
            txtUpdateSurname.TabIndex = 19;
            // 
            // lblUpdateBirthDate
            // 
            lblUpdateBirthDate.AutoSize = true;
            lblUpdateBirthDate.Location = new Point(6, 33);
            lblUpdateBirthDate.Name = "lblUpdateBirthDate";
            lblUpdateBirthDate.Size = new Size(98, 20);
            lblUpdateBirthDate.TabIndex = 18;
            lblUpdateBirthDate.Text = "Doğum Tarihi";
            // 
            // dtpUpdateBirthDate
            // 
            dtpUpdateBirthDate.Location = new Point(110, 28);
            dtpUpdateBirthDate.Name = "dtpUpdateBirthDate";
            dtpUpdateBirthDate.Size = new Size(250, 27);
            dtpUpdateBirthDate.TabIndex = 17;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(97, 96);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(125, 27);
            txtUpdateName.TabIndex = 13;
            // 
            // Update
            // 
            Update.Location = new Point(228, 66);
            Update.Name = "Update";
            Update.Size = new Size(132, 93);
            Update.TabIndex = 12;
            Update.Text = "Güncelle";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // lblUpdateSurname
            // 
            lblUpdateSurname.AutoSize = true;
            lblUpdateSurname.Location = new Point(26, 132);
            lblUpdateSurname.Name = "lblUpdateSurname";
            lblUpdateSurname.Size = new Size(54, 20);
            lblUpdateSurname.TabIndex = 7;
            lblUpdateSurname.Text = "Soyadı";
            // 
            // llblUpdateMailAdress
            // 
            llblUpdateMailAdress.AutoSize = true;
            llblUpdateMailAdress.Location = new Point(6, 168);
            llblUpdateMailAdress.Name = "llblUpdateMailAdress";
            llblUpdateMailAdress.Size = new Size(84, 20);
            llblUpdateMailAdress.TabIndex = 6;
            llblUpdateMailAdress.Text = "Mail Adresi";
            // 
            // lblUpdateName
            // 
            lblUpdateName.AutoSize = true;
            lblUpdateName.Location = new Point(26, 96);
            lblUpdateName.Name = "lblUpdateName";
            lblUpdateName.Size = new Size(32, 20);
            lblUpdateName.TabIndex = 2;
            lblUpdateName.Text = "Adı";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(656, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 93);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Instructors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(btnDelete);
            Controls.Add(gbxUpdateInstructor);
            Controls.Add(dgwInstructor);
            Controls.Add(gbxAddInstructor);
            Name = "Instructors";
            Text = "Instructor";
            Load += Instructors_Load;
            gbxAddInstructor.ResumeLayout(false);
            gbxAddInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwInstructor).EndInit();
            gbxUpdateInstructor.ResumeLayout(false);
            gbxUpdateInstructor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxAddInstructor;
        private TextBox txtAddName;
        private Button btnAddInstructor;
        private Label lblAddSurname;
        private Label lblAddMailAdress;
        private Label lblAddInstructorName;
        private Label lblBirthDate;
        private DateTimePicker dtpAddBirthDate;
        private TextBox txtAddMailAdress;
        private TextBox txtAddSurname;
        private DataGridView dgwInstructor;
        private GroupBox gbxUpdateInstructor;
        private TextBox txtUpdateMailAdress;
        private TextBox txtUpdateSurname;
        private Label lblUpdateBirthDate;
        private DateTimePicker dtpUpdateBirthDate;
        private TextBox txtUpdateName;
        private Button Update;
        private Label lblUpdateSurname;
        private Label llblUpdateMailAdress;
        private Label lblUpdateName;
        private Button btnDelete;
    }
}