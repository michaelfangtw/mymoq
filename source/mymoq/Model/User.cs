using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mymoq.Model
{
    public class User
    {
        public long UserID { get; set; }
        public string? UserName { get; set; }    
        public string? Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
