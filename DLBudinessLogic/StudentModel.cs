using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLBudinessLogic
{
    [Table("student", Schema ="public")]
    public class StudentModel
    {
        [Key]
        public int sid { get; set; }
        public string sname { get; set; }
    }
}
