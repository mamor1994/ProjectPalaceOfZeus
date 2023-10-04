namespace ProjectPalaceOfZeus
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onLightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offLightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onTvToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offTvToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.curtainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onCurtainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offCurtainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.lightsToolStripMenuItem,
            this.tVToolStripMenuItem,
            this.curtainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(129, 495);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.AutoToolTip = true;
            this.actionsToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.actionsToolStripMenuItem.Enabled = false;
            this.actionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.actionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(116, 42);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // lightsToolStripMenuItem
            // 
            this.lightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onLightsToolStripMenuItem,
            this.offLightsToolStripMenuItem});
            this.lightsToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lightsToolStripMenuItem.Name = "lightsToolStripMenuItem";
            this.lightsToolStripMenuItem.Size = new System.Drawing.Size(116, 33);
            this.lightsToolStripMenuItem.Text = "&Lights";
            // 
            // onLightsToolStripMenuItem
            // 
            this.onLightsToolStripMenuItem.Image = global::ProjectPalaceOfZeus.Properties.Resources.icon_on;
            this.onLightsToolStripMenuItem.Name = "onLightsToolStripMenuItem";
            this.onLightsToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.onLightsToolStripMenuItem.Text = "&On";
            this.onLightsToolStripMenuItem.Click += new System.EventHandler(this.onLightsToolStripMenuItem_Click);
            // 
            // offLightsToolStripMenuItem
            // 
            this.offLightsToolStripMenuItem.Image = global::ProjectPalaceOfZeus.Properties.Resources.icon_off;
            this.offLightsToolStripMenuItem.Name = "offLightsToolStripMenuItem";
            this.offLightsToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.offLightsToolStripMenuItem.Text = "&Off";
            this.offLightsToolStripMenuItem.Click += new System.EventHandler(this.offLightsToolStripMenuItem_Click);
            // 
            // tVToolStripMenuItem
            // 
            this.tVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onTvToolStripMenuItem1,
            this.offTvToolStripMenuItem1});
            this.tVToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tVToolStripMenuItem.Name = "tVToolStripMenuItem";
            this.tVToolStripMenuItem.Size = new System.Drawing.Size(116, 33);
            this.tVToolStripMenuItem.Text = "&TV";
            // 
            // onTvToolStripMenuItem1
            // 
            this.onTvToolStripMenuItem1.Image = global::ProjectPalaceOfZeus.Properties.Resources.tv_on;
            this.onTvToolStripMenuItem1.Name = "onTvToolStripMenuItem1";
            this.onTvToolStripMenuItem1.Size = new System.Drawing.Size(128, 34);
            this.onTvToolStripMenuItem1.Text = "&On";
            this.onTvToolStripMenuItem1.Click += new System.EventHandler(this.onTvToolStripMenuItem1_Click);
            // 
            // offTvToolStripMenuItem1
            // 
            this.offTvToolStripMenuItem1.Image = global::ProjectPalaceOfZeus.Properties.Resources.tv_off;
            this.offTvToolStripMenuItem1.Name = "offTvToolStripMenuItem1";
            this.offTvToolStripMenuItem1.Size = new System.Drawing.Size(128, 34);
            this.offTvToolStripMenuItem1.Text = "&Off";
            this.offTvToolStripMenuItem1.Click += new System.EventHandler(this.offTvToolStripMenuItem_Click);
            // 
            // curtainToolStripMenuItem
            // 
            this.curtainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onCurtainToolStripMenuItem,
            this.offCurtainToolStripMenuItem});
            this.curtainToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 10.8F);
            this.curtainToolStripMenuItem.Name = "curtainToolStripMenuItem";
            this.curtainToolStripMenuItem.Size = new System.Drawing.Size(116, 33);
            this.curtainToolStripMenuItem.Text = "&Curtain";
            // 
            // onCurtainToolStripMenuItem
            // 
            this.onCurtainToolStripMenuItem.Image = global::ProjectPalaceOfZeus.Properties.Resources.curtain_off;
            this.onCurtainToolStripMenuItem.Name = "onCurtainToolStripMenuItem";
            this.onCurtainToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.onCurtainToolStripMenuItem.Text = "&Open";
            this.onCurtainToolStripMenuItem.Click += new System.EventHandler(this.onCurtainToolStripMenuItem_Click_1);
            // 
            // offCurtainToolStripMenuItem
            // 
            this.offCurtainToolStripMenuItem.Image = global::ProjectPalaceOfZeus.Properties.Resources.curtain_on;
            this.offCurtainToolStripMenuItem.Name = "offCurtainToolStripMenuItem";
            this.offCurtainToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.offCurtainToolStripMenuItem.Text = "&Close";
            this.offCurtainToolStripMenuItem.Click += new System.EventHandler(this.offCurtainToolStripMenuItem_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.Image = global::ProjectPalaceOfZeus.Properties.Resources.episkepths;
            this.pictureBox2.Location = new System.Drawing.Point(0, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 305);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProjectPalaceOfZeus.Properties.Resources.room1;
            this.pictureBox1.Location = new System.Drawing.Point(129, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(828, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 495);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Room_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onLightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offLightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onTvToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem offTvToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem curtainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onCurtainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offCurtainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

