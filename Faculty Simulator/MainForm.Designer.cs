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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Senior lect");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("regular lect");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("junior");
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.educationCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.startGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.educationPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.educationListView = new System.Windows.Forms.ListView();
            this.unitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.educationGroupBox = new System.Windows.Forms.GroupBox();
            this.longLabelForEducationCostOfOneUpgrade = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.upgradeCountLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.upgrade3Button = new System.Windows.Forms.Button();
            this.buy3Button = new System.Windows.Forms.Button();
            this.upgrade2Button = new System.Windows.Forms.Button();
            this.upgrade1Button = new System.Windows.Forms.Button();
            this.buy2Button = new System.Windows.Forms.Button();
            this.buy1Button = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.educationCostLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.youObtainUnitsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.allUnitOfThisTypeProduceLabel = new System.Windows.Forms.Label();
            this.thisUnitProducesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sciencePage = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cannotButton1 = new System.Windows.Forms.Button();
            this.cannotButton2 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.educationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.educationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.educationCounter});
            this.statusStrip.Location = new System.Drawing.Point(0, 500);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(695, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // educationCounter
            // 
            this.educationCounter.Name = "educationCounter";
            this.educationCounter.Size = new System.Drawing.Size(82, 17);
            this.educationCounter.Text = "0 EDUCATION";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(695, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameButton});
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton.Text = "nice button";
            // 
            // startGameButton
            // 
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(132, 22);
            this.startGameButton.Text = "Start Game";
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.educationPage);
            this.tabControl.Controls.Add(this.sciencePage);
            this.tabControl.Location = new System.Drawing.Point(10, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(684, 469);
            this.tabControl.TabIndex = 2;
            // 
            // educationPage
            // 
            this.educationPage.Controls.Add(this.splitContainer1);
            this.educationPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.educationPage.Location = new System.Drawing.Point(4, 22);
            this.educationPage.Name = "educationPage";
            this.educationPage.Padding = new System.Windows.Forms.Padding(3);
            this.educationPage.Size = new System.Drawing.Size(676, 443);
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
            this.splitContainer1.Panel2.Controls.Add(this.educationGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(670, 437);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 0;
            // 
            // educationListView
            // 
            this.educationListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.educationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.unitHeader,
            this.countHeader});
            listViewItem4.Tag = "0";
            listViewItem5.Tag = "1";
            listViewItem6.Tag = "2";
            this.educationListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.educationListView.Location = new System.Drawing.Point(3, 9);
            this.educationListView.MultiSelect = false;
            this.educationListView.Name = "educationListView";
            this.educationListView.Size = new System.Drawing.Size(212, 427);
            this.educationListView.TabIndex = 0;
            this.educationListView.UseCompatibleStateImageBehavior = false;
            this.educationListView.View = System.Windows.Forms.View.Details;
            this.educationListView.SelectedIndexChanged += new System.EventHandler(educationListView_SelectedIndexChanged);
            // 
            // unitHeader
            // 
            this.unitHeader.Tag = "0";
            this.unitHeader.Text = "Unit";
            this.unitHeader.Width = 67;
            // 
            // countHeader
            // 
            this.countHeader.Tag = "1";
            this.countHeader.Text = "Count";
            this.countHeader.Width = 125;
            // 
            // educationGroupBox
            // 
            this.educationGroupBox.Controls.Add(this.cannotButton2);
            this.educationGroupBox.Controls.Add(this.cannotButton1);
            this.educationGroupBox.Controls.Add(this.longLabelForEducationCostOfOneUpgrade);
            this.educationGroupBox.Controls.Add(this.label18);
            this.educationGroupBox.Controls.Add(this.upgradeCountLabel);
            this.educationGroupBox.Controls.Add(this.label16);
            this.educationGroupBox.Controls.Add(this.label15);
            this.educationGroupBox.Controls.Add(this.upgrade3Button);
            this.educationGroupBox.Controls.Add(this.buy3Button);
            this.educationGroupBox.Controls.Add(this.upgrade2Button);
            this.educationGroupBox.Controls.Add(this.upgrade1Button);
            this.educationGroupBox.Controls.Add(this.buy2Button);
            this.educationGroupBox.Controls.Add(this.buy1Button);
            this.educationGroupBox.Controls.Add(this.label14);
            this.educationGroupBox.Controls.Add(this.label13);
            this.educationGroupBox.Controls.Add(this.label12);
            this.educationGroupBox.Controls.Add(this.label11);
            this.educationGroupBox.Controls.Add(this.label10);
            this.educationGroupBox.Controls.Add(this.educationCostLabel);
            this.educationGroupBox.Controls.Add(this.label8);
            this.educationGroupBox.Controls.Add(this.youObtainUnitsLabel);
            this.educationGroupBox.Controls.Add(this.label5);
            this.educationGroupBox.Controls.Add(this.allUnitOfThisTypeProduceLabel);
            this.educationGroupBox.Controls.Add(this.thisUnitProducesLabel);
            this.educationGroupBox.Controls.Add(this.label2);
            this.educationGroupBox.Controls.Add(this.label1);
            this.educationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.educationGroupBox.Location = new System.Drawing.Point(12, 11);
            this.educationGroupBox.Name = "educationGroupBox";
            this.educationGroupBox.Size = new System.Drawing.Size(419, 424);
            this.educationGroupBox.TabIndex = 0;
            this.educationGroupBox.TabStop = false;
            this.educationGroupBox.Text = "whatever";
            // 
            // longLabelForEducationCostOfOneUpgrade
            // 
            this.longLabelForEducationCostOfOneUpgrade.AutoSize = true;
            this.longLabelForEducationCostOfOneUpgrade.Location = new System.Drawing.Point(126, 342);
            this.longLabelForEducationCostOfOneUpgrade.Name = "longLabelForEducationCostOfOneUpgrade";
            this.longLabelForEducationCostOfOneUpgrade.Size = new System.Drawing.Size(224, 13);
            this.longLabelForEducationCostOfOneUpgrade.TabIndex = 17;
            this.longLabelForEducationCostOfOneUpgrade.Text = "10000 EDUCATION, 0 SCIENCE, 0 GRANTS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 342);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Cost of one upgrade:";
            // 
            // upgradeCountLabel
            // 
            this.upgradeCountLabel.AutoSize = true;
            this.upgradeCountLabel.Location = new System.Drawing.Point(107, 318);
            this.upgradeCountLabel.Name = "upgradeCountLabel";
            this.upgradeCountLabel.Size = new System.Drawing.Size(13, 13);
            this.upgradeCountLabel.TabIndex = 15;
            this.upgradeCountLabel.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 318);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Upgrades count: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(13, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Upgrades";
            // 
            // upgrade3Button
            // 
            this.upgrade3Button.Location = new System.Drawing.Point(217, 372);
            this.upgrade3Button.Name = "upgrade3Button";
            this.upgrade3Button.Size = new System.Drawing.Size(168, 33);
            this.upgrade3Button.TabIndex = 12;
            this.upgrade3Button.Text = "Upgrade 0";
            this.upgrade3Button.UseVisualStyleBackColor = true;
            // 
            // buy3Button
            // 
            this.buy3Button.Location = new System.Drawing.Point(217, 206);
            this.buy3Button.Name = "buy3Button";
            this.buy3Button.Size = new System.Drawing.Size(168, 33);
            this.buy3Button.TabIndex = 12;
            this.buy3Button.Tag = "2";
            this.buy3Button.Text = "Buy 0";
            this.buy3Button.UseVisualStyleBackColor = true;
            this.buy3Button.Click += new System.EventHandler(this.buy3Button_Click);
            // 
            // upgrade2Button
            // 
            this.upgrade2Button.Location = new System.Drawing.Point(101, 372);
            this.upgrade2Button.Name = "upgrade2Button";
            this.upgrade2Button.Size = new System.Drawing.Size(110, 33);
            this.upgrade2Button.TabIndex = 12;
            this.upgrade2Button.Text = "Upgrade 0";
            this.upgrade2Button.UseVisualStyleBackColor = true;
            // 
            // upgrade1Button
            // 
            this.upgrade1Button.Location = new System.Drawing.Point(16, 372);
            this.upgrade1Button.Name = "upgrade1Button";
            this.upgrade1Button.Size = new System.Drawing.Size(76, 33);
            this.upgrade1Button.TabIndex = 12;
            this.upgrade1Button.Text = "Upgrade 0";
            this.upgrade1Button.UseVisualStyleBackColor = true;
            // 
            // buy2Button
            // 
            this.buy2Button.Location = new System.Drawing.Point(101, 206);
            this.buy2Button.Name = "buy2Button";
            this.buy2Button.Size = new System.Drawing.Size(110, 33);
            this.buy2Button.TabIndex = 12;
            this.buy2Button.Tag = "1";
            this.buy2Button.Text = "Buy 0";
            this.buy2Button.UseVisualStyleBackColor = true;
            this.buy2Button.Click += new System.EventHandler(this.buy2Button_Click);
            // 
            // buy1Button
            // 
            this.buy1Button.Location = new System.Drawing.Point(16, 206);
            this.buy1Button.Name = "buy1Button";
            this.buy1Button.Size = new System.Drawing.Size(76, 33);
            this.buy1Button.TabIndex = 12;
            this.buy1Button.Tag = "0";
            this.buy1Button.Text = "Buy 1";
            this.buy1Button.UseVisualStyleBackColor = true;
            this.buy1Button.Click += new System.EventHandler(this.buy1Button_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(210, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "GRANTS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "SCIENCE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "EDUCATION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "0";
            // 
            // educationCostLabel
            // 
            this.educationCostLabel.AutoSize = true;
            this.educationCostLabel.Location = new System.Drawing.Point(180, 130);
            this.educationCostLabel.Name = "educationCostLabel";
            this.educationCostLabel.Size = new System.Drawing.Size(31, 13);
            this.educationCostLabel.TabIndex = 8;
            this.educationCostLabel.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "The cost of one unit of this type is: ";
            // 
            // youObtainUnitsLabel
            // 
            this.youObtainUnitsLabel.AutoSize = true;
            this.youObtainUnitsLabel.Location = new System.Drawing.Point(70, 85);
            this.youObtainUnitsLabel.Name = "youObtainUnitsLabel";
            this.youObtainUnitsLabel.Size = new System.Drawing.Size(159, 13);
            this.youObtainUnitsLabel.TabIndex = 5;
            this.youObtainUnitsLabel.Text = "0 units of this type every second";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "You obtain ";
            // 
            // allUnitOfThisTypeProduceLabel
            // 
            this.allUnitOfThisTypeProduceLabel.AutoSize = true;
            this.allUnitOfThisTypeProduceLabel.Location = new System.Drawing.Point(163, 49);
            this.allUnitOfThisTypeProduceLabel.Name = "allUnitOfThisTypeProduceLabel";
            this.allUnitOfThisTypeProduceLabel.Size = new System.Drawing.Size(13, 13);
            this.allUnitOfThisTypeProduceLabel.TabIndex = 3;
            this.allUnitOfThisTypeProduceLabel.Text = "0";
            // 
            // thisUnitProducesLabel
            // 
            this.thisUnitProducesLabel.AutoSize = true;
            this.thisUnitProducesLabel.Location = new System.Drawing.Point(118, 25);
            this.thisUnitProducesLabel.Name = "thisUnitProducesLabel";
            this.thisUnitProducesLabel.Size = new System.Drawing.Size(13, 13);
            this.thisUnitProducesLabel.TabIndex = 2;
            this.thisUnitProducesLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "All units of this type produce: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This unit produces: ";
            // 
            // sciencePage
            // 
            this.sciencePage.Location = new System.Drawing.Point(4, 22);
            this.sciencePage.Name = "sciencePage";
            this.sciencePage.Padding = new System.Windows.Forms.Padding(3);
            this.sciencePage.Size = new System.Drawing.Size(676, 443);
            this.sciencePage.TabIndex = 1;
            this.sciencePage.Text = "SCIENCE";
            this.sciencePage.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cannotButton1
            // 
            this.cannotButton1.Enabled = false;
            this.cannotButton1.Location = new System.Drawing.Point(16, 206);
            this.cannotButton1.Name = "cannotButton1";
            this.cannotButton1.Size = new System.Drawing.Size(195, 33);
            this.cannotButton1.TabIndex = 18;
            this.cannotButton1.Text = "Cannot Buy";
            this.cannotButton1.UseVisualStyleBackColor = true;
            this.cannotButton1.Visible = false;
            // 
            // cannotButton2
            // 
            this.cannotButton2.Enabled = false;
            this.cannotButton2.Location = new System.Drawing.Point(17, 372);
            this.cannotButton2.Name = "cannotButton2";
            this.cannotButton2.Size = new System.Drawing.Size(195, 33);
            this.cannotButton2.TabIndex = 18;
            this.cannotButton2.Text = "Cannot Upgrade";
            this.cannotButton2.UseVisualStyleBackColor = true;
            this.cannotButton2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 522);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
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
            this.educationGroupBox.ResumeLayout(false);
            this.educationGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox educationGroupBox;
        private System.Windows.Forms.Button buy3Button;
        private System.Windows.Forms.Button buy2Button;
        private System.Windows.Forms.Button buy1Button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label educationCostLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label youObtainUnitsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label allUnitOfThisTypeProduceLabel;
        private System.Windows.Forms.Label thisUnitProducesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label longLabelForEducationCostOfOneUpgrade;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label upgradeCountLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button upgrade3Button;
        private System.Windows.Forms.Button upgrade2Button;
        private System.Windows.Forms.Button upgrade1Button;
        private System.Windows.Forms.Button cannotButton2;
        private System.Windows.Forms.Button cannotButton1;
    }
}

