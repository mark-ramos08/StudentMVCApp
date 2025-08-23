using StudentMVCApp.Controller;
using StudentMVCApp.Model;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace StudentMVCApp
{
    public partial class Form1 : Form
    {
        private readonly StudentController _controller;
        public Form1()
        {
            InitializeComponent();
            _controller = new StudentController(new StudentRepository());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Student = new Student
            {
                Id = DateTime.Now.Millisecond,
                Fullname = txtName.Text,
                Age = int.TryParse(txtAge.Text, out int age) ? age : 0
            };

            string result = _controller.AddStudent(Student);
            MessageBox.Show(result);
            txtName.Clear();
            txtAge.Clear();
            /*btnViewAll_Click(sender, e);*/
        }



        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();

            var students = _controller.GetAllStudents();
            foreach (var student in students)
            {
                lstStudents.Items.Add($"{student.Id} - {student.Fullname}, Age: {student.Age}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = lstStudents.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }
            var parts = selectedItem.ToString().Split(new[] { '-' }, 2);
            if (parts.Length < 2)
            {
                MessageBox.Show("Invalid student selection.");
                return;
            }
            int studentId = int.Parse(parts[0].Trim());
            var student = new Student
            {
                Id = studentId,
                Fullname = txtName.Text,
                Age = int.TryParse(txtAge.Text, out int age) ? age : 0
            };
            string result = _controller.UpdateStudent(student);
            MessageBox.Show(result);
            btnViewAll_Click(sender, e);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = lstStudents.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }
            var parts = selectedItem.ToString().Split(new[] { '-' }, 2);
            if (parts.Length < 2)
            {
                MessageBox.Show("Invalid student selection.");
                return;
            }
            int studentId = int.Parse(parts[0].Trim());
            string result = _controller.DeleteStudent(studentId);
            MessageBox.Show(result);
            btnViewAll_Click(sender, e);
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {

            lstStudents.Items.Clear();
            string searchText = txtSearchBar.Text.ToLower();
            var students = _controller.GetAllStudents();
            foreach (var student in students)
            {
                if (student.Fullname.ToLower().Contains(searchText))
                {
                    lstStudents.Items.Add($"{student.Id} - {student.Fullname}, Age: {student.Age}");
                }
            }
            if (lstStudents.Items.Count == 0)
            {
                lstStudents.Items.Add("No students found.");
            }
        }
    }
}

