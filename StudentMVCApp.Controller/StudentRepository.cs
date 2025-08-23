using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMVCApp.Model;


namespace StudentMVCApp.Controller
{
    public class StudentRepository
    {
        private List<Student> _students = new List<Student>();
        
        public void AddStudent(Student student)
        {
           _students.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);
            if (existingStudent != null)
            {
                existingStudent.Fullname = student.Fullname;
                existingStudent.Age = student.Age;
            }
        }
        public void DeleteStudent(int studentId)
        {
            var student = _students.FirstOrDefault(s => s.Id == studentId);
            if (student != null)
            {
                _students.Remove(student);
            }
        }
        public Student GetStudentByName(string fullname)
        {
            return _students.FirstOrDefault(s => s.Fullname.Equals(fullname, StringComparison.OrdinalIgnoreCase));
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }
    }
}
