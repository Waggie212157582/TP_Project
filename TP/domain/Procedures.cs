using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class Procedures
    {
        public virtual long id {get;set;}
        public virtual int procedureCode { get; set; }
        public virtual String procedureName { get; set; }
        public virtual Double procedurePrice { get; set; }
        
    }
}
