using System;
using System.Collections.Generic;

namespace StudentID_Unique_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student(1, "Haris", "Zikos", 37);
            Student s2 = new Student(2, "john", "wright", 28);
            Student s3 = new Student(3, "Mary", "Smith", 33);
            Student s4 = new Student(4, "Helen", "Crane", 31);
            Student s5 = new Student(4, "Helen", "Crane", 31);


            IEqualityComparer<Student> comparer = new StudentComparer();

            Dictionary<Student, int> dictionary = new Dictionary<Student, int>(comparer);

            dictionary[s1] = 4;
            dictionary[s2] = 7;
            dictionary[s3] = 8;
            dictionary[s4] = 10;
            dictionary[s5] = 15;


            foreach (var KeyValuePair in dictionary)
            {
                Console.WriteLine($"{KeyValuePair.Key} --- {KeyValuePair.Value}");
            }


            
        }
    }


}
