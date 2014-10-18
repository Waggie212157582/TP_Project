using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
   public class Employee
    {
       public virtual long id { get; set; }
       public virtual String empNo { get; set; }
       public virtual String empId { get; set; }
       public virtual String empName { get; set; }
       public virtual String empSurname { get; set; }
       public virtual String empGender { get; set; }
       public virtual String empAddress { get; set; }
       public virtual String jobTitle { get; set; }
       public virtual String empType { get; set; }

    }
}
