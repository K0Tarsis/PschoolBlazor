using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PschoolBlazor.Shared
{
    public class AppState
    {
        public IdGenerator ParentIdGenerator;
        public Parent Parent { get; set; }
        public Student Student { get; set; }

        private Parent p1;
        private Parent p2;
        private Parent p3;
        private Parent p4;
        private Student s1;
        private Student s2;
        private Student s3;
        private Student s4;
        public List<Parent> Parents;
        /*{
        new Parent() { FirstName = "Alex", LastName = "Alph", Email = "em1@gmail.com" },
        new Parent() { FirstName = "Bob", LastName = "Brown", Email = "em2@gmail.com" },
        new Parent() { FirstName = "Charle", LastName = "Clin", Email = "em3@gmail.com", Phone1 = "0555555555" },
        new Parent() { FirstName = "Den", LastName = "Dong", Email = "em4@gmail.com" },
        };*/
        public List<Student> Students;
        public AppState()
        {
            ParentIdGenerator=new IdGenerator();
            Parents = new List<Parent>();
            Students = new List<Student>();
            p1 = new Parent() { FirstName = "Alex", LastName = "Alph", Email = "em1@gmail.com", Id = ParentIdGenerator.SetId() };
            p2 = new Parent() { FirstName = "Bob", LastName = "Brown", Email = "em2@gmail.com", Id = ParentIdGenerator.SetId() };
            p3 = new Parent() { FirstName = "Charlie", LastName = "Clin", Email = "em3@gmail.com", Phone1 = "0555555555", Id = ParentIdGenerator.SetId() };
            p4 = new Parent() { FirstName = "Den", LastName = "Dong", Email = "em4@gmail.com", Id = ParentIdGenerator.SetId() };
            Parents.Add(p1);
            Parents.Add(p2);
            Parents.Add(p3);
            Parents.Add(p4);

            s1 = new Student("Alice", "Alph", p1);
            s2 = new Student("Ben", "Brown", p2);
            s3 = new Student("Charlie", "Clin", p3);
            s4 = new Student("Clint", "Clin", p3);
            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);
        }
    }
}
