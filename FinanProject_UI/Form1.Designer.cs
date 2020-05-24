namespace FinanProject_UI
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p11 = new FinanProject_UI.UserControls.p1();
            this.p21 = new FinanProject_UI.UserControls.p2();
            this.p31 = new FinanProject_UI.UserControls.p3();
            this.p41 = new FinanProject_UI.UserControls.p4();
            this.p51 = new FinanProject_UI.UserControls.p5();
            this.p61 = new FinanProject_UI.UserControls.p6();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 99);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Opun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(593, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 93);
            this.button2.TabIndex = 2;
            this.button2.Text = "TAX Online";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Opun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(421, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 93);
            this.button1.TabIndex = 2;
            this.button1.Text = "WebSite";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("SOV_PleanJai", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(107, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "คำนวณภาษี";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1333, 141);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.p11);
            this.panel4.Controls.Add(this.p21);
            this.panel4.Controls.Add(this.p31);
            this.panel4.Controls.Add(this.p41);
            this.panel4.Controls.Add(this.p51);
            this.panel4.Controls.Add(this.p61);
            this.bunifuTransition2.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1333, 341);
            this.panel4.TabIndex = 3;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.bunifuTransition1.SetDecoration(this.button12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button12, BunifuAnimatorNS.DecorationType.None);
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Opun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(1068, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(265, 139);
            this.button12.TabIndex = 3;
            this.button12.Text = "กลุ่มที่ 5";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button11
            // 
            this.bunifuTransition1.SetDecoration(this.button11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button11, BunifuAnimatorNS.DecorationType.None);
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Opun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(871, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(191, 139);
            this.button11.TabIndex = 3;
            this.button11.Text = "กลุ่มที่ 4";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.bunifuTransition1.SetDecoration(this.button10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button10, BunifuAnimatorNS.DecorationType.None);
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Opun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(674, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(191, 139);
            this.button10.TabIndex = 3;
            this.button10.Text = "กลุ่มที่ 3";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button9
            // 
            this.bunifuTransition1.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Opun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(477, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(191, 139);
            this.button9.TabIndex = 3;
            this.button9.Text = "กลุ่มที่ 2";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.bunifuTransition1.SetDecoration(this.button8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button8, BunifuAnimatorNS.DecorationType.None);
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Opun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(280, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(191, 139);
            this.button8.TabIndex = 3;
            this.button8.Text = "กลุ่มที่ 1";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button7
            // 
            this.bunifuTransition1.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Opun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(83, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(191, 139);
            this.button7.TabIndex = 3;
            this.button7.Text = "คำนวณ";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button13
            // 
            this.bunifuTransition1.SetDecoration(this.button13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button13, BunifuAnimatorNS.DecorationType.None);
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Opun", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(1245, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(85, 89);
            this.button13.TabIndex = 3;
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // p11
            // 
            this.p11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
            this.p11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.p11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.p11, BunifuAnimatorNS.DecorationType.None);
            this.p11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p11.Location = new System.Drawing.Point(0, 0);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(1333, 341);
            this.p11.TabIndex = 5;
            // 
            // p21
            // 
            this.p21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.bunifuTransition1.SetDecoration(this.p21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.p21, BunifuAnimatorNS.DecorationType.None);
            this.p21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p21.Location = new System.Drawing.Point(0, 0);
            this.p21.Name = "p21";
            this.p21.Size = new System.Drawing.Size(1333, 341);
            this.p21.TabIndex = 4;
            // 
            // p31
            // 
            this.p31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bunifuTransition1.SetDecoration(this.p31, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.p31, BunifuAnimatorNS.DecorationType.None);
            this.p31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p31.Location = new System.Drawing.Point(0, 0);
            this.p31.Name = "p31";
            this.p31.Size = new System.Drawing.Size(1333, 341);
            this.p31.TabIndex = 3;
            // 
            // p41
            // 
            this.p41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.bunifuTransition1.SetDecoration(this.p41, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.p41, BunifuAnimatorNS.DecorationType.None);
            this.p41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p41.Location = new System.Drawing.Point(0, 0);
            this.p41.Name = "p41";
            this.p41.Size = new System.Drawing.Size(1333, 341);
            this.p41.TabIndex = 2;
            // 
            // p51
            // 
            this.p51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.p51, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.p51, BunifuAnimatorNS.DecorationType.None);
            this.p51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p51.Location = new System.Drawing.Point(0, 0);
            this.p51.Name = "p51";
            this.p51.Size = new System.Drawing.Size(1333, 341);
            this.p51.TabIndex = 1;
            // 
            // p61
            // 
            this.p61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTransition1.SetDecoration(this.p61, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.p61, BunifuAnimatorNS.DecorationType.None);
            this.p61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p61.Location = new System.Drawing.Point(0, 0);
            this.p61.Name = "p61";
            this.p61.Size = new System.Drawing.Size(1333, 341);
            this.p61.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 617);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel4;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private UserControls.p1 p11;
        private UserControls.p2 p21;
        private UserControls.p3 p31;
        private UserControls.p4 p41;
        private UserControls.p5 p51;
        private UserControls.p6 p61;
    }
}

