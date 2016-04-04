using System;
using System.Windows;
using System.Windows.Controls;
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

        private void tile4_Click(object sender, RoutedEventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
            Close();
        
        }
    }
}
