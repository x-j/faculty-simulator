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
        List<ListView> listViews;
        List<GroupBox> groupBoxes;
        List<List<Label>> allLabels;

        enum LabelSigs : int { ThisUnitProduces, AllUnitsOfThisTypeProduce, YouGainNUnits, CostOfUnit, Upgrades, YouCurrentlyHaveUpgrades, CostOfUpgrade };


        long secondsElapsed;


        public MainForm() {
            InitializeComponent();
            tabControl.Visible = false;
            this.FormClosing += TryToExit;  //handler for exiting the app

            listViews = new List<ListView>();
            listViews.Add(educationListView);
            listViews.Add(scienceListView);
            listViews.Add(grantsListView);

            groupBoxes = new List<GroupBox>();
            groupBoxes.Add(groupBox1);
            groupBoxes.Add(groupBox2);
            groupBoxes.Add(groupBox3);

            allLabels = new List<List<Label>>();
            for (int i = 0; i < groupBoxes.Count; i++)
                allLabels.Add(new List<Label>());

            for (int i = 0; i < groupBoxes.Count; i++) {
                foreach (Control c in groupBoxes[i].Controls)
                    if (c is Label) allLabels[i].Add((Label)c);
            }



        }

        private void startGameButton_Click(object sender, EventArgs e) {
            faculty = new Faculty("MiNI");
            UncoverGUI();
            secondsElapsed = 0;
            timer.Enabled = true;
            foreach (Component c in statusStrip.Items) ((ToolStripStatusLabel)c).Visible = true;
        }

        private void UncoverGUI() {
            tabControl.Visible = true;

        }

        private void timer_Tick(object sender, EventArgs e) {
            secondsElapsed++;
            faculty.Increment();
            UpdateGUI();
            if (secondsElapsed == 120) MessageBox.Show("You've been playing for two minutes already. I would stop if I were you, you're being very unproductive.");
            if (secondsElapsed == 360) MessageBox.Show("You should really stop now.");
            if (secondsElapsed == 420) MessageBox.Show("You should stop for your own good.");
            if (secondsElapsed >= 600) {
                MessageBox.Show("Okay well done you've won the game.");
                timer.Stop();
            }

        }

        //gets called from timer tick:
        private void UpdateGUI() {

            //update the label indicating the time elapsed:
            timerLabel.Text = TimeSpan.FromSeconds(secondsElapsed).ToString();

            //update the labels which store our resources:
            educationCounter.Text = "EDUCATION: " + faculty.totalEducation;
            scienceCounter.Text = "SCIENCE: " + faculty.totalScience;
            grantsCounter.Text = "GRANTS: " + faculty.totalGrants;

            //update the counts of currently displayed units:
            var selectedTab = tabControl.SelectedIndex;
            var currentLVI = listViews[selectedTab];
            for (int i = 0; i < currentLVI.Items.Count; i++)
                currentLVI.Items[i].SubItems[1].Text = "" + faculty.allWorkers[selectedTab][i][0];

            //update the text on the current groupBox labels:
            UpdateGroupBox(selectedTab, currentLVI);

            //possibly nothing TODO here?

        }



        private void UpdateGroupBox(int selectedTab, ListView currentLVI) {

            //first check if there is any item selected (because there doesnt have to be one)
            if (currentLVI.SelectedIndices.Count > 0) {

                //find out which item exactly is selected:
                int currentItemIndex = currentLVI.SelectedIndices[0];

                #region go through all the labels in the appropiate groupBox and update them
                foreach (Label l in allLabels[selectedTab]) {
                    switch ((string)l.Tag) {
                        case "0":
                            if (currentItemIndex != 2) l.Text = "This unit produces " + faculty.production[currentItemIndex] + " " + currentLVI.Items[currentItemIndex + 1].Text + "s every second.";
                            else l.Text = "This unit produces " + faculty.production[currentItemIndex] + " resource every second.";
                            break;

                        case "1":
                            if (currentItemIndex != 2) l.Text = "All units of this type produce " + faculty.allWorkers[selectedTab][currentItemIndex][0] * faculty.production[currentItemIndex] * (1 + faculty.allWorkers[selectedTab][currentItemIndex][1]) + " " + currentLVI.Items[currentItemIndex + 1].Text + "s every second.";      //candidate for the 2016 "Longest line of code" award 
                            else l.Text = "All units of this type produce " + faculty.allWorkers[selectedTab][currentItemIndex][0] * faculty.production[currentItemIndex] * (1 + faculty.allWorkers[selectedTab][currentItemIndex][1]) + " resources every second.";
                            break;

                        case "2":
                            if (currentItemIndex == 0) l.Text = "Your senior worker count does not increase on its own.";
                            else l.Text = "You gain " + faculty.allWorkers[selectedTab][currentItemIndex - 1][0] * faculty.production[currentItemIndex - 1] * (1 + faculty.allWorkers[selectedTab][currentItemIndex - 1][1]) + " units of this type every second.";
                            break;

                        case "3":
                            l.Text = "Cost of one unit of this type: Education: " + faculty.allCosts[selectedTab][currentItemIndex].educations + ", Science: " + faculty.allCosts[selectedTab][currentItemIndex].sciences + ", Grants: " + faculty.allCosts[selectedTab][currentItemIndex].grants;
                            break;

                        case "4":
                            if (secondsElapsed % 123 == 66) l.Text = "It's Friday, 4 AM in the morning and these are the things I do for Mr. Walędzik and co.";
                            break;

                        case "5":
                            l.Text = "You currently have " + faculty.allWorkers[selectedTab][currentItemIndex][1] + " upgrades.";
                            break;

                        case "6":
                            l.Text = "Cost of an upgrade: Education: " + faculty.upgradeCosts[currentItemIndex] + ", Science: 0, Grants: 0";
                            break;

                        default:
                            MessageBox.Show("this message box should never appear, definitely something very bad happened");
                            break;

                    }
                }
                #endregion

                //TODO: update Buttons

            }
        }

        private void buy1Button_Click(object sender, EventArgs e) {
            //switch case etc

        }

        private void buy2Button_Click(object sender, EventArgs e) {

        }

        private void buy3Button_Click(object sender, EventArgs e) {

        }

        //gets called when we change the selected ListView item, all it does is call UpdateGroupBox
        private void educationListView_SelectedIndexChanged(object sender, EventArgs e) {

            ListView lv = (ListView)sender;
            UpdateGroupBox(tabControl.SelectedIndex, lv);

        }

        //calls the Application.Exit() method:
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //this gets called whenever user tries to exit the application, by any means:
        private void TryToExit(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure you want to exit?", "WAIT!", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }


    }
}
