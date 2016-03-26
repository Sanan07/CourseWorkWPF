using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
   public  class AirPlane
    {
        public int ID { get; set; }
        public string AirPlaneName { get; set; }
        public int Year { get; set; }
        public int Amount { get; set; }


        public int? AirPlaneMakerID { get; set; }
        public virtual AirPlaneMaker AirPlaneMaker { get; set; }
        

        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }


        public AirPlane()
        {
            Flights = new List<Flight>();
        }

        
        public override string ToString()
        {
            return AirPlaneName;
        }
    }
}
