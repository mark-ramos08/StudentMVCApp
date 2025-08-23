using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMVCApp.Model;


namespace StudentMVCApp.Controller
{
    public class StudentController
    {
        private readonly StudentRepository _repository;

        public StudentController(StudentRepository repositoty)
        {
            _repository = repositoty;
        }

       
        public string AddStudent(Student student)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(student.Fullname))
                    return "Full Name is required. ";

                if (student.Age <= 0)
                    return "Age must be greater than zero. ";

                _repository.AddStudent(student);
                return "Student added successfully.";

            }
            catch (Exception ex)
            {
                return $"Error adding the student: {ex.Message}";
            }
        }

        public string UpdateStudent(Student student)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(student.Fullname))
                    return "Full Name is required. ";
                if (student.Age <= 0)
                    return "Age must be greater than zero. ";
                _repository.UpdateStudent(student);
                return "Student updated successfully.";
            }
            catch (Exception ex)
            {
                return $"Error updating the student: {ex.Message}";
            }
        }
        
        public string DeleteStudent(int studentId)
        {
            try
            {
                _repository.DeleteStudent(studentId);
                return "Student deleted successfully.";
            }
            catch (Exception ex)
            {
                return $"Error deleting the student: {ex.Message}";
            }
        }

        public Student Studentbyname(string fullname)
        {
            try
            {
                return _repository.GetAllStudents().FirstOrDefault(s => s.Fullname.Equals(fullname, StringComparison.OrdinalIgnoreCase));
            }
            catch
            {
                return null;
            }
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                return _repository.GetAllStudents();
            }
            catch
            {
                return new List<Student>();
            }
        }
    }
}
