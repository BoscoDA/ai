using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachineAssignment
{
    public class Gum : OutputBase
    {
        private static Gum instance = null;

        private Gum()
        {
            Name = "GUM";
            Value = 0.50M;
        }

        public static Gum Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Gum();
                }
                return instance;
            }
        }
    }
}
