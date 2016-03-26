using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityCodeFirst
{
    class Equipment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public int? EquipmentMakerID { get; set; }
        public virtual EquipmentMaker EquipmentMaker { get; set; }

        public int? AirPlaneID { get; set; }
        public virtual AirPlane AirPlane { get; set; }
    }
}
