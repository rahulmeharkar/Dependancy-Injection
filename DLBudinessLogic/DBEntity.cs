using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLBudinessLogic
{
    public class DBEntity : DbContext
    {
        public DBEntity() : base(nameOrConnectionString: "DBConnection") {}
        public virtual DbSet<StudentModel> StudentEntity { get; set; }
    }
}
