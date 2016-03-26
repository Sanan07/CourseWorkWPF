using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
 public   class Flight
    {
        public int ID { get; set; }
        public string NameOfFlight { get; set; }
        public DateTime DateOfFlight { get; set; }

        public int? AirPlaneID { get; set; }
        public virtual AirPlane AirPlane { get; set; }

        public int? CrewID { get; set; }
        public virtual Crew Crew { get; set; }

    }
}
