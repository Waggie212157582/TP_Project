using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class Payment
    {
        public virtual long id { get; set; }
        public virtual String patientNum { get; set; }
        public virtual String paySurname { get; set; }
        public virtual String payName { get; set; }
        public virtual long payIdNumber { get; set; }
        public virtual String payAddress { get; set; }
        public virtual String payTelNo { get; set; }
        public virtual String payTelNoWork { get; set; }
        public virtual String payRelationship { get; set; }
        public virtual String payOccupation { get; set; }
    }
}
