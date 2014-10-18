using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class PatientAddress
    {
        public virtual long id { get; set; }
        public virtual String patientNum { get; set; }
        public virtual String streetNameNo { get; set; }
        public virtual String suburb { get; set; }
        public virtual String city { get; set; }
        public virtual String postalCode { get; set; }
        public virtual String addressType { get; set; }
    }
}
