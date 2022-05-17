namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.textlat = new System.Windows.Forms.TextBox();
            this.textlongt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textw = new System.Windows.Forms.TextBox();
            this.textm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.IDData = new System.Windows.Forms.Label();
            this.iden = new System.Windows.Forms.Label();
            this.Débit = new System.Windows.Forms.Label();
            this.Matricule = new System.Windows.Forms.Label();
            this.Wilaya = new System.Windows.Forms.Label();
            this.MatriculeData = new System.Windows.Forms.Label();
            this.WilayaData = new System.Windows.Forms.Label();
            this.DébitData = new System.Windows.Forms.Label();
            this.Quiti = new System.Windows.Forms.Label();
            this.showdata = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.showdata.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(231, 626);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(231, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1003, 626);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            // 
            // textlat
            // 
            this.textlat.Location = new System.Drawing.Point(55, 190);
            this.textlat.Name = "textlat";
            this.textlat.Size = new System.Drawing.Size(120, 23);
            this.textlat.TabIndex = 2;
            // 
            // textlongt
            // 
            this.textlongt.Location = new System.Drawing.Point(55, 246);
            this.textlongt.Name = "textlongt";
            this.textlongt.Size = new System.Drawing.Size(120, 23);
            this.textlongt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "GPL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textw);
            this.panel1.Controls.Add(this.textm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(257, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 286);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(289, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textw
            // 
            this.textw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textw.Location = new System.Drawing.Point(498, 118);
            this.textw.Name = "textw";
            this.textw.Size = new System.Drawing.Size(120, 23);
            this.textw.TabIndex = 4;
            // 
            // textm
            // 
            this.textm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textm.Location = new System.Drawing.Point(498, 82);
            this.textm.Name = "textm";
            this.textm.Size = new System.Drawing.Size(120, 23);
            this.textm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wilaya";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "GN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IDData
            // 
            this.IDData.AutoSize = true;
            this.IDData.Location = new System.Drawing.Point(742, 33);
            this.IDData.Name = "IDData";
            this.IDData.Size = new System.Drawing.Size(0, 15);
            this.IDData.TabIndex = 5;
            // 
            // iden
            // 
            this.iden.AutoSize = true;
            this.iden.Location = new System.Drawing.Point(108, 34);
            this.iden.Name = "iden";
            this.iden.Size = new System.Drawing.Size(18, 15);
            this.iden.TabIndex = 0;
            this.iden.Text = "ID";
            // 
            // Débit
            // 
            this.Débit.AutoSize = true;
            this.Débit.Location = new System.Drawing.Point(108, 136);
            this.Débit.Name = "Débit";
            this.Débit.Size = new System.Drawing.Size(35, 15);
            this.Débit.TabIndex = 6;
            this.Débit.Text = "Débit";
            // 
            // Matricule
            // 
            this.Matricule.AutoSize = true;
            this.Matricule.Location = new System.Drawing.Point(108, 68);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(57, 15);
            this.Matricule.TabIndex = 7;
            this.Matricule.Text = "Matricule";
            // 
            // Wilaya
            // 
            this.Wilaya.AutoSize = true;
            this.Wilaya.Location = new System.Drawing.Point(108, 103);
            this.Wilaya.Name = "Wilaya";
            this.Wilaya.Size = new System.Drawing.Size(42, 15);
            this.Wilaya.TabIndex = 8;
            this.Wilaya.Text = "Wilaya";
            // 
            // MatriculeData
            // 
            this.MatriculeData.AutoSize = true;
            this.MatriculeData.Location = new System.Drawing.Point(742, 68);
            this.MatriculeData.Name = "MatriculeData";
            this.MatriculeData.Size = new System.Drawing.Size(0, 15);
            this.MatriculeData.TabIndex = 9;
            // 
            // WilayaData
            // 
            this.WilayaData.AutoSize = true;
            this.WilayaData.Location = new System.Drawing.Point(742, 103);
            this.WilayaData.Name = "WilayaData";
            this.WilayaData.Size = new System.Drawing.Size(0, 15);
            this.WilayaData.TabIndex = 10;
            // 
            // DébitData
            // 
            this.DébitData.AutoSize = true;
            this.DébitData.Location = new System.Drawing.Point(742, 136);
            this.DébitData.Name = "DébitData";
            this.DébitData.Size = new System.Drawing.Size(0, 15);
            this.DébitData.TabIndex = 11;
            // 
            // Quiti
            // 
            this.Quiti.Location = new System.Drawing.Point(0, 0);
            this.Quiti.Name = "Quiti";
            this.Quiti.Size = new System.Drawing.Size(100, 23);
            this.Quiti.TabIndex = 0;
            // 
            // showdata
            // 
            this.showdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showdata.Controls.Add(this.label3);
            this.showdata.Controls.Add(this.Quiti);
            this.showdata.Controls.Add(this.DébitData);
            this.showdata.Controls.Add(this.WilayaData);
            this.showdata.Controls.Add(this.MatriculeData);
            this.showdata.Controls.Add(this.Wilaya);
            this.showdata.Controls.Add(this.Matricule);
            this.showdata.Controls.Add(this.Débit);
            this.showdata.Controls.Add(this.iden);
            this.showdata.Controls.Add(this.IDData);
            this.showdata.Location = new System.Drawing.Point(231, 466);
            this.showdata.Name = "showdata";
            this.showdata.Size = new System.Drawing.Size(1003, 160);
            this.showdata.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(971, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 626);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textlongt);
            this.Controls.Add(this.textlat);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.showdata.ResumeLayout(false);
            this.showdata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private TextBox textlat;
        private TextBox textlongt;
        private Button button1;
        private Label IDData;
        private Panel showdata;
        private Label iden;
        private Label DébitData;
        private Label WilayaData;
        private Label MatriculeData;
        private Label Wilaya;
        private Label Matricule;
        private Label Débit;
        private Label Quiti;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox textw;
        private TextBox textm;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}