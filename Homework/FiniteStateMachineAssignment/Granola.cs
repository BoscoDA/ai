using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachineAssignment
{
    public class Granola : OutputBase
    {
        private static Granola instance = null;

        private Granola()
        {
            Name = "GRANOLA";
            Value = 0.75M;
        }

        public static Granola Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Granola();
                }
                return instance;
            }
        }
    }
}
