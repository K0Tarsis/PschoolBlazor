using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PschoolBlazor.Shared
{
    public class Parent : ICloneable
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Set first name please.")]
        public string FirstName { get; set; }=string.Empty;
        [Required(ErrorMessage = "Set last name please.")]
        public string LastName { get; set; } = string.Empty;
        public string? Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Set email please.")]
        public string Email { get; set; } = string.Empty;
        public string? HomeAddress { get; set; } = string.Empty;
        public string? Phone1 { get; set; } = string.Empty;
        public string? WorkPhone { get; set; } = string.Empty;
        public string? HomePhone { get; set; } = string.Empty;
        public List<Student>? Students { get; set; }=new List<Student>();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
