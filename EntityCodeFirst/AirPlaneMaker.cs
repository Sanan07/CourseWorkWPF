using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst
{
    class AirPlaneMaker
    {
        public int ID { get; set; }
        public string AirPlaneMakerName { get; set; }

        public virtual ICollection<AirPlane> AirPlanes { get; set; }

        public AirPlaneMaker()
        {
            AirPlanes = new List<AirPlane>();
        }

        public override string ToString()
        {
            return AirPlaneMakerName;
        }
    }
}
