namespace ProjectPalaceOfZeus
{
    partial class Pool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pool));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.btnTogglePool = new System.Windows.Forms.Button();
            this.btnToggleAlarm = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProjectPalaceOfZeus.Properties.Resources.withWater;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.trackBarTemperature.Location = new System.Drawing.Point(19, 518);
            this.trackBarTemperature.Maximum = 70;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(842, 56);
            this.trackBarTemperature.TabIndex = 3;
            this.trackBarTemperature.Value = 10;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            // 
            // btnTogglePool
            // 
            this.btnTogglePool.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTogglePool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTogglePool.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTogglePool.Location = new System.Drawing.Point(19, 374);
            this.btnTogglePool.Name = "btnTogglePool";
            this.btnTogglePool.Size = new System.Drawing.Size(227, 57);
            this.btnTogglePool.TabIndex = 4;
            this.btnTogglePool.Text = "Water Supply: On/Off";
            this.btnTogglePool.UseVisualStyleBackColor = false;
            this.btnTogglePool.Click += new System.EventHandler(this.btnToggleWaterSupply_Click);
            // 
            // btnToggleAlarm
            // 
            this.btnToggleAlarm.BackColor = System.Drawing.Color.Red;
            this.btnToggleAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleAlarm.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleAlarm.Location = new System.Drawing.Point(19, 298);
            this.btnToggleAlarm.Name = "btnToggleAlarm";
            this.btnToggleAlarm.Size = new System.Drawing.Size(227, 57);
            this.btnToggleAlarm.TabIndex = 5;
            this.btnToggleAlarm.Text = "Alarm: On/Off";
            this.btnToggleAlarm.UseVisualStyleBackColor = false;
            this.btnToggleAlarm.Click += new System.EventHandler(this.btnToggleAlarm_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.SystemColors.Info;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F);
            this.lblTemperature.Location = new System.Drawing.Point(21, 456);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(117, 37);
            this.lblTemperature.TabIndex = 8;
            this.lblTemperature.Text = "Temperature";
            // 
            // Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 586);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.btnToggleAlarm);
            this.Controls.Add(this.btnTogglePool);
            this.Controls.Add(this.trackBarTemperature);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.Button btnTogglePool;
        private System.Windows.Forms.Button btnToggleAlarm;
        private System.Windows.Forms.Label lblTemperature;
    }
}