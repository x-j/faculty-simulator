using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_Simulator {
    public partial class OptionsForm : Form {

        MainForm mainForm;
        public OptionsForm(MainForm mf) {
            InitializeComponent();
            productionTrackBar.Value = mf.ProductionMultiplier;
            pricesTrackBar.Value = mf.PricesMultiplier;
            speedTrackBar.Value = mf.SpeedMultiplier;
            okButton.Click += new EventHandler(SendNewSettings);
            mainForm = mf;
        }

        private void SendNewSettings(object sender, EventArgs e) {
            mainForm.UpdateFacultySettings(productionTrackBar.Value, pricesTrackBar.Value, speedTrackBar.Value);
        }

    }
}
