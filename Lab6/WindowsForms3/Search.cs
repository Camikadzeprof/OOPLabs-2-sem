using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;

namespace WindowsForms3
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void extended_CheckedChanged(object sender, EventArgs e)
        {
            parameters.Visible = extended.Checked;
        }

        private void searching_Click(object sender, EventArgs e)
        {
            Regex r1 = new Regex(regular.Text);
            Building building = null;

            XmlSerializer ser = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.Open))
            {
                building = ser.Deserialize(stream) as Building;
            }
            listBox1.Items.Clear();
            List<House> searchResult = new List<House>();
            foreach (House house in building.Houses)
            {
                if (r1.IsMatch(house.Result))
                {
                    if (extended.Checked)
                    {
                        if (city.Text.Length > 0 && city.Text != house.Address.City)
                            continue;
                        if (year.Value != house.Date_built.Year)
                            continue;
                        if (kolk.Value != house.Rooms)
                            continue;
                    }
                    //listBox1.Items.Add(house.Reault);
                    searchResult.Add(house);
                }
            }
            IEnumerable<House> ordered = null;
            if (typeofsort.Text == "По площади")
                ordered = searchResult.OrderBy(p => p.Meter);
            else
                ordered = searchResult.OrderBy(p => p.Price);
            foreach (House item in ordered)
                listBox1.Items.Add(item.Result);
        }
    }
}
