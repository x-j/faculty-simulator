using System;

namespace Faculty_Simulator {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label upgradesLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Senior lecturer",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Lecturer",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Junior Lecturer",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Senior Scientist",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Scientist",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Junior Scientist",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Senior Professor",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Professor",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Junior Professor",
            "0"}, -1);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.timerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grantsCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.scienceCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.educationCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.startGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.educationPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.educationListView = new System.Windows.Forms.ListView();
            this.unitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eduUpgradeButtonsPanel = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.upgradeCostLabel = new System.Windows.Forms.Label();
            this.upgradesCountLabel = new System.Windows.Forms.Label();
            this.eduBuyButtonsPanel = new System.Windows.Forms.Panel();
            this.sadPrototype = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.youGainThisUnitLabel = new System.Windows.Forms.Label();
            this.allUnitsOfThisTypeProduceLabel = new System.Windows.Forms.Label();
            this.thisUnitProducesLabel = new System.Windows.Forms.Label();
            this.sciencePage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.scienceListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sciUpgradeButtonsPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sciBuyButtonsPanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grantsPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grantsListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.graUpgradeButtonsPanel = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.graBuyButtonsPanel = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogBox = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogBox = new System.Windows.Forms.OpenFileDialog();
            upgradesLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.educationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.eduUpgradeButtonsPanel.SuspendLayout();
            this.eduBuyButtonsPanel.SuspendLayout();
            this.sciencePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sciUpgradeButtonsPanel.SuspendLayout();
            this.sciBuyButtonsPanel.SuspendLayout();
            this.grantsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.graUpgradeButtonsPanel.SuspendLayout();
            this.graBuyButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upgradesLabel
            // 
            upgradesLabel.AutoSize = true;
            upgradesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            upgradesLabel.Location = new System.Drawing.Point(6, 220);
            upgradesLabel.Name = "upgradesLabel";
            upgradesLabel.Size = new System.Drawing.Size(69, 15);
            upgradesLabel.TabIndex = 4;
            upgradesLabel.Tag = "4";
            upgradesLabel.Text = "Upgrades";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label3.Location = new System.Drawing.Point(6, 220);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 15);
            label3.TabIndex = 4;
            label3.Tag = "4";
            label3.Text = "Upgrades";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label10.Location = new System.Drawing.Point(6, 220);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 15);
            label10.TabIndex = 4;
            label10.Tag = "4";
            label10.Text = "Upgrades";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerLabel,
            this.grantsCounter,
            this.scienceCounter,
            this.educationCounter});
            this.statusStrip.Location = new System.Drawing.Point(0, 500);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(801, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // timerLabel
            // 
            this.timerLabel.Margin = new System.Windows.Forms.Padding(0, 3, 200, 2);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.timerLabel.Size = new System.Drawing.Size(48, 17);
            this.timerLabel.Text = "0:00:00";
            this.timerLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.timerLabel.Visible = false;
            // 
            // grantsCounter
            // 
            this.grantsCounter.Name = "grantsCounter";
            this.grantsCounter.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.grantsCounter.Size = new System.Drawing.Size(69, 17);
            this.grantsCounter.Text = "GRANTS: 0";
            this.grantsCounter.Visible = false;
            // 
            // scienceCounter
            // 
            this.scienceCounter.Name = "scienceCounter";
            this.scienceCounter.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.scienceCounter.Size = new System.Drawing.Size(70, 17);
            this.scienceCounter.Text = "SCIENCE: 0";
            this.scienceCounter.Visible = false;
            // 
            // educationCounter
            // 
            this.educationCounter.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.educationCounter.Name = "educationCounter";
            this.educationCounter.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.educationCounter.Size = new System.Drawing.Size(90, 17);
            this.educationCounter.Text = "EDUCATION: 0";
            this.educationCounter.Visible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton,
            this.moreButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(801, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameButton,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton.Text = "File";
            // 
            // startGameButton
            // 
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(152, 22);
            this.startGameButton.Text = "Start Game";
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Enabled = false;
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // moreButton
            // 
            this.moreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moreButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.moreButton.Enabled = false;
            this.moreButton.Image = ((System.Drawing.Image)(resources.GetObject("moreButton.Image")));
            this.moreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(48, 22);
            this.moreButton.Text = "More";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.optionToolStripMenuItem.Text = "Options";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.educationPage);
            this.tabControl.Controls.Add(this.sciencePage);
            this.tabControl.Controls.Add(this.grantsPage);
            this.tabControl.Location = new System.Drawing.Point(10, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(779, 469);
            this.tabControl.TabIndex = 2;
            this.tabControl.Tag = "0";
            // 
            // educationPage
            // 
            this.educationPage.Controls.Add(this.splitContainer1);
            this.educationPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.educationPage.Location = new System.Drawing.Point(4, 22);
            this.educationPage.Name = "educationPage";
            this.educationPage.Padding = new System.Windows.Forms.Padding(3);
            this.educationPage.Size = new System.Drawing.Size(771, 443);
            this.educationPage.TabIndex = 0;
            this.educationPage.Text = "EDUCATION";
            this.educationPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.educationListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(765, 437);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 0;
            // 
            // educationListView
            // 
            this.educationListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.educationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.unitHeader,
            this.countHeader});
            listViewItem10.StateImageIndex = 0;
            listViewItem10.Tag = "0";
            listViewItem11.Tag = "1";
            listViewItem12.Tag = "2";
            this.educationListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.educationListView.Location = new System.Drawing.Point(3, 3);
            this.educationListView.MultiSelect = false;
            this.educationListView.Name = "educationListView";
            this.educationListView.Size = new System.Drawing.Size(219, 433);
            this.educationListView.TabIndex = 0;
            this.educationListView.UseCompatibleStateImageBehavior = false;
            this.educationListView.View = System.Windows.Forms.View.Details;
            // 
            // unitHeader
            // 
            this.unitHeader.Tag = "0";
            this.unitHeader.Text = "Unit";
            this.unitHeader.Width = 104;
            // 
            // countHeader
            // 
            this.countHeader.Tag = "1";
            this.countHeader.Text = "Count";
            this.countHeader.Width = 77;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eduUpgradeButtonsPanel);
            this.groupBox1.Controls.Add(this.upgradeCostLabel);
            this.groupBox1.Controls.Add(this.upgradesCountLabel);
            this.groupBox1.Controls.Add(upgradesLabel);
            this.groupBox1.Controls.Add(this.eduBuyButtonsPanel);
            this.groupBox1.Controls.Add(this.costLabel);
            this.groupBox1.Controls.Add(this.youGainThisUnitLabel);
            this.groupBox1.Controls.Add(this.allUnitsOfThisTypeProduceLabel);
            this.groupBox1.Controls.Add(this.thisUnitProducesLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // eduUpgradeButtonsPanel
            // 
            this.eduUpgradeButtonsPanel.Controls.Add(this.button16);
            this.eduUpgradeButtonsPanel.Controls.Add(this.button17);
            this.eduUpgradeButtonsPanel.Controls.Add(this.button18);
            this.eduUpgradeButtonsPanel.Controls.Add(this.button19);
            this.eduUpgradeButtonsPanel.Location = new System.Drawing.Point(9, 327);
            this.eduUpgradeButtonsPanel.Name = "eduUpgradeButtonsPanel";
            this.eduUpgradeButtonsPanel.Size = new System.Drawing.Size(515, 31);
            this.eduUpgradeButtonsPanel.TabIndex = 5;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Enabled = false;
            this.button16.Location = new System.Drawing.Point(0, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(515, 31);
            this.button16.TabIndex = 5;
            this.button16.Tag = "sad";
            this.button16.Text = "Unable To Buy";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(307, 0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(208, 31);
            this.button17.TabIndex = 2;
            this.button17.Tag = "2";
            this.button17.Text = "Buy 1";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(116, 0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(179, 31);
            this.button18.TabIndex = 3;
            this.button18.Tag = "1";
            this.button18.Text = "Buy 1";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(0, 0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(110, 31);
            this.button19.TabIndex = 4;
            this.button19.Tag = "0";
            this.button19.Text = "Buy 1";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // upgradeCostLabel
            // 
            this.upgradeCostLabel.AutoSize = true;
            this.upgradeCostLabel.Location = new System.Drawing.Point(6, 297);
            this.upgradeCostLabel.Name = "upgradeCostLabel";
            this.upgradeCostLabel.Size = new System.Drawing.Size(330, 15);
            this.upgradeCostLabel.TabIndex = 2;
            this.upgradeCostLabel.Tag = "6";
            this.upgradeCostLabel.Text = "Cost of an upgrade: Education: 10000, Science: 0, Grants: 0";
            // 
            // upgradesCountLabel
            // 
            this.upgradesCountLabel.AutoSize = true;
            this.upgradesCountLabel.Location = new System.Drawing.Point(6, 261);
            this.upgradesCountLabel.Name = "upgradesCountLabel";
            this.upgradesCountLabel.Size = new System.Drawing.Size(174, 15);
            this.upgradesCountLabel.TabIndex = 3;
            this.upgradesCountLabel.Tag = "5";
            this.upgradesCountLabel.Text = "You currently have 0 upgrades.";
            // 
            // eduBuyButtonsPanel
            // 
            this.eduBuyButtonsPanel.Controls.Add(this.sadPrototype);
            this.eduBuyButtonsPanel.Controls.Add(this.button3);
            this.eduBuyButtonsPanel.Controls.Add(this.button2);
            this.eduBuyButtonsPanel.Controls.Add(this.button1);
            this.eduBuyButtonsPanel.Location = new System.Drawing.Point(9, 148);
            this.eduBuyButtonsPanel.Name = "eduBuyButtonsPanel";
            this.eduBuyButtonsPanel.Size = new System.Drawing.Size(515, 31);
            this.eduBuyButtonsPanel.TabIndex = 1;
            // 
            // sadPrototype
            // 
            this.sadPrototype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sadPrototype.Enabled = false;
            this.sadPrototype.Location = new System.Drawing.Point(0, 0);
            this.sadPrototype.Name = "sadPrototype";
            this.sadPrototype.Size = new System.Drawing.Size(515, 31);
            this.sadPrototype.TabIndex = 1;
            this.sadPrototype.Tag = "sad";
            this.sadPrototype.Text = "Unable To Buy";
            this.sadPrototype.UseVisualStyleBackColor = true;
            this.sadPrototype.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 31);
            this.button3.TabIndex = 0;
            this.button3.Tag = "2";
            this.button3.Text = "Buy 1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 31);
            this.button2.TabIndex = 0;
            this.button2.Tag = "1";
            this.button2.Text = "Buy 1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 0;
            this.button1.Tag = "0";
            this.button1.Text = "Buy 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(6, 118);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(304, 15);
            this.costLabel.TabIndex = 0;
            this.costLabel.Tag = "3";
            this.costLabel.Text = "Cost of one unit: Education: 1000, Science: 0, Grants: 0";
            // 
            // youGainThisUnitLabel
            // 
            this.youGainThisUnitLabel.AutoSize = true;
            this.youGainThisUnitLabel.Location = new System.Drawing.Point(6, 76);
            this.youGainThisUnitLabel.Name = "youGainThisUnitLabel";
            this.youGainThisUnitLabel.Size = new System.Drawing.Size(231, 15);
            this.youGainThisUnitLabel.TabIndex = 0;
            this.youGainThisUnitLabel.Tag = "2";
            this.youGainThisUnitLabel.Text = "You gain 0 units of this type every second.";
            // 
            // allUnitsOfThisTypeProduceLabel
            // 
            this.allUnitsOfThisTypeProduceLabel.AutoSize = true;
            this.allUnitsOfThisTypeProduceLabel.Location = new System.Drawing.Point(6, 46);
            this.allUnitsOfThisTypeProduceLabel.Name = "allUnitsOfThisTypeProduceLabel";
            this.allUnitsOfThisTypeProduceLabel.Size = new System.Drawing.Size(298, 15);
            this.allUnitsOfThisTypeProduceLabel.TabIndex = 0;
            this.allUnitsOfThisTypeProduceLabel.Tag = "1";
            this.allUnitsOfThisTypeProduceLabel.Text = "All units of this type produce: 0 Lecturers every second";
            // 
            // thisUnitProducesLabel
            // 
            this.thisUnitProducesLabel.AutoSize = true;
            this.thisUnitProducesLabel.Location = new System.Drawing.Point(6, 22);
            this.thisUnitProducesLabel.Name = "thisUnitProducesLabel";
            this.thisUnitProducesLabel.Size = new System.Drawing.Size(269, 15);
            this.thisUnitProducesLabel.TabIndex = 0;
            this.thisUnitProducesLabel.Tag = "0";
            this.thisUnitProducesLabel.Text = "This unit xxx produces: 2 Lecturers every second";
            // 
            // sciencePage
            // 
            this.sciencePage.Controls.Add(this.splitContainer2);
            this.sciencePage.Location = new System.Drawing.Point(4, 22);
            this.sciencePage.Name = "sciencePage";
            this.sciencePage.Padding = new System.Windows.Forms.Padding(3);
            this.sciencePage.Size = new System.Drawing.Size(771, 443);
            this.sciencePage.TabIndex = 1;
            this.sciencePage.Text = "SCIENCE";
            this.sciencePage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.scienceListView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(765, 437);
            this.splitContainer2.SplitterDistance = 225;
            this.splitContainer2.TabIndex = 1;
            // 
            // scienceListView
            // 
            this.scienceListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.scienceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewItem13.Tag = "0";
            listViewItem14.Tag = "1";
            listViewItem15.Tag = "2";
            this.scienceListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.scienceListView.Location = new System.Drawing.Point(3, 3);
            this.scienceListView.MultiSelect = false;
            this.scienceListView.Name = "scienceListView";
            this.scienceListView.Size = new System.Drawing.Size(219, 433);
            this.scienceListView.TabIndex = 0;
            this.scienceListView.UseCompatibleStateImageBehavior = false;
            this.scienceListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "0";
            this.columnHeader1.Text = "Unit";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "1";
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 77;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sciUpgradeButtonsPanel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.sciBuyButtonsPanel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 431);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // sciUpgradeButtonsPanel
            // 
            this.sciUpgradeButtonsPanel.Controls.Add(this.button4);
            this.sciUpgradeButtonsPanel.Controls.Add(this.button5);
            this.sciUpgradeButtonsPanel.Controls.Add(this.button6);
            this.sciUpgradeButtonsPanel.Controls.Add(this.button21);
            this.sciUpgradeButtonsPanel.Location = new System.Drawing.Point(9, 327);
            this.sciUpgradeButtonsPanel.Name = "sciUpgradeButtonsPanel";
            this.sciUpgradeButtonsPanel.Size = new System.Drawing.Size(515, 31);
            this.sciUpgradeButtonsPanel.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(515, 31);
            this.button4.TabIndex = 5;
            this.button4.Tag = "sad";
            this.button4.Text = "Unable To Buy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 31);
            this.button5.TabIndex = 2;
            this.button5.Tag = "2";
            this.button5.Text = "Buy 1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(116, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 31);
            this.button6.TabIndex = 3;
            this.button6.Tag = "1";
            this.button6.Text = "Buy 1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(0, 0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(110, 31);
            this.button21.TabIndex = 4;
            this.button21.Tag = "0";
            this.button21.Text = "Buy 1";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 15);
            this.label1.TabIndex = 2;
            this.label1.Tag = "6";
            this.label1.Text = "Cost of an upgrade: Education: 10000, Science: 0, Grants: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 15);
            this.label2.TabIndex = 3;
            this.label2.Tag = "5";
            this.label2.Text = "You currently have 0 upgrades.";
            // 
            // sciBuyButtonsPanel
            // 
            this.sciBuyButtonsPanel.Controls.Add(this.button7);
            this.sciBuyButtonsPanel.Controls.Add(this.button8);
            this.sciBuyButtonsPanel.Controls.Add(this.button9);
            this.sciBuyButtonsPanel.Controls.Add(this.button20);
            this.sciBuyButtonsPanel.Location = new System.Drawing.Point(9, 148);
            this.sciBuyButtonsPanel.Name = "sciBuyButtonsPanel";
            this.sciBuyButtonsPanel.Size = new System.Drawing.Size(515, 31);
            this.sciBuyButtonsPanel.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(515, 31);
            this.button7.TabIndex = 5;
            this.button7.Tag = "sad";
            this.button7.Text = "Unable To Buy";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(307, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 31);
            this.button8.TabIndex = 2;
            this.button8.Tag = "2";
            this.button8.Text = "Buy 1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(116, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 31);
            this.button9.TabIndex = 3;
            this.button9.Tag = "1";
            this.button9.Text = "Buy 1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(0, 0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(110, 31);
            this.button20.TabIndex = 4;
            this.button20.Tag = "0";
            this.button20.Text = "Buy 1";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 15);
            this.label4.TabIndex = 0;
            this.label4.Tag = "3";
            this.label4.Text = "Cost of one unit: Education: 1000, Science: 0, Grants: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 15);
            this.label5.TabIndex = 0;
            this.label5.Tag = "2";
            this.label5.Text = "You gain 0 units of this type every second.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 15);
            this.label6.TabIndex = 0;
            this.label6.Tag = "1";
            this.label6.Text = "All units of this type produce: 0 Lecturers every second";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 15);
            this.label7.TabIndex = 0;
            this.label7.Tag = "0";
            this.label7.Text = "This unit xxx produces: 2 Lecturers every second";
            // 
            // grantsPage
            // 
            this.grantsPage.Controls.Add(this.splitContainer3);
            this.grantsPage.Location = new System.Drawing.Point(4, 22);
            this.grantsPage.Name = "grantsPage";
            this.grantsPage.Padding = new System.Windows.Forms.Padding(3);
            this.grantsPage.Size = new System.Drawing.Size(771, 443);
            this.grantsPage.TabIndex = 2;
            this.grantsPage.Text = "GRANTS";
            this.grantsPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grantsListView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(765, 437);
            this.splitContainer3.SplitterDistance = 225;
            this.splitContainer3.TabIndex = 1;
            // 
            // grantsListView
            // 
            this.grantsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.grantsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            listViewItem16.Tag = "0";
            listViewItem17.Tag = "1";
            listViewItem18.Tag = "2";
            this.grantsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.grantsListView.Location = new System.Drawing.Point(3, 3);
            this.grantsListView.MultiSelect = false;
            this.grantsListView.Name = "grantsListView";
            this.grantsListView.Size = new System.Drawing.Size(219, 433);
            this.grantsListView.TabIndex = 0;
            this.grantsListView.UseCompatibleStateImageBehavior = false;
            this.grantsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "0";
            this.columnHeader3.Text = "Unit";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "1";
            this.columnHeader4.Text = "Count";
            this.columnHeader4.Width = 77;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.graUpgradeButtonsPanel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(label10);
            this.groupBox3.Controls.Add(this.graBuyButtonsPanel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 431);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // graUpgradeButtonsPanel
            // 
            this.graUpgradeButtonsPanel.Controls.Add(this.button10);
            this.graUpgradeButtonsPanel.Controls.Add(this.button11);
            this.graUpgradeButtonsPanel.Controls.Add(this.button12);
            this.graUpgradeButtonsPanel.Controls.Add(this.button23);
            this.graUpgradeButtonsPanel.Location = new System.Drawing.Point(9, 327);
            this.graUpgradeButtonsPanel.Name = "graUpgradeButtonsPanel";
            this.graUpgradeButtonsPanel.Size = new System.Drawing.Size(515, 31);
            this.graUpgradeButtonsPanel.TabIndex = 5;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(515, 31);
            this.button10.TabIndex = 5;
            this.button10.Tag = "sad";
            this.button10.Text = "Unable To Buy";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(307, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(208, 31);
            this.button11.TabIndex = 2;
            this.button11.Tag = "2";
            this.button11.Text = "Buy 1";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(116, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(179, 31);
            this.button12.TabIndex = 3;
            this.button12.Tag = "1";
            this.button12.Text = "Buy 1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(0, 0);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(110, 31);
            this.button23.TabIndex = 4;
            this.button23.Tag = "0";
            this.button23.Text = "Buy 1";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 15);
            this.label8.TabIndex = 2;
            this.label8.Tag = "6";
            this.label8.Text = "Cost of an upgrade: Education: 10000, Science: 0, Grants: 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 15);
            this.label9.TabIndex = 3;
            this.label9.Tag = "5";
            this.label9.Text = "You currently have 0 upgrades.";
            // 
            // graBuyButtonsPanel
            // 
            this.graBuyButtonsPanel.Controls.Add(this.button13);
            this.graBuyButtonsPanel.Controls.Add(this.button14);
            this.graBuyButtonsPanel.Controls.Add(this.button15);
            this.graBuyButtonsPanel.Controls.Add(this.button22);
            this.graBuyButtonsPanel.Location = new System.Drawing.Point(9, 148);
            this.graBuyButtonsPanel.Name = "graBuyButtonsPanel";
            this.graBuyButtonsPanel.Size = new System.Drawing.Size(515, 31);
            this.graBuyButtonsPanel.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(515, 31);
            this.button13.TabIndex = 5;
            this.button13.Tag = "sad";
            this.button13.Text = "Unable To Buy";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(307, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(208, 31);
            this.button14.TabIndex = 2;
            this.button14.Tag = "2";
            this.button14.Text = "Buy 1";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(116, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(179, 31);
            this.button15.TabIndex = 3;
            this.button15.Tag = "1";
            this.button15.Text = "Buy 1";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(0, 0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(110, 31);
            this.button22.TabIndex = 4;
            this.button22.Tag = "0";
            this.button22.Text = "Buy 1";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 15);
            this.label11.TabIndex = 0;
            this.label11.Tag = "3";
            this.label11.Text = "Cost of one unit: Education: 1000, Science: 0, Grants: 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 15);
            this.label12.TabIndex = 0;
            this.label12.Tag = "2";
            this.label12.Text = "You gain 0 units of this type every second.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 15);
            this.label13.TabIndex = 0;
            this.label13.Tag = "1";
            this.label13.Text = "All units of this type produce: 0 Lecturers every second";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 15);
            this.label14.TabIndex = 0;
            this.label14.Tag = "0";
            this.label14.Text = "don\'t mind this text, it can\'t be seen anyway";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // saveFileDialogBox
            // 
            this.saveFileDialogBox.DefaultExt = "xml";
            this.saveFileDialogBox.Filter = "XML files | *.xml";
            this.saveFileDialogBox.Title = "Choose Save File";
            // 
            // openFileDialogBox
            // 
            this.openFileDialogBox.DefaultExt = "xml";
            this.openFileDialogBox.Filter = "XML files | *.xml";
            this.openFileDialogBox.Title = "Choose a save game";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 522);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "This is exactly how life at MiNI looks like";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.educationPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.eduUpgradeButtonsPanel.ResumeLayout(false);
            this.eduBuyButtonsPanel.ResumeLayout(false);
            this.sciencePage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sciUpgradeButtonsPanel.ResumeLayout(false);
            this.sciBuyButtonsPanel.ResumeLayout(false);
            this.grantsPage.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.graUpgradeButtonsPanel.ResumeLayout(false);
            this.graBuyButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel educationCounter;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem startGameButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage educationPage;
        private System.Windows.Forms.TabPage sciencePage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView educationListView;
        private System.Windows.Forms.ColumnHeader unitHeader;
        private System.Windows.Forms.ColumnHeader countHeader;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage grantsPage;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton moreButton;
        private System.Windows.Forms.ToolStripStatusLabel timerLabel;
        private System.Windows.Forms.ToolStripStatusLabel grantsCounter;
        private System.Windows.Forms.ToolStripStatusLabel scienceCounter;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label youGainThisUnitLabel;
        private System.Windows.Forms.Label allUnitsOfThisTypeProduceLabel;
        private System.Windows.Forms.Label thisUnitProducesLabel;
        private System.Windows.Forms.Panel eduBuyButtonsPanel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView scienceListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListView grantsListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel eduUpgradeButtonsPanel;
        private System.Windows.Forms.Label upgradeCostLabel;
        private System.Windows.Forms.Label upgradesCountLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel sciUpgradeButtonsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel sciBuyButtonsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel graUpgradeButtonsPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel graBuyButtonsPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button sadPrototype;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogBox;
    }
}

