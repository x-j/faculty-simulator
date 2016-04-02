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
        List<List<Button>> buyButtons;
        List<List<Button>> upgradeButtons;
        List<GroupBox> groupBoxes;
        List<List<Label>> allLabels;
        public List<ListView> listViews;

        public List<long[]> clickCounts;

        private long secondsElapsed;
        private bool gameOn;

        public MainForm() {
            InitializeComponent();
            //exitToolStripMenuItem.ShortcutKeys = Keys.Escape;     <- gotta figure out how to do this
            tabControl.Visible = false;     //invisible until start game button gets clicked
            this.FormClosing += TryToExit;  //handler for exiting the app

            //arrange listviews in orderly manner:
            listViews = new List<ListView>();
            listViews.Add(educationListView);
            listViews.Add(scienceListView);
            listViews.Add(grantsListView);

            //arrange groupBoxes in orderly manner:
            groupBoxes = new List<GroupBox>();
            groupBoxes.Add(groupBox1);
            groupBoxes.Add(groupBox2);
            groupBoxes.Add(groupBox3);

            //arrange labels in orderly manner:
            allLabels = new List<List<Label>>();
            for (int i = 0; i < groupBoxes.Count; i++) {
                allLabels.Add(new List<Label>());
                foreach (Control c in groupBoxes[i].Controls)
                    if (c is Label) allLabels[i].Add((Label)c);
            }

            //arrange Buttons in orderly manner:
            buyButtons = new List<List<Button>>();
            upgradeButtons = new List<List<Button>>();
            for (int i = 0; i < groupBoxes.Count; i++) {
                buyButtons.Add(new List<Button>());
                upgradeButtons.Add(new List<Button>());
            }

            sadPrototype.Click += new EventHandler(SadButtonClicked);

            //the six lines below add all the existing Buttons to their Lists, and add EventHandlers to them
            foreach (Button b in eduBuyButtonsPanel.Controls) { buyButtons[0].Add(b); b.Click += new EventHandler(BuyButtonClicked); }
            foreach (Button b in sciBuyButtonsPanel.Controls) { buyButtons[1].Add(b); b.Click += new EventHandler(BuyButtonClicked); }
            foreach (Button b in graBuyButtonsPanel.Controls) { buyButtons[2].Add(b); b.Click += new EventHandler(BuyButtonClicked); }
            foreach (Button b in sciUpgradeButtonsPanel.Controls) { upgradeButtons[1].Add(b); b.Click += new EventHandler(UpgradeButtonClicked); }
            foreach (Button b in eduUpgradeButtonsPanel.Controls) { upgradeButtons[0].Add(b); b.Click += new EventHandler(UpgradeButtonClicked); }
            foreach (Button b in graUpgradeButtonsPanel.Controls) { upgradeButtons[2].Add(b); b.Click += new EventHandler(UpgradeButtonClicked); }

            //the code basically comments itself!

            //set the event handler of listviews to the same one, declared somewhere below:
            educationListView.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(listView_SelectedIndexChanged);
            scienceListView.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(listView_SelectedIndexChanged);
            grantsListView.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(listView_SelectedIndexChanged);

            clickCounts = new List<long[]>();
            for (int i = 0; i < listViews.Count; i++) {
                long[] temp = { 0, 0, 0};
                clickCounts.Add(temp);
            }

            gameOn = false; //false until we start the game
        }
        private void BuyButtonClicked(object sender, EventArgs e) {
            Button b = sender as Button;
            //first, find out which tab and listView item is selected: 
            int selectedTab = tabControl.SelectedIndex;
            int selectedItem = listViews[selectedTab].SelectedIndices[0];
            //make the purchase:
            if (faculty.Buy(selectedTab, selectedItem, (string)b.Tag)) MessageBox.Show("Well done, you've broke the game.");

            clickCounts[selectedTab][selectedItem]++;
            UpdateGUI();
        }
        private void UpgradeButtonClicked(object sender, EventArgs e) {
            Button b = sender as Button;
            //first, find out which tab and listView item is selected: 
            int selectedTab = tabControl.SelectedIndex;
            int selectedItem = listViews[selectedTab].SelectedIndices[0];
            //make the purchase:
            if (faculty.Upgrade(selectedTab, selectedItem, (string)b.Tag)) MessageBox.Show("Well done, you've broke the game.");

            clickCounts[selectedTab][selectedItem]++;
            UpdateGUI();
        }
        private void SadButtonClicked(object sender, EventArgs e) {
            ((Button)sender).Text = "How did you manage to click this?";
        }
        void startGameButton_Click(object sender, EventArgs e) {
            if (gameOn) {
                if ((MessageBox.Show("Are you sure you want to start the game again? You will lose all unsaved progress!", "WAIT!", MessageBoxButtons.YesNo) == DialogResult.No))
                    return;
            }
            gameOn = true;
            moreButton.Enabled = true;
            faculty = new Faculty("MiNI");
            UncoverGUI();
            secondsElapsed = 0;
            timer.Enabled = true;
            foreach (Component c in statusStrip.Items) ((ToolStripStatusLabel)c).Visible = true;

        }

        private void UncoverGUI() {
            tabControl.Visible = true;
            //possibly something else happens here? if not, get rid of this method
        }

        private void timer_Tick(object sender, EventArgs e) {
            secondsElapsed++;
            faculty.Increment();
            UpdateGUI();
            if (secondsElapsed == 120) MessageBox.Show("You've been playing for two minutes already. I would stop if I were you, you're being very unproductive.");
            if (secondsElapsed == 360) MessageBox.Show("You should really stop now.");
            if (secondsElapsed == 420) MessageBox.Show("You should stop for your own good.");
            if (secondsElapsed >= 600) {
                timer.Stop();
                MessageBox.Show("Okay well done you've won the game.");
            }
            if (faculty.Exploded()) {
                timer.Stop();
                MessageBox.Show("Well done! The amount of knowledge you've so laboriously amassed became so enormous that it no longer fits within your humble faculty. You truly are a gifted dean! This also means that the game is finally over, you've won!", "Congratulations!");
            }
        }

        //gets called from timer tick:
        private void UpdateGUI() {

            //update the label indicating the time elapsed
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

            //update the text on the current groupBox labels and buttons:
            UpdateGroupBox(selectedTab, currentLVI);

            Update();
            //possibly nothing else TODO here?

        }

        private void UpdateGroupBox(int selectedTab, ListView currentLVI) {
            //first check if there is any item selected (because there doesnt have to be one)
            if (currentLVI.SelectedIndices.Count > 0) {

                //find out which item exactly is selected:
                int selectedItem = currentLVI.SelectedIndices[0];

                groupBoxes[selectedTab].Text = currentLVI.Items[selectedItem].Text;
                UpdateLabels(selectedTab, selectedItem, currentLVI);
                UpdateButtons(selectedTab, selectedItem);

            }
        }

        //updates the buttons on an appropiate groupbox only:
        private void UpdateButtons(int selectedTab, int selectedItem) {

            //if we can't afford any of the selected item, show the sad button:
            if (!faculty.CanAfford(faculty.allCosts[selectedTab][selectedItem])) {
                foreach (Button b in buyButtons[selectedTab]) {
                    if (b.Tag.Equals("sad")) b.Visible = true;
                    else b.Visible = false;
                }
            } else {
                //otherwise, navigate through all the buyButtons and adjust their text and visibility
                foreach (Button b in buyButtons[selectedTab]) {
                    switch ((string)b.Tag) {
                        case "sad": //"Unable to buy" button
                            b.Visible = false;
                            break;

                        case "0":   //"Buy 1" button
                            b.Visible = true;
                            break;

                        case "1":   //"Buy 1/2 of total" button
                            if (!faculty.CanAfford(Faculty.Cost.Multiply(4, faculty.allCosts[selectedTab][selectedItem])))
                                b.Visible = false;
                            else {
                                b.Visible = true;
                                b.Text = "Buy " + (faculty.GetAffordableWorkers(selectedTab, selectedItem) / 2);
                            }
                            break;

                        case "2":   //"Buy all possible" button
                            if (!faculty.CanAfford(Faculty.Cost.Multiply(8, faculty.allCosts[selectedTab][selectedItem])))
                                b.Visible = false;
                            else {
                                b.Visible = true;
                                b.Text = "Buy " + (faculty.GetAffordableWorkers(selectedTab, selectedItem));
                            }
                            break;

                        default:
                            MessageBox.Show("This messsage should never appear, definitely something very bad happened");
                            break;
                    }
                }
            }
            //then, do the same but for upgradeButtons:
            if (!faculty.CanAfford(faculty.upgradeCosts[selectedItem])) {
                foreach (Button b in upgradeButtons[selectedTab]) {
                    if (b.Tag.Equals("sad")) b.Visible = true;
                    else b.Visible = false;
                }
            } else {
                foreach (Button b in upgradeButtons[selectedTab]) {
                    switch ((string)b.Tag) {
                        case "sad":  //"Unable to buy" button
                            b.Visible = false;
                            break;

                        case "0":   //"Upgrade 1 " button
                            b.Visible = true;
                            break;

                        case "1":   //"Upgrade 1/2 of max possible " button
                            if (!faculty.CanAfford(4 * faculty.upgradeCosts[selectedItem]))
                                b.Visible = false;
                            else {
                                b.Visible = true;
                                b.Text = "Upgrade " + (faculty.GetAffordableUpgrades(selectedItem) / 2);
                            }
                            break;

                        case "2":   //"Upgrade all possible" button
                            if (!faculty.CanAfford(8 * faculty.upgradeCosts[selectedItem]))
                                b.Visible = false;
                            else {
                                b.Visible = true;
                                b.Text = "Upgrade " + (faculty.GetAffordableUpgrades(selectedItem));
                            }
                            break;

                        default:
                            MessageBox.Show("This messsage should never appear, definitely something very bad happened");
                            break;
                    }
                }
            }
        }

        //updates the labels on an appropiate groupbox only:
        private void UpdateLabels(int selectedTab, int selectedItem, ListView currentLVI) {

            foreach (Label l in allLabels[selectedTab]) {
                switch ((string)l.Tag) {
                    case "0":
                        if (selectedItem != 2) l.Text = "This unit produces " + faculty.production[selectedItem] + " " + currentLVI.Items[selectedItem + 1].Text + "s every second.";
                        else l.Text = "This unit produces " + faculty.production[selectedItem] + " resource every second.";
                        break;

                    case "1":
                        if (selectedItem != 2) l.Text = "All units of this type produce " + faculty.allWorkers[selectedTab][selectedItem][0] * faculty.production[selectedItem] * (1 + faculty.allWorkers[selectedTab][selectedItem][1]) + " " + currentLVI.Items[selectedItem + 1].Text + "s every second.";      //candidate for the 2016 "Longest line of code" award 
                        else l.Text = "All units of this type produce " + faculty.allWorkers[selectedTab][selectedItem][0] * faculty.production[selectedItem] * (1 + faculty.allWorkers[selectedTab][selectedItem][1]) + " resources every second.";
                        break;

                    case "2":
                        if (selectedItem == 0) l.Text = "Your senior worker count does not increase on its own.";
                        else l.Text = "You gain " + faculty.allWorkers[selectedTab][selectedItem - 1][0] * faculty.production[selectedItem - 1] * (1 + faculty.allWorkers[selectedTab][selectedItem - 1][1]) + " units of this type every second.";
                        break;

                    case "3":
                        l.Text = "Cost of one unit of this type: Education: " + faculty.allCosts[selectedTab][selectedItem].educations + ", Science: " + faculty.allCosts[selectedTab][selectedItem].sciences + ", Grants: " + faculty.allCosts[selectedTab][selectedItem].grants;
                        break;

                    case "4":
                        //this is the "Upgrades" label, does not change ever
                        break;

                    case "5":
                        l.Text = "You currently have " + faculty.allWorkers[selectedTab][selectedItem][1] + " upgrades.";
                        break;

                    case "6":
                        l.Text = "Cost of an upgrade: Education: " + faculty.upgradeCosts[selectedItem] + ", Science: 0, Grants: 0";
                        break;

                    default:
                        MessageBox.Show("this message box should never appear, definitely something very bad happened");
                        break;

                }
            }

        }

        //gets called when we change the selected ListView item, all it does is call UpdateGroupBox:
        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            ListView lv = (ListView)sender;
            groupBoxes[tabControl.SelectedIndex].Visible = true;
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

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (gameOn) {
                StatisticsForm sf = new StatisticsForm(this);
                timer.Stop();
                sf.ShowDialog();
                timer.Start();
            }
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e) {

            OptionsForm of = new OptionsForm(this);
            timer.Stop();
            of.ShowDialog();
            timer.Start();

        }
        public void UpdateFacultySettings(int newProductionMultiplier, int newPricesMultiplier) {
            faculty.ResetCostsAndProduction();
            faculty.UpdateProduction(newProductionMultiplier);
            faculty.UpdatePrices(newPricesMultiplier);

        }
    }
}
