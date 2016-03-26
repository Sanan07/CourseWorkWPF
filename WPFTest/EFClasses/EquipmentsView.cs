using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.EFClasses
{
    class EquipmentsView
    {
        private ObservableCollection<Equipment> equipments = new ObservableCollection<Equipment>();

        public ObservableCollection<Equipment> Equipments
        {
            get { return equipments; }
            set { equipments = value; }
        }
    }
}
