using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Bootcamp_301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        BootcampEfTravelDBEntities db = new BootcampEfTravelDBEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values= db.Locations.ToList();
            dataGridView1.DataSource = values;

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guides.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname, x.GuideId
            }
                ).ToList();

            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           Location location = new Location();
            location.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            location.LocationCity = txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Locations.Add(location);
            db.SaveChanges();
            MessageBox.Show("Adding succesfully");

            var values = db.Locations.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Locations.Find(id);
            db.Locations.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Deleted succesfully");

            var values = db.Locations.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse((string)txtId.Text);
            var updatedValue = db.Locations.Find(id);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.LocationPrice = decimal.Parse(txtPrice.Text);
            updatedValue.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.LocationCity = txtCity.Text;
            updatedValue.LocationCountry = txtCountry.Text;
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Updated succesfully");

            var values = db.Locations.ToList();
            dataGridView1.DataSource = values;

        }
    }
}
