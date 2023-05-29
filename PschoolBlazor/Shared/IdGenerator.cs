using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PschoolBlazor.Shared
{
    public class IdGenerator
    {
        private int Id { get; set; }
        public IdGenerator()
        {
            Id = 0;
        }
        public int SetId() {
            return Id++;
        }
    }
}
