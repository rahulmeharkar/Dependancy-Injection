using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLBudinessLogic
{
    public interface IContract
    {
        List<StudentModel> displayStudent();
        int addStudent(string sname);
        bool deletestudent(int sid);

        int updateStudent(int sid,string sname);
    }
}
