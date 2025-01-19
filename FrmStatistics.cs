using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEğitimKampı301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuide.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString();

            int lastCountryId = db.Location.Max(x=>x.LocatonId);
            lblLastCountryName.Text = db.Location.Where(x=>x.LocatonId==lastCountryId).Select(y=>y.Country).
                FirstOrDefault();

            lblKapadokyaCapacity.Text = db.Location.Where(x => x.City == "Kapadokya")
                .Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").
                Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x=>x.City=="Roma").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x=>x.GuideId == romeGuideId).Select(y=>y.Name + " " + y.Surname).
                FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x=>x.Capacity);
            lblMaxCapacityCountry.Text = db.Location.Where(x=>x.Capacity==maxCapacity).
                Select(y=>y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x=>x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).
                Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByAysegulCinar = db.Guide.Where(x=>x.Name =="Ayşegül" && x.Surname=="Çınar").
                Select(y=>y.GuideId).FirstOrDefault();

            lblAysegulCinarLocationCount.Text = db.Location.Where(x=>x.GuideId == guideIdByAysegulCinar).
                Count().ToString();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
