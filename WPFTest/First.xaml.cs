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

namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для First.xaml
    /// </summary>
    public partial class First : MetroWindow
    {

        private bool clicked;
        private string name;

    
        public First()
        {
            InitializeComponent();
        }

        private void tile_Click(object sender, RoutedEventArgs e)
        {
            clicked = true;
            name = tile.Title;
            Close();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (clicked)
            {
                MainWindow main = new MainWindow();
            
                int i = 0;
               
                /*Находим индекс в таб контроле*/
                foreach (TabItem v in main.TabControl.Items)
                {
                    if (name.Equals(v.Header.ToString()))
                    {
                        break;
                    }
                    i++;
                }
              
                /*Открываем выбраный Tabindex*/
                Dispatcher.BeginInvoke((Action)(() => main.TabControl.SelectedIndex = i));
                main.Show();
            }
            
        }

        private void tile1_Click(object sender, RoutedEventArgs e)
        {
            clicked = true;
            name = tile1.Title;
            Close();
        }

        private void tile2_Click(object sender, RoutedEventArgs e)
        {
            clicked = true;
            name = tile2.Title;
            Close();
        }

        private void tile3_Click(object sender, RoutedEventArgs e)
        {
            clicked = true;
            name = tile3.Title;
            Close();
        }

        private void tile3_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }
    }
}
