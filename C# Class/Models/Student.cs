using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Class
{
    internal class Student
    {
        public int Id;
        private string _name;
        private string _surname;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 3)
                {
                    _name = value;

                }
            }
        }
        public string Surname { get
            {
                return _surname;
            }
            set 
            {if (value.Length > 3)
                  _surname = value;
            } }
        public Student(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
