using AttachedModeExample_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttachedModeExample_App.Mock
{
    // StudentsRepositoryStub - заглушка для IStudentsRepository, хранящая данные в RAM
    internal class StudentsRepositoryStub : IStudentsRepository
    {
        private static List<Student> students;
        private int nextId;

        public StudentsRepositoryStub()
        {
            students = new List<Student>();
            nextId = 1;
            // предзаполнение
            Add(new Student("Иванов", "Иван", 5, 1337));
            Add(new Student("Петрова", "Екатерина", 10, 1250));
            Add(new Student("Сидоров", "Михаил", 10, 100));
        }

        public void Add(Student student)
        {
            Student newStudent = new Student(student);
            newStudent.Id = nextId++;
            students.Add(newStudent);
        }

        public void Delete(int id)
        {
            Student deleted = students.First(s => s.Id == id);
            students.Remove(deleted);
        }

        public Student Get(int id)
        {
            return new Student(students.First(s => s.Id == id));
        }

        public List<Student> GetAll()
        {
            return students.Select(s => new Student(s)).ToList();
        }

        public void Update(Student student)
        {
            Student updated = students.First(s => s.Id == student.Id);
            updated.LastName = student.LastName;
            updated.FirstName = student.FirstName;
            updated.Rate = student.Rate;
            updated.Grants = student.Grants;
        }

        public void Dispose()
        {
            // 
        }

    }
}
