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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pool));
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.btnTogglePool = new System.Windows.Forms.Button();
            this.btnToggleAlarm = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.trackBarTemperature.Location = new System.Drawing.Point(554, 319);
            this.trackBarTemperature.Maximum = 70;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(367, 56);
            this.trackBarTemperature.TabIndex = 3;
            this.trackBarTemperature.Tag = "";
            this.trackBarTemperature.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarTemperature.Value = 10;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            // 
            // btnTogglePool
            // 
            this.btnTogglePool.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTogglePool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTogglePool.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTogglePool.Location = new System.Drawing.Point(773, 103);
            this.btnTogglePool.Name = "btnTogglePool";
            this.btnTogglePool.Size = new System.Drawing.Size(148, 36);
            this.btnTogglePool.TabIndex = 4;
            this.btnTogglePool.Text = "Water Supply: On/Off";
            this.btnTogglePool.UseVisualStyleBackColor = false;
            this.btnTogglePool.Click += new System.EventHandler(this.btnToggleWaterSupply_Click);
            // 
            // btnToggleAlarm
            // 
            this.btnToggleAlarm.BackColor = System.Drawing.Color.Red;
            this.btnToggleAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleAlarm.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleAlarm.Location = new System.Drawing.Point(554, 103);
            this.btnToggleAlarm.Name = "btnToggleAlarm";
            this.btnToggleAlarm.Size = new System.Drawing.Size(124, 36);
            this.btnToggleAlarm.TabIndex = 5;
            this.btnToggleAlarm.Text = "Alarm: On/Off";
            this.btnToggleAlarm.UseVisualStyleBackColor = false;
            this.btnToggleAlarm.Click += new System.EventHandler(this.btnToggleAlarm_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(607, 292);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(71, 24);
            this.lblTemperature.TabIndex = 8;
            this.lblTemperature.Text = "Temperature";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectPalaceOfZeus.Properties.Resources.withWater;
            this.pictureBox2.Location = new System.Drawing.Point(175, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 295);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProjectPalaceOfZeus.Properties.Resources.pc;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1097, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(194, 213);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 10;
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage1.Location = new System.Drawing.Point(194, 234);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(10, 16);
            this.lblMessage1.TabIndex = 11;
            this.lblMessage1.Text = "l";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 586);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnTogglePool);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.btnToggleAlarm);
            this.Controls.Add(this.trackBarTemperature);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pool_FormClosing);
            this.Load += new System.EventHandler(this.Pool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.Button btnTogglePool;
        private System.Windows.Forms.Button btnToggleAlarm;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Timer timer1;
    }
}