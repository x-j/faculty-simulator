namespace Faculty_Simulator {
    partial class OptionsForm {
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.productionTrackBar = new System.Windows.Forms.TrackBar();
            this.pricesTrackBar = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productionTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label1.Location = new System.Drawing.Point(12, 106);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Prices multiplier:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label2.Location = new System.Drawing.Point(12, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 15);
            label2.TabIndex = 0;
            label2.Text = "Production multiplier:";
            // 
            // productionTrackBar
            // 
            this.productionTrackBar.LargeChange = 1;
            this.productionTrackBar.Location = new System.Drawing.Point(15, 39);
            this.productionTrackBar.Maximum = 5;
            this.productionTrackBar.Minimum = 1;
            this.productionTrackBar.Name = "productionTrackBar";
            this.productionTrackBar.Size = new System.Drawing.Size(256, 45);
            this.productionTrackBar.TabIndex = 1;
            this.productionTrackBar.Value = 1;
            // 
            // pricesTrackBar
            // 
            this.pricesTrackBar.LargeChange = 1;
            this.pricesTrackBar.Location = new System.Drawing.Point(15, 124);
            this.pricesTrackBar.Maximum = 5;
            this.pricesTrackBar.Minimum = 1;
            this.pricesTrackBar.Name = "pricesTrackBar";
            this.pricesTrackBar.Size = new System.Drawing.Size(256, 45);
            this.pricesTrackBar.TabIndex = 1;
            this.pricesTrackBar.Value = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 71);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(241, 13);
            label3.TabIndex = 2;
            label3.Text = "1                 2                 3                 4                 5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 156);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(241, 13);
            label4.TabIndex = 2;
            label4.Text = "1                 2                 3                 4                 5";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.pricesTrackBar);
            this.Controls.Add(this.productionTrackBar);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsForm";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.productionTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar productionTrackBar;
        private System.Windows.Forms.TrackBar pricesTrackBar;
    }
}