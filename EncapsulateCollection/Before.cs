using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateCollection
{
    public class Before
    {
        private List<Person> _students;

        public List<Person> Students
        {
            get { return _students;}
        }

        public void Insert(Person student)
        {
            _students.Add(student);
        }

        public void Delete(Person student)
        {
            if (_students.Contains(student))
            {
                _students.Remove(student);
            }
        }
    }

    public class Person
    {
    
    }
}
