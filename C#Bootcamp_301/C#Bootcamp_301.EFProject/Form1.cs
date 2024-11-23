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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BootcampEfTravelDBEntities db = new BootcampEfTravelDBEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guides.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName= txtName.Text;
            guide.GuideSurname= txtSurname.Text;
            db.Guides.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Guide's information added succesfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue= db.Guides.Find(id);
            db.Guides.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Guide's information deleted succesfully");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guides.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Guide's information updated succesfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var values= db.Guides.Where(x=> x.GuideId == id).ToList();
            dataGridView1.DataSource = values; 
        }
    }
}
