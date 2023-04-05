using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Class.Models
{
    internal class University
    {
        private Student[] students;
        public int Id { get; set; }
        public string Name { get; set; }
        public Student[] Students { get 
            {
                return students;
            } set
            {
                students = value;
            }
        }
        public University(int id,string name)
        {

            Id = id;
            Name = name;
            Students=new Student[0];

        }
        public void AddStudent(Student student)
        {
            Array.Resize( ref students, Students.Length+1);
            Students[Students.Length-1] = student;

        }

    }
}
