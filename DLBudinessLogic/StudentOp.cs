using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLBudinessLogic
{
    public class StudentOp : IContract
    {
        readonly DBEntity db;
        public StudentOp(DBEntity dBEntity)
        {
            db = dBEntity;
        }
        public int addStudent(string sname)
        {
            StudentModel sm = new StudentModel()
            {
                sname = sname
            };
            db.StudentEntity.Add(sm);
            int i =db.SaveChanges();
            return i;
        }

        public bool deletestudent(int sid)
        {
            StudentModel sm = new StudentModel()
            {
                sid = sid
            };
            db.StudentEntity.Remove(sm);
            int i = db.SaveChanges();
            var result =  (i>0) ?  true : false;
            return result;
        }

        public List<StudentModel> displayStudent()
        {
            List<StudentModel> sm = new List<StudentModel>();
            var stud = (from students in db.StudentEntity.ToList()
                        select new
                        {
                            sid = students.sid,
                            sname = students.sname
                        }).ToList();
            foreach(var item in stud)
            {
                var student = new StudentModel();
                student.sid = item.sid;
                student.sname = item.sname;
                sm.Add(student);
            }
            return sm;
        }

        public int updateStudent(int sid, string sname)
        {
            var stud = db.StudentEntity.Where(x => x.sid == sid).FirstOrDefault();
            stud.sname = sname;
            int i = db.SaveChanges();
            return i;
        }
    }
}
