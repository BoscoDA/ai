using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMorgan
{
    internal class Proposition
    {
        public bool p { get; set; }
        public bool q { get; set; }
        public bool result { get; set; }

        public Proposition(bool p, bool q, bool result)
        {
            this.p = p;
            this.q = q;
            this.result = result;
        }

        public int GetP()
        {
            return p ? 1 : 0;
        }

        public int getQ()
        {
            return q ? 1 : 0;
        }
    }
}
