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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        BootcampEfTravelDBEntities db = new BootcampEfTravelDBEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Locations.Count().ToString();
            lblSumCapacity.Text = db.Locations.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Locations.Count().ToString();
            lblAvgCapacity.Text =  db.Locations.Average(x => x.LocationCapacity).ToString();
            lblAverageLocationPrice.Text = "£" + db.Locations.Average(x=>x.LocationPrice).Value.ToString("F2");

            int lastCountryId = db.Locations.Max(x => x.LocationId);
            lblTheLastAddedCountry.Text = db.Locations.Where(x => x.LocationId == lastCountryId).Select(y=>y.LocationCountry).FirstOrDefault();

            lblCasablancaTourCapacity.Text = db.Locations
                .Where(x => x.LocationCity=="Casablanca")
                .Select(y=>y.LocationCapacity)
                .FirstOrDefault()
                .ToString();
            lblAaverageCapacityItalyTours.Text= db.Locations
                .Where(x=>x.LocationCountry=="Italy")
                .Average(y=>y.LocationCapacity)
                .ToString();
            var romeGuideId = db.Locations
               .Where(x => x.LocationCity == "Roma Tour")
               .Select(y => y.GuideId)
               .FirstOrDefault();
            lblRomeGuideName.Text = db.Guides
                .Where(x=>x.GuideId == romeGuideId)
                .Select(y=> y.GuideName +" "+ y.GuideSurname)
                .FirstOrDefault()
                .ToString ();
            var maxCapacity = db.Locations
                .Max(x => x.LocationCapacity);  // 80
            lblMaxCapacityLocation.Text = db.Locations  //Eagan Tour
                .Where(x => x.LocationCapacity == maxCapacity)
                .Select(y => y.LocationCity)
                .FirstOrDefault()
                .ToString();
            // the expensive tour
            var maxPrice = db.Locations
                .Max(x => x.LocationPrice);
            lblMaxPriceTour.Text = db.Locations
                .Where(x => x.LocationPrice == maxPrice)
                .Select(y => y.LocationCity)
                .FirstOrDefault()
                .ToString(); 
            // Jane Doe's Tours
            // Jane Doe's Id
            var guideIdByNameJaneDoe = db.Guides
                .Where(x=>x.GuideName == "Jane" &&  x.GuideSurname == "Doe")
                .Select(y => y.GuideId)
                .FirstOrDefault();
            // Tours
            lblJaneDoeLocationCount.Text = db.Locations
                .Where(x => x.GuideId == guideIdByNameJaneDoe)
                .Count()
                .ToString();



        }

    }
}
