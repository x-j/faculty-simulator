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
    public partial class MainForm : Form {

        Faculty faculty;
        List<Button> buyButtons;
        List<Button> upgradeButtons;

        public MainForm() {
            InitializeComponent();
            tabControl.Visible = false;
            educationListView.Items[0].SubItems.Add("0");
            educationListView.Items[1].SubItems.Add("0");
            educationListView.Items[2].SubItems.Add("0");
        }

        private void startGameButton_Click(object sender, EventArgs e) {
            faculty = new Faculty("MiNI");
            //MessageBox.Show("Dddddddddddddddddddd ");
            UncoverGUI();
            timer.Enabled = true;
        }

        private void UncoverGUI() {
            tabControl.Visible = true;
            educationGroupBox.Text = educationListView.Items[0].Text;
            buyButtons = new List<Button>();
            buyButtons.Add(buy1Button);
            buyButtons.Add(buy2Button);
            buyButtons.Add(buy3Button);
            upgradeButtons = new List<Button>();
            upgradeButtons.Add(upgrade1Button);
            upgradeButtons.Add(upgrade2Button);
            upgradeButtons.Add(upgrade3Button);
        }

        private void timer_Tick(object sender, EventArgs e) {
            faculty.Increment();
            educationCounter.Text = "" + faculty.totalEducation;
            foreach (Button b in buyButtons) {
                if (faculty.totalEducation <= faculty.buyCosts[0]) {
                    b.Visible = false;
                    cannotButton1.Visible = true;
                } else b.Visible = true;
            }
            foreach (Button b in upgradeButtons) {
                if (faculty.totalEducation <= faculty.upgradeCosts[0]) {
                    b.Visible = false;
                    cannotButton2.Visible = true;
                } else b.Visible = true;
            }
        }



        private void buy1Button_Click(object sender, EventArgs e) {
            //switch case etc




        }

        private void buy2Button_Click(object sender, EventArgs e) {

        }

        private void buy3Button_Click(object sender, EventArgs e) {

        }

        private void educationListView_SelectedIndexChanged(object sender, EventArgs e) {

            ListView lv = (ListView)sender;
            if (lv.SelectedItems.Count > 0) {    //we have to check this right here, otherwise hell ensues
                educationGroupBox.Text = "" + lv.SelectedItems[0].Text;
            }

        }
    }
}
