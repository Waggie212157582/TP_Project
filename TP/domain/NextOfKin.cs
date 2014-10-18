using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class NextOfKin
    {
        public virtual long id { get; set; }
        public virtual String kinSurname { get; set; }
        public virtual String kinName { get; set; }
        public virtual String kinAddress { get; set; }
        public virtual String kinTelNo { get; set; }
        public virtual String kinRelationship { get; set; }
        public virtual String patientNum { get; set; }
    }
}
