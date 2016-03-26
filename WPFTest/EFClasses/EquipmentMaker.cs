using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
   public class EquipmentMaker
    {
        public int ID { get; set; }
        public string MakerName { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }

        public EquipmentMaker()
        {
            Equipments = new List<Equipment>();
        }

        public override string ToString()
        {
            return MakerName;
        }
    }
}
