using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyAmbulance_WF
{
    class dataEmergencia
    {
        public long idEmergencia { get; set; }
        public string nombreEmergencia { get; set; }
        public double longitudEmergencia { get; set; }
        public double latitudEmergencia { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", idEmergencia, nombreEmergencia);
        }
    }
}
