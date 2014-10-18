using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class Appointment
    {
        public virtual long id { get; set; }
        public virtual String appId { get; set; }
        public virtual String reasonForVisit { get; set; }
        public virtual String appDate { get; set; }
        public virtual String appTime { get; set; }
        public virtual String patientNum { get; set; }
    }
}
