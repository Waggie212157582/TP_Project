using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP.Domain
{
    public class MedicalHistory
    {
        public virtual long MedHistId { get; set; }
        public virtual String patientNum { get; set; }
        public virtual Boolean rheumaticFever { get; set; }
        public virtual String ifYesRhemDate { get; set; }
        public virtual Boolean diabetic { get; set; }
        public virtual Boolean pophyris { get; set; }
        public virtual Boolean recentIllnesses { get; set; }
        public virtual Boolean bleeder { get; set; }
        public virtual String additionalInfo { get; set; }
        public virtual ISet<Treatment> treatments { get; set; }
        public virtual ISet<Allergy> allergies { get; set; }
    }
}
