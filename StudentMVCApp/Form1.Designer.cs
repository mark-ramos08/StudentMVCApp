namespace StudentMVCApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAge = new TextBox();
            btnAdd = new Button();
            btnViewAll = new Button();
            lstStudents = new ListBox();
            txtSearchBar = new TextBox();
            label3 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(103, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 1;
            label1.Text = "FullName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 2;
            label2.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(103, 72);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(55, 27);
            txtAge.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(175, 71);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.BackColor = Color.Moccasin;
            btnViewAll.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewAll.ForeColor = Color.Black;
            btnViewAll.Location = new Point(428, 412);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(146, 27);
            btnViewAll.TabIndex = 5;
            btnViewAll.Text = "View All Student";
            btnViewAll.UseVisualStyleBackColor = false;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // lstStudents
            // 
            lstStudents.ForeColor = SystemColors.MenuText;
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(355, 62);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(309, 344);
            lstStudents.TabIndex = 6;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(84, 150);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(226, 27);
            txtSearchBar.TabIndex = 7;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 8;
            label3.Text = "Search:";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkOrange;
            btnEdit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(12, 194);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit Student";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(176, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(355, 33);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 11;
            label4.Text = "Student List:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(682, 450);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label3);
            Controls.Add(txtSearchBar);
            Controls.Add(lstStudents);
            Controls.Add(btnViewAll);
            Controls.Add(btnAdd);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtAge;
        private Button btnAdd;
        private Button btnViewAll;
        private ListBox lstStudents;
        private TextBox txtSearchBar;
        private Label label3;
        private Button btnEdit;
        private Button btnDelete;
        private Label label4;
    }
}
