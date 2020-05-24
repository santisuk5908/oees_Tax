namespace FinanProject_UI
{
    partial class ps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ps));
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInternetExporerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshButt = new System.Windows.Forms.Button();
            this.searchButt = new System.Windows.Forms.Button();
            this.forwardButt = new System.Windows.Forms.Button();
            this.backButt = new System.Windows.Forms.Button();
            this.menuMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 144);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(1338, 550);
            this.webBrowser3.TabIndex = 8;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.BackColor = System.Drawing.Color.GhostWhite;
            this.txtURL.Font = new System.Drawing.Font("FC Lamoon", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(204, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(1035, 30);
            this.txtURL.TabIndex = 5;
            this.txtURL.Text = "https://www.krungsri.com/bank/th/plearn-plearn/tax-2563.html";
            this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtURL_KeyPress);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // homeSettingToolStripMenuItem
            // 
            this.homeSettingToolStripMenuItem.Name = "homeSettingToolStripMenuItem";
            this.homeSettingToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.homeSettingToolStripMenuItem.Text = "Home setting";
            // 
            // openInternetExporerToolStripMenuItem
            // 
            this.openInternetExporerToolStripMenuItem.Name = "openInternetExporerToolStripMenuItem";
            this.openInternetExporerToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.openInternetExporerToolStripMenuItem.Text = "Open Internet Exporer";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.newWindowToolStripMenuItem.Text = "New Window";
            // 
            // menuMenu
            // 
            this.menuMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.printToolStripMenuItem,
            this.openInternetExporerToolStripMenuItem,
            this.homeSettingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(252, 200);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 694);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 45);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.refreshButt);
            this.panel1.Controls.Add(this.searchButt);
            this.panel1.Controls.Add(this.forwardButt);
            this.panel1.Controls.Add(this.backButt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 144);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(631, 51);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(85, 85);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1045, 59);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(79, 79);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(912, 59);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(79, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1281, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-25, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(348, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // refreshButt
            // 
            this.refreshButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButt.BackgroundImage")));
            this.refreshButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshButt.Location = new System.Drawing.Point(134, 9);
            this.refreshButt.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButt.Name = "refreshButt";
            this.refreshButt.Size = new System.Drawing.Size(45, 42);
            this.refreshButt.TabIndex = 3;
            this.refreshButt.UseVisualStyleBackColor = true;
            this.refreshButt.Click += new System.EventHandler(this.refreshButt_Click);
            // 
            // searchButt
            // 
            this.searchButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButt.BackgroundImage")));
            this.searchButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButt.Location = new System.Drawing.Point(1264, 8);
            this.searchButt.Margin = new System.Windows.Forms.Padding(4);
            this.searchButt.Name = "searchButt";
            this.searchButt.Size = new System.Drawing.Size(45, 42);
            this.searchButt.TabIndex = 2;
            this.searchButt.UseVisualStyleBackColor = true;
            this.searchButt.Click += new System.EventHandler(this.searchButt_Click);
            // 
            // forwardButt
            // 
            this.forwardButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forwardButt.BackgroundImage")));
            this.forwardButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forwardButt.Location = new System.Drawing.Point(81, 9);
            this.forwardButt.Margin = new System.Windows.Forms.Padding(4);
            this.forwardButt.Name = "forwardButt";
            this.forwardButt.Size = new System.Drawing.Size(45, 42);
            this.forwardButt.TabIndex = 1;
            this.forwardButt.UseVisualStyleBackColor = true;
            this.forwardButt.Click += new System.EventHandler(this.forwardButt_Click);
            // 
            // backButt
            // 
            this.backButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButt.BackgroundImage")));
            this.backButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButt.Location = new System.Drawing.Point(28, 9);
            this.backButt.Margin = new System.Windows.Forms.Padding(4);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(45, 42);
            this.backButt.TabIndex = 0;
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // ps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 739);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ps";
            this.Text = "ps";
            this.Load += new System.EventHandler(this.ps_Load);
            this.menuMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button refreshButt;
        private System.Windows.Forms.Button searchButt;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInternetExporerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.Button forwardButt;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuMenu;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}