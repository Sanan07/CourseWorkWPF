using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test
    {
        private Context db;
        public Test()
        {
            InitializeComponent();


            db= new Context();

            comboBox.ItemsSource = db.EquipmentMakers.ToList();
            //comboBox.SelectedItem = db.EquipmentMakers.ToList().get;
        }

      
    }
}
