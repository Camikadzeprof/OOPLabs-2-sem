using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WindowsForms2
{
    public partial class Form1 : Form
    {
        public Building building;
        public Form1()
        {
            InitializeComponent();
            building = new Building();
        }

        private void add_Click(object sender, EventArgs e)  
        {
            if (meters.Text.Equals(""))
            {
                MessageBox.Show("Введите метраж квартиры");
                return;
            }
            if (mattype.Text.Equals(""))
            {
                MessageBox.Show("Выберите материал");
                return;
            }
            if (kolWindows.Text.Equals(""))
            {
                MessageBox.Show("Введите количество окон");
                return;
            }
            if (soln.Checked==false && nesoln.Checked == false)
            {
                MessageBox.Show("Выберите сторону");
                return;
            }
            if (country.Text.Equals("") || city.Text.Equals("") || street.Text.Equals("")
                || house.Text.Equals("") || number.Text.Equals(""))
            {
                MessageBox.Show("Все поля адреса квартиры должны быть заполнены!");
                return;
            }

            House currentHouse;
            if (soln.Checked == true)
            {
                currentHouse = new House
                {
                    Meter = Int32.Parse(meters.Text),
                    Material = mattype.Text,
                    Date_built = dateofbld.Value,
                    Floor = floor.Value,
                    Rooms = kolk.Value,
                    Windows = Int32.Parse(kolWindows.Text),
                    WindowsSide = "солнечная",
                    Address = new Address
                    {
                        Country = country.Text,
                        City = city.Text,
                        Street = street.Text,
                        Home = Int32.Parse(house.Text),
                        Apartment = Int32.Parse(number.Text)
                    }
                };
            }
            else
            {
                currentHouse = new House
                {
                    Meter = Int32.Parse(meters.Text),
                    Material = mattype.Text,
                    Date_built = dateofbld.Value,
                    Floor = floor.Value,
                    Rooms = kolk.Value,
                    Windows = Int32.Parse(kolWindows.Text),
                    WindowsSide = "не солнечная",
                    Address = new Address
                    {
                        Country = country.Text,
                        City = city.Text,
                        Street = street.Text,
                        Home = Int32.Parse(house.Text),
                        Apartment = Int32.Parse(number.Text)
                    }
                };
            }
            currentHouse.Price = Decimal.ToInt32(currentHouse.Rooms) * 10000 - currentHouse.Floor * 54 + currentHouse.Windows * 200;
            building.Houses.Add(currentHouse);
            currentHouse.Result = currentHouse.Address.Street + ": " + currentHouse.Rooms + "-комн., " + currentHouse.Windows + " окон, " + currentHouse.WindowsSide + " сторона, " + 
                currentHouse.Floor + " этаж, " + currentHouse.Material + ", " +
                currentHouse.Meter + " кв.м";
            if (kitchen.Checked) currentHouse.Result += " + кухня";
            if (bath.Checked) currentHouse.Result += " + ванная";
            if (balc.Checked) currentHouse.Result += " + балкон";
            if (toilet.Checked) currentHouse.Result += " + туалет";
            currentHouse.Result += "Цена: " + currentHouse.Price + "$.";
            listBox1.Items.Add(currentHouse.Result);
        }

        private void save_Click(object sender, EventArgs e)      
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, building);
            }
        }

        private void open_Click(object sender, EventArgs e)      
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.Open))
            {
                building = serializer.Deserialize(stream) as Building;
            }
            foreach (House house in building.Houses)
                listBox1.Items.Add(house.Result);
        }
        private void mattype_SelectedIndexChanged(object sender, EventArgs e) 
        {

        }

        private void kolk_ValueChanged(object sender, EventArgs e)    
        {

        }

        private void meters_TextChanged(object sender, EventArgs e)   
        {

        }

        private void floor_Scroll(object sender, EventArgs e)   
        {

        }

        private void dateofbld_ValueChanged(object sender, EventArgs e)   
        {

        }

        private void kitchen_CheckedChanged(object sender, EventArgs e)   
        {

        }

        private void toilet_CheckedChanged(object sender, EventArgs e)   
        {

        }

        private void bath_CheckedChanged(object sender, EventArgs e)   
        {

        }

        private void balc_CheckedChanged(object sender, EventArgs e)   
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)  
        {

        }

        private void country_TextChanged(object sender, EventArgs e)   
        {

        }

        private void city_TextChanged(object sender, EventArgs e)   
        {

        }

        private void street_TextChanged(object sender, EventArgs e)  
        {

        }

        private void house_TextChanged(object sender, EventArgs e)   
        {

        }

        private void number_TextChanged(object sender, EventArgs e)   
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
