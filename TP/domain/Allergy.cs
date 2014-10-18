using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class Allergy
    {
        public virtual long id { get; set; }
        public virtual String AllName { get; set; }
        public virtual Boolean AllIsSerious { get; set; }
        public virtual long MedHistId { get; set; }
    }
}
