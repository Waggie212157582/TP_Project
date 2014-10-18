using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP.Domain
{
    public class TerminalUser
    {
        public virtual long id { get; set; }
        public virtual int idx { get; set; }
        public virtual String empNo { get; set; }
        public virtual String userName { get; set; }
        public virtual String password { get; set; }
        public virtual String secQuestion { get; set; }
        public virtual String secAnswer { get; set; }
    }
}
