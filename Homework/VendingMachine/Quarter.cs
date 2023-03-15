using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Quarter : OutputBase
    {
        private static Quarter instance = null;

        private Quarter()
        {
            Name = "QUARTER";
            Value = 0.25M;
        }

        public static Quarter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Quarter();
                }
                return instance;
            }
        }
    }
}
