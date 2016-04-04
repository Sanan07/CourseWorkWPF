using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
 public  class Crew
    {
        public int ID { get; set; }
        public string HeadOfCrew { get; set; }
        public string SecondPilot { get; set; }
        public string HeadOfStuard { get; set; }
        public int Amount { get; set; }
      

        public ICollection<Flight> Flights { get; set; }

        public Crew()
        {
            Flights = new List<Flight>();
        }

        public override string ToString()
        {
            return HeadOfCrew;
        }

       
    }
}
