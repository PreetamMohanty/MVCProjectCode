using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject2.Models
{
    public class EmpDept
    {
        Employee e1 = new Employee();
        public string FirstName
        {
            get { return e1.FirstName; }
            set { e1.FirstName = value; }
        }

        Department d1 = new Department();
        public string DeptName
        {
            get { return d1.DeptName; }
            set { d1.DeptName = value; }
        }
    }
}