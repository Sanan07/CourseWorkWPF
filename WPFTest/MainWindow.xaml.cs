using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows;

using WPFTest.EFClasses;


namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        private static Context db = new Context();
        
        public MainWindow()
        {
            InitializeComponent();

            RefreshData();
         
            //this.DataContext= new EquipmentsView();
         
        }

        private void RefreshData()
        {
            db.EquipmentMakers.Load();
            db.Equipments.Load();
            db.AirPlanes.Load();
            db.AirPlaneMakers.Load();
            db.Flights.Load();
            db.Crews.Load();

            dataGrid1.ItemsSource = db.Equipments.Local.ToBindingList();
            dataGrid1.Items.Refresh();

            dataGrid2.ItemsSource = db.AirPlanes.Local.ToBindingList();
            dataGrid2.Items.Refresh();

            dataGrid3.ItemsSource = db.Flights.Local.ToBindingList();
            dataGrid3.Items.Refresh();

            dataGrid4.ItemsSource = db.Crews.Local.ToBindingList();
            dataGrid4.Items.Refresh();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

                    /*-----------------------Оборудование-----------------------*/

        // Добавить новую запись (Оборудование)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEquipment addEq = new AddEquipment();

            // из команд в бд формируем список
            List<EquipmentMaker> makers = db.EquipmentMakers.ToList();
            addEq.comboBox1.ItemsSource = makers;
            addEq.comboBox1.SelectedValue = "Id";
            addEq.comboBox1.DisplayMemberPath = "MakerName";

            List<AirPlane> airPlanes = db.AirPlanes.ToList();
            addEq.comboBox2.ItemsSource = airPlanes;
            addEq.comboBox2.SelectedValue = "Id";
            addEq.comboBox2.DisplayMemberPath = "AirPlaneName";

            
            bool? b = addEq.ShowDialog();

            System.Windows.Forms.DialogResult result;

            if (b == true)
            {
                result= System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                result = System.Windows.Forms.DialogResult.Cancel;
            }

          
            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;
                
                Equipment equipment = new Equipment();

                equipment.Amount = (int) addEq.numericUpDown1.Value;
                equipment.Name = addEq.textBox1.Text;
                equipment.EquipmentMaker = (EquipmentMaker) addEq.comboBox1.SelectedItem;
                equipment.AirPlane = (AirPlane) addEq.comboBox2.SelectedItem;

                db.Equipments.Add(equipment);
                db.SaveChanges();
            
        }
        // Изменить запись (Оборудование)
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (dataGrid1.SelectedIndex >= 0)
            {
                Equipment eq = dataGrid1.SelectedItem as Equipment;
             
                AddEquipment addEq = new AddEquipment();

                addEq.textBox1.Text = eq.Name;
                addEq.numericUpDown1.Value = eq.Amount;

     
                // из команд в бд формируем список
                List<EquipmentMaker> makers = db.EquipmentMakers.ToList();

                // заполнение комбобокса веми элементамми
                addEq.comboBox1.ItemsSource = makers;
                addEq.comboBox1.SelectedValue = "Id";
                addEq.comboBox1.DisplayMemberPath = "MakerName";

                // показ выделенного названия
                int index = makers.IndexOf(eq.EquipmentMaker);
                addEq.comboBox1.SelectedItem = makers[index];

                // заполнение комбобокса веми элементамми 
                List<AirPlane> airPlanes = db.AirPlanes.ToList();
                addEq.comboBox2.ItemsSource = airPlanes;
                addEq.comboBox2.SelectedValue = "Id";
                addEq.comboBox2.DisplayMemberPath = "AirPlaneName";

                // показ выделенного названия
                index = airPlanes.IndexOf(eq.AirPlane);
                addEq.comboBox2.SelectedItem = airPlanes[index];



                //if (eq.EquipmentMaker != null)
                //{
                //    addEq.comboBox1.SelectedValue = eq.EquipmentMaker.ID;
                //}

                //if (eq.AirPlane != null)
                //{
                //    addEq.comboBox2.SelectedValue = eq.AirPlane.ID;
                //}


                bool? b = addEq.ShowDialog();

                System.Windows.Forms.DialogResult result;

                if (b == true)
                {
                    result = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    result = System.Windows.Forms.DialogResult.Cancel;
                }


                if (result == System.Windows.Forms.DialogResult.Cancel)
                    return;

               
                eq.Amount = (int)addEq.numericUpDown1.Value;
                eq.Name = addEq.textBox1.Text;
                eq.EquipmentMaker = (EquipmentMaker)addEq.comboBox1.SelectedItem;
                eq.AirPlane = (AirPlane)addEq.comboBox2.SelectedItem;

                db.Entry(eq).State = EntityState.Modified;
                db.SaveChanges();

                RefreshData();
            }
        }
        // Удалить запись (Оборудование)
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedIndex > 0)
            {
                Equipment eq = dataGrid1.SelectedItem as Equipment;
                //int index = (int) eq.ID;

                db.Equipments.Remove(eq);
                db.SaveChanges();
            }
        }

                     /*-----------------------САМОЛЕТЫ-----------------------*/

        // Добавить новую (Самолеты)
        private void addAB_Click(object sender, RoutedEventArgs e)
        {
            AddAirPlane addAirPlane = new AddAirPlane();

            // из команд в бд формируем список
            List<AirPlaneMaker> makers = db.AirPlaneMakers.ToList();
            addAirPlane.comboBox3.ItemsSource = makers;
            addAirPlane.comboBox3.SelectedValue = "Id";
            addAirPlane.comboBox3.DisplayMemberPath = "AirPlaneMakerName";

          

            bool? b = addAirPlane.ShowDialog();

            System.Windows.Forms.DialogResult result;

            if (b == true)
            {
                result = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                result = System.Windows.Forms.DialogResult.Cancel;
            }


            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;

            AirPlane airPlane = new AirPlane();

            airPlane.AirPlaneName = addAirPlane.textBox2.Text;
            airPlane.AirPlaneMaker = (AirPlaneMaker) addAirPlane.comboBox3.SelectedItem;
            airPlane.Year = int.Parse(addAirPlane.textBox3.Text);
            airPlane.Amount = (int) addAirPlane.numericUpDown2.Value;



            db.AirPlanes.Add(airPlane);
            db.SaveChanges();

            
        }
        // Изменить запись (Самолеты)
        private void editAB_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid2.SelectedIndex >= 0)
            {
                AirPlane airPlane = dataGrid2.SelectedItem as AirPlane;

                AddAirPlane addAirPlane = new AddAirPlane();

                addAirPlane.textBox2.Text = airPlane.AirPlaneName;
                addAirPlane.numericUpDown2.Value = airPlane.Amount;
                addAirPlane.textBox3.Text = airPlane.Year.ToString();


                // из команд в бд формируем список

                List<AirPlaneMaker> makers = db.AirPlaneMakers.ToList();
                addAirPlane.comboBox3.ItemsSource = makers;
                addAirPlane.comboBox3.SelectedValue = "Id";
                addAirPlane.comboBox3.DisplayMemberPath = "AirPlaneMakerName";

                // показ выделенного названия
                int index = makers.IndexOf(airPlane.AirPlaneMaker);
                addAirPlane.comboBox3.SelectedItem = makers[index];


                bool? b = addAirPlane.ShowDialog();

                System.Windows.Forms.DialogResult result;

                if (b == true)
                {
                    result = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    result = System.Windows.Forms.DialogResult.Cancel;
                }


                if (result == System.Windows.Forms.DialogResult.Cancel)
                    return;

                airPlane.AirPlaneName = addAirPlane.textBox2.Text;
                airPlane.AirPlaneMaker = (AirPlaneMaker)addAirPlane.comboBox3.SelectedItem;
                airPlane.Year = int.Parse(addAirPlane.textBox3.Text);
                airPlane.Amount = (int)addAirPlane.numericUpDown2.Value;



                db.Entry(airPlane).State = EntityState.Modified;
                db.SaveChanges();

                RefreshData();
            }
           
        }
        // Удаление (Самолеты)
        private void delAB_Click(object sender, RoutedEventArgs e)
        {

            if (dataGrid2.SelectedIndex > 0)
            {
                AirPlane airPlane = dataGrid2.SelectedItem as AirPlane;
                
                db.AirPlanes.Remove(airPlane);
                db.SaveChanges();
            }
        }

        
                    /*-----------------------РЕЙСЫ-----------------------*/

        // Добавление рейса
        private void addFB_Click(object sender, RoutedEventArgs e)
        {

            AddFlight addFlight = new AddFlight();

            List<AirPlane> airPlanes = db.AirPlanes.ToList();
            addFlight.comboBox.ItemsSource = airPlanes;
            addFlight.comboBox.SelectedValue = "Id";
            addFlight.comboBox.DisplayMemberPath = "AirPlaneName";


            List<Crew> crews = db.Crews.ToList();
            addFlight.comboBox1.ItemsSource = crews;
            addFlight.comboBox1.SelectedValue = "Id";
            addFlight.comboBox1.DisplayMemberPath = "HeadOfCrew";

            bool? b = addFlight.ShowDialog();

            System.Windows.Forms.DialogResult result;

            if (b == true)
            {
                result = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                result = System.Windows.Forms.DialogResult.Cancel;
            }
            
            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;

            Flight flight = new Flight();

            flight.NameOfFlight = addFlight.textBox1.Text;
            flight.DateOfFlight = (DateTime)addFlight.DatePicker.SelectedDate;
            flight.AirPlane = (AirPlane)addFlight.comboBox.SelectedItem;
            flight.Crew = (Crew) addFlight.comboBox1.SelectedItem;

           
            db.Flights.Add(flight);
            db.SaveChanges();


        }
        // Редактирование рейса
        private void editFB_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid3.SelectedIndex >= 0)
            {
                Flight flight = dataGrid3.SelectedItem as Flight;

                AddFlight addFlight = new AddFlight();

                addFlight.textBox1.Text = flight.NameOfFlight;
                addFlight.DatePicker.Text = flight.DateOfFlight.Date.ToString();


                // из команд в бд формируем список

                List<AirPlane> airPlanes = db.AirPlanes.ToList();
                addFlight.comboBox.ItemsSource = airPlanes;
                addFlight.comboBox.SelectedValue = "Id";
                addFlight.comboBox.DisplayMemberPath = "AirPlaneName";

                // показ выделенного названия
                int index = airPlanes.IndexOf(flight.AirPlane);
                addFlight.comboBox.SelectedItem = airPlanes[index];


                List<Crew> crews = db.Crews.ToList();
                addFlight.comboBox1.ItemsSource = crews;
                addFlight.comboBox1.SelectedValue = "Id";
                addFlight.comboBox1.DisplayMemberPath = "HeadOfCrew";


                index = crews.IndexOf(flight.Crew);
                addFlight.comboBox1.SelectedItem = crews[index];

                bool? b = addFlight.ShowDialog();

                System.Windows.Forms.DialogResult result;

                if (b == true)
                {
                    result = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    result = System.Windows.Forms.DialogResult.Cancel;
                }


                if (result == System.Windows.Forms.DialogResult.Cancel)
                    return;

               
                flight.NameOfFlight = addFlight.textBox1.Text;
                flight.DateOfFlight = (DateTime)addFlight.DatePicker.SelectedDate;
                flight.AirPlane = (AirPlane)addFlight.comboBox.SelectedItem;
                flight.Crew = (Crew)addFlight.comboBox1.SelectedItem;



                db.Entry(flight).State = EntityState.Modified;
                db.SaveChanges();

                RefreshData();
            }
            
        }
        // Удаление рейса
        private void delFB_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid3.SelectedIndex >= 0)
            {
                Flight flight = dataGrid3.SelectedItem as Flight;

                db.Flights.Remove(flight);
                db.SaveChanges();
            }
        }


                    /*-----------------------ЭКИПАЖ-----------------------*/

        //Добавление экипажа
        private void addCB_Click(object sender, RoutedEventArgs e)
        {

            AddCrew addCrew = new AddCrew();

            bool? b = addCrew.ShowDialog();

            System.Windows.Forms.DialogResult result;

            if (b == true)
            {
                result = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                result = System.Windows.Forms.DialogResult.Cancel;
            }

            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;


            Crew crew = new Crew();
            crew.HeadOfCrew = addCrew.textBox1.Text;
            crew.Amount = int.Parse(addCrew.textBox2.Text);

            db.Crews.Add(crew);
            db.SaveChanges();

        }
        // Изменение экипажа
        private void editCB_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid4.SelectedIndex >= 0)
            {
                Crew crew = dataGrid4.SelectedItem as Crew;
                
                AddCrew addCrew = new AddCrew();

                addCrew.textBox1.Text = crew.HeadOfCrew;
                addCrew.textBox2.Text = crew.Amount.ToString();


                bool? b = addCrew.ShowDialog();

                System.Windows.Forms.DialogResult result;

                if (b == true)
                {
                    result = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    result = System.Windows.Forms.DialogResult.Cancel;
                }

                if (result == System.Windows.Forms.DialogResult.Cancel)
                    return;

                
                crew.HeadOfCrew = addCrew.textBox1.Text;
                crew.Amount = int.Parse(addCrew.textBox2.Text);


                db.Entry(crew).State = EntityState.Modified;
                db.SaveChanges();

                RefreshData();

            }
        }
        // Удаление экипажа
        private void delCB_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid4.SelectedIndex >= 0)
            {
                Crew crew = dataGrid4.SelectedItem as Crew;

                db.Crews.Remove(crew);
                db.SaveChanges();
            }
        }
    }
}
