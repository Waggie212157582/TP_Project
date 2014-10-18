using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class Treatment
    {
        public virtual long treatID { get; set; }
        public virtual int treatCode { get; set; }
        public virtual String treatName { get; set; }
        public virtual Boolean treatIsUrgent { get; set; }
        public virtual long MedHistId { get; set; }
    }
}
