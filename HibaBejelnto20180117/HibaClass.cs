using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HibaBejelnto20180117
{
    class HibaClass
    {
        private string nev;
        private DateTime bejelentesDatum;
        private string hibaLeiras;

        public HibaClass(string nev, DateTime bejelentesDatum, string hibaLeiras)
        {
            this.nev = nev;
            this.bejelentesDatum = bejelentesDatum;
            this.hibaLeiras = hibaLeiras;
        }
    }
}
