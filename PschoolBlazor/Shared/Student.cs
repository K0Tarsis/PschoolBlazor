using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PschoolBlazor.Shared
{
    public class Student : ICloneable
    {
        [Required(ErrorMessage ="Set first name please.")]
        public string FirstName { get; set; }=string.Empty;
        [Required(ErrorMessage = "Set last name please.")]
        public string LastName { get; set; } = string.Empty;
        public Parent Parent { get; set; }
        public Student() { }
        public Student(string firstName, string lastName, Parent parent)
        {
            FirstName = firstName;
            LastName = lastName;
            Parent = parent;
            parent.Students.Add(this);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
