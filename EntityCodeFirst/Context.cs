using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityCodeFirst
{
    class Context:DbContext
    {
        public Context() : base("Context"){}

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentMaker> EquipmentMakers { get; set; }
        public DbSet<AirPlane> AirPlanes { get; set; }
        public DbSet<AirPlaneMaker> AirPlaneMakers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Crew> Crews { get; set; }
    }
}
