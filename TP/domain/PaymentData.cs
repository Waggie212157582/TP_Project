using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class PaymentData
    {
        public virtual long id { get; set; }
        public virtual String paymentRefNo { get; set; }
        public virtual String paymentDate { get; set; }
        public virtual String paymentTime { get; set; }
        public virtual Int32 numberOfProcedures { get; set; }
        public virtual Double tax { get; set; }
        public virtual Double total { get; set; }
        public virtual Double changes { get; set; }
    }
}
