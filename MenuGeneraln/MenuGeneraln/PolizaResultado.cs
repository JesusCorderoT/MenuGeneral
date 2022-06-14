using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneraln
{
    public struct PolizaResultado
    {

        public PolizaResultado(DateTime FechaTermino,decimal Prima) {

            FT = FechaTermino;
            PR = Prima;
        
        }
        public DateTime FT { get; set; }
        public decimal PR { get; set; }

    }
}
