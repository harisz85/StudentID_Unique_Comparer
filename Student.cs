using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentID_Unique_Comparer
{
   public class Student
   {
       public int StudentNumber  { get; set; }

       public string FirstName { get; set; }

       public string LastName { get; set; }


       public int Age { get; set; }


       public Student(int studentNumber, string firstname, string lastname, int age)
       {
           this.StudentNumber = studentNumber;
           this.FirstName = firstname;
           this.LastName = lastname;
           this.Age = age;

       }

       public override string ToString()
       {    
           return string.Format($" StudentNumber = {this.StudentNumber}  \t Firstname = {this.FirstName} \t Lastname = {this.LastName} \t Age ={this.Age}");
       }
   }
}
