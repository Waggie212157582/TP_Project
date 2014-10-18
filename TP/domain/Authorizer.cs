using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP.Domain
{
    public class Authorizer
    {
        public virtual long id { get; set; }
        public virtual String authCode { get; set; }
        public virtual String secQuestion { get; set; }
        public virtual String secAnswer { get; set; }
        public virtual String empNo { get; set; }
    }
}
