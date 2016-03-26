using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFTest.Annotations;


namespace WPFTest
{
  public class Equipment
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
