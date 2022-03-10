using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace StudentID_Unique_Comparer
{
    public class StudentComparer : IEqualityComparer<Student>
    {

        public bool Equals(Student student1, Student student2)
        {
            if (student1 == student2) return true;


            if (student1 == null || student2 == null) return false;

            if (!student1.StudentNumber.Equals(student2.StudentNumber))
            {
                return false;
            }

            if (!student1.FirstName.Equals(student2.FirstName))
            {
                return false;
            }


            if (!student1.LastName.Equals(student2.LastName))
            {
                return false;
            }

            if (!student1.Age.Equals(student2.Age))
            {
                return false;
            }

            return true;

        }


        public int GetHashCode(Student obj)
        {
            Student student = obj as Student;


            if (student == null)
            {
                return 0;

            }


            int code = 97; // prime number

            int result = 1;

            unchecked
            {
                result = result * code + student.StudentNumber.GetHashCode();
                result = result * code + student.FirstName.GetHashCode();
                result = result * code + student.LastName.GetHashCode();
                result = result * code + student.Age.GetHashCode();
            }

            return result;
        }
    }
}
