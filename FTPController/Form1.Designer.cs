namespace FTPController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iTalk_TabControl1 = new iTalk_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDownload = new Ambiance.Ambiance_Button_1();
            this.ambiance_Button_21 = new Ambiance.Ambiance_Button_2();
            this.iTalk_ProgressBar1 = new iTalk_ProgressBar();
            this.lstboxFiles = new System.Windows.Forms.ListBox();
            this.iTalk_Button_21 = new iTalk_Button_2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ambiance_Button_22 = new Ambiance.Ambiance_Button_2();
            this.iTalk_ProgressBar2 = new iTalk_ProgressBar();
            this.iTalk_Separator1 = new iTalk_Separator();
            this.iTalk_HeaderLabel1 = new iTalk_HeaderLabel();
            this.iTalk_Button_22 = new iTalk_Button_2();
            this.iTalk_Label1 = new iTalk_Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.iTalk_Label7 = new iTalk_Label();
            this.ambiance_ComboBox1 = new Ambiance.Ambiance_ComboBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.iTalk_Label6 = new iTalk_Label();
            this.iTalk_Button_23 = new iTalk_Button_2();
            this.iTalk_Label5 = new iTalk_Label();
            this.iTalk_Label4 = new iTalk_Label();
            this.iTalk_Label3 = new iTalk_Label();
            this.iTalk_Label2 = new iTalk_Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iTalk_HeaderLabel2 = new iTalk_HeaderLabel();
            this.iTalk_Label9 = new iTalk_Label();
            this.ambiance_LinkLabel1 = new Ambiance.Ambiance_LinkLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ambiance_LinkLabel2 = new Ambiance.Ambiance_LinkLabel();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iTalk_TabControl1
            // 
            this.iTalk_TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl1.Controls.Add(this.tabPage1);
            this.iTalk_TabControl1.Controls.Add(this.tabPage2);
            this.iTalk_TabControl1.Controls.Add(this.tabPage3);
            this.iTalk_TabControl1.Controls.Add(this.tabPage4);
            this.iTalk_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl1.ItemSize = new System.Drawing.Size(44, 135);
            this.iTalk_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_TabControl1.Multiline = true;
            this.iTalk_TabControl1.Name = "iTalk_TabControl1";
            this.iTalk_TabControl1.SelectedIndex = 0;
            this.iTalk_TabControl1.Size = new System.Drawing.Size(704, 515);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.btnDownload);
            this.tabPage1.Controls.Add(this.ambiance_Button_21);
            this.tabPage1.Controls.Add(this.iTalk_ProgressBar1);
            this.tabPage1.Controls.Add(this.lstboxFiles);
            this.tabPage1.Controls.Add(this.iTalk_Button_21);
            this.tabPage1.ForeColor = System.Drawing.Color.Red;
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List Files";
            this.tabPage1.ToolTipText = "List FTP Files";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDownload.Image = null;
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(203, 379);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(167, 40);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download File";
            this.btnDownload.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // ambiance_Button_21
            // 
            this.ambiance_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Button_21.Image = null;
            this.ambiance_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_21.Location = new System.Drawing.Point(386, 379);
            this.ambiance_Button_21.Name = "ambiance_Button_21";
            this.ambiance_Button_21.Size = new System.Drawing.Size(167, 40);
            this.ambiance_Button_21.TabIndex = 4;
            this.ambiance_Button_21.Text = "Remove File";
            this.ambiance_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_21.Click += new System.EventHandler(this.ambiance_Button_21_Click);
            // 
            // iTalk_ProgressBar1
            // 
            this.iTalk_ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iTalk_ProgressBar1.Location = new System.Drawing.Point(6, 368);
            this.iTalk_ProgressBar1.Maximum = ((long)(100));
            this.iTalk_ProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.iTalk_ProgressBar1.Name = "iTalk_ProgressBar1";
            this.iTalk_ProgressBar1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.iTalk_ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.iTalk_ProgressBar1.ProgressShape = iTalk_ProgressBar._ProgressShape.Round;
            this.iTalk_ProgressBar1.Size = new System.Drawing.Size(136, 136);
            this.iTalk_ProgressBar1.TabIndex = 2;
            this.iTalk_ProgressBar1.Text = "iTalk_ProgressBar1";
            this.iTalk_ProgressBar1.Value = ((long)(0));
            // 
            // lstboxFiles
            // 
            this.lstboxFiles.BackColor = System.Drawing.Color.LavenderBlush;
            this.lstboxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxFiles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstboxFiles.FormattingEnabled = true;
            this.lstboxFiles.ItemHeight = 20;
            this.lstboxFiles.Location = new System.Drawing.Point(3, 73);
            this.lstboxFiles.Name = "lstboxFiles";
            this.lstboxFiles.Size = new System.Drawing.Size(555, 284);
            this.lstboxFiles.TabIndex = 1;
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(0, 3);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(561, 64);
            this.iTalk_Button_21.TabIndex = 0;
            this.iTalk_Button_21.Text = "List Files";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.ambiance_Button_22);
            this.tabPage2.Controls.Add(this.iTalk_ProgressBar2);
            this.tabPage2.Controls.Add(this.iTalk_Separator1);
            this.tabPage2.Controls.Add(this.iTalk_HeaderLabel1);
            this.tabPage2.Controls.Add(this.iTalk_Button_22);
            this.tabPage2.Controls.Add(this.iTalk_Label1);
            this.tabPage2.Location = new System.Drawing.Point(139, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload";
            this.tabPage2.ToolTipText = "Upload Files to FTP";
            // 
            // ambiance_Button_22
            // 
            this.ambiance_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_22.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Button_22.Image = null;
            this.ambiance_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_22.Location = new System.Drawing.Point(186, 196);
            this.ambiance_Button_22.Name = "ambiance_Button_22";
            this.ambiance_Button_22.Size = new System.Drawing.Size(177, 41);
            this.ambiance_Button_22.TabIndex = 8;
            this.ambiance_Button_22.Text = "Upload";
            this.ambiance_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_22.Click += new System.EventHandler(this.ambiance_Button_22_Click);
            // 
            // iTalk_ProgressBar2
            // 
            this.iTalk_ProgressBar2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iTalk_ProgressBar2.Location = new System.Drawing.Point(172, 243);
            this.iTalk_ProgressBar2.Maximum = ((long)(100));
            this.iTalk_ProgressBar2.MinimumSize = new System.Drawing.Size(100, 100);
            this.iTalk_ProgressBar2.Name = "iTalk_ProgressBar2";
            this.iTalk_ProgressBar2.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.iTalk_ProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.iTalk_ProgressBar2.ProgressShape = iTalk_ProgressBar._ProgressShape.Round;
            this.iTalk_ProgressBar2.Size = new System.Drawing.Size(200, 200);
            this.iTalk_ProgressBar2.TabIndex = 7;
            this.iTalk_ProgressBar2.Text = "iTalk_ProgressBar2";
            this.iTalk_ProgressBar2.Value = ((long)(0));
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(170, 49);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(202, 10);
            this.iTalk_Separator1.TabIndex = 6;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(178, 0);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(188, 46);
            this.iTalk_HeaderLabel1.TabIndex = 4;
            this.iTalk_HeaderLabel1.Text = "Upload File";
            // 
            // iTalk_Button_22
            // 
            this.iTalk_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_22.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_22.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_22.Image = null;
            this.iTalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_22.Location = new System.Drawing.Point(441, 77);
            this.iTalk_Button_22.Name = "iTalk_Button_22";
            this.iTalk_Button_22.Size = new System.Drawing.Size(112, 40);
            this.iTalk_Button_22.TabIndex = 2;
            this.iTalk_Button_22.Text = "Browse";
            this.iTalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_22.Click += new System.EventHandler(this.iTalk_Button_22_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(6, 83);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(241, 25);
            this.iTalk_Label1.TabIndex = 1;
            this.iTalk_Label1.Text = "Please select File to Upload";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage3.Controls.Add(this.iTalk_Label7);
            this.tabPage3.Controls.Add(this.ambiance_ComboBox1);
            this.tabPage3.Controls.Add(this.ambiance_Label1);
            this.tabPage3.Controls.Add(this.txtUsername);
            this.tabPage3.Controls.Add(this.txtpass);
            this.tabPage3.Controls.Add(this.txtpath);
            this.tabPage3.Controls.Add(this.txtHost);
            this.tabPage3.Controls.Add(this.iTalk_Label6);
            this.tabPage3.Controls.Add(this.iTalk_Button_23);
            this.tabPage3.Controls.Add(this.iTalk_Label5);
            this.tabPage3.Controls.Add(this.iTalk_Label4);
            this.tabPage3.Controls.Add(this.iTalk_Label3);
            this.tabPage3.Controls.Add(this.iTalk_Label2);
            this.tabPage3.Location = new System.Drawing.Point(139, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(561, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Config";
            this.tabPage3.ToolTipText = "Configuration";
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label7.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_Label7.Location = new System.Drawing.Point(53, 48);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(72, 30);
            this.iTalk_Label7.TabIndex = 12;
            this.iTalk_Label7.Text = "Profile";
            // 
            // ambiance_ComboBox1
            // 
            this.ambiance_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ambiance_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ambiance_ComboBox1.DropDownHeight = 100;
            this.ambiance_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ambiance_ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ambiance_ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.ambiance_ComboBox1.FormattingEnabled = true;
            this.ambiance_ComboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.ambiance_ComboBox1.IntegralHeight = false;
            this.ambiance_ComboBox1.ItemHeight = 20;
            this.ambiance_ComboBox1.Items.AddRange(new object[] {
            "Default"});
            this.ambiance_ComboBox1.Location = new System.Drawing.Point(171, 48);
            this.ambiance_ComboBox1.Name = "ambiance_ComboBox1";
            this.ambiance_ComboBox1.Size = new System.Drawing.Size(304, 26);
            this.ambiance_ComboBox1.StartIndex = 0;
            this.ambiance_ComboBox1.TabIndex = 11;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.DimGray;
            this.ambiance_Label1.Location = new System.Drawing.Point(170, 363);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(226, 20);
            this.ambiance_Label1.TabIndex = 10;
            this.ambiance_Label1.Text = "(Optional/ Empty for Root Level)";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(171, 168);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(304, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(171, 245);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(304, 31);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtpath
            // 
            this.txtpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpath.Location = new System.Drawing.Point(171, 326);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(304, 31);
            this.txtpath.TabIndex = 3;
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(171, 101);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(304, 31);
            this.txtHost.TabIndex = 0;
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_Label6.Location = new System.Drawing.Point(187, 5);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(203, 30);
            this.iTalk_Label6.TabIndex = 9;
            this.iTalk_Label6.Text = "Server Configuration";
            // 
            // iTalk_Button_23
            // 
            this.iTalk_Button_23.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_23.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_23.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_23.Image = null;
            this.iTalk_Button_23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_23.Location = new System.Drawing.Point(309, 391);
            this.iTalk_Button_23.Name = "iTalk_Button_23";
            this.iTalk_Button_23.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_23.TabIndex = 4;
            this.iTalk_Button_23.Text = "Save";
            this.iTalk_Button_23.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_23.Click += new System.EventHandler(this.iTalk_Button_23_Click);
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_Label5.Location = new System.Drawing.Point(53, 167);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(106, 30);
            this.iTalk_Label5.TabIndex = 4;
            this.iTalk_Label5.Text = "Username";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_Label4.Location = new System.Drawing.Point(51, 246);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(99, 30);
            this.iTalk_Label4.TabIndex = 3;
            this.iTalk_Label4.Text = "Password";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_Label3.Location = new System.Drawing.Point(55, 327);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(54, 30);
            this.iTalk_Label3.TabIndex = 2;
            this.iTalk_Label3.Text = "Path";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_Label2.Location = new System.Drawing.Point(53, 101);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(56, 30);
            this.iTalk_Label2.TabIndex = 0;
            this.iTalk_Label2.Text = "Host";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FTPController.Properties.Resources.ftp_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iTalk_HeaderLabel2
            // 
            this.iTalk_HeaderLabel2.AutoSize = true;
            this.iTalk_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.iTalk_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel2.Location = new System.Drawing.Point(234, 36);
            this.iTalk_HeaderLabel2.Name = "iTalk_HeaderLabel2";
            this.iTalk_HeaderLabel2.Size = new System.Drawing.Size(233, 46);
            this.iTalk_HeaderLabel2.TabIndex = 3;
            this.iTalk_HeaderLabel2.Text = "FTP Controller";
            // 
            // iTalk_Label9
            // 
            this.iTalk_Label9.AutoSize = true;
            this.iTalk_Label9.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label9.Location = new System.Drawing.Point(239, 84);
            this.iTalk_Label9.Name = "iTalk_Label9";
            this.iTalk_Label9.Size = new System.Drawing.Size(121, 13);
            this.iTalk_Label9.TabIndex = 4;
            this.iTalk_Label9.Text = "Custom FTP Controller";
            // 
            // ambiance_LinkLabel1
            // 
            this.ambiance_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.ambiance_LinkLabel1.AutoSize = true;
            this.ambiance_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.ambiance_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.ambiance_LinkLabel1.Location = new System.Drawing.Point(238, 114);
            this.ambiance_LinkLabel1.Name = "ambiance_LinkLabel1";
            this.ambiance_LinkLabel1.Size = new System.Drawing.Size(62, 20);
            this.ambiance_LinkLabel1.TabIndex = 5;
            this.ambiance_LinkLabel1.TabStop = true;
            this.ambiance_LinkLabel1.Text = "Pakistan";
            this.ambiance_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage4.Controls.Add(this.ambiance_LinkLabel2);
            this.tabPage4.Controls.Add(this.ambiance_LinkLabel1);
            this.tabPage4.Controls.Add(this.iTalk_Label9);
            this.tabPage4.Controls.Add(this.iTalk_HeaderLabel2);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(139, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(561, 507);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.ToolTipText = "About...";
            // 
            // ambiance_LinkLabel2
            // 
            this.ambiance_LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.ambiance_LinkLabel2.AutoSize = true;
            this.ambiance_LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_LinkLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.ambiance_LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.ambiance_LinkLabel2.Location = new System.Drawing.Point(3, 256);
            this.ambiance_LinkLabel2.Name = "ambiance_LinkLabel2";
            this.ambiance_LinkLabel2.Size = new System.Drawing.Size(139, 20);
            this.ambiance_LinkLabel2.TabIndex = 6;
            this.ambiance_LinkLabel2.TabStop = true;
            this.ambiance_LinkLabel2.Text = "Muhammad Zaheer";
            this.ambiance_LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 515);
            this.Controls.Add(this.iTalk_TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FTP Controller v 1.0.0.13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.iTalk_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private iTalk_Button_2 iTalk_Button_21;
        private System.Windows.Forms.ListBox lstboxFiles;
        private iTalk_ProgressBar iTalk_ProgressBar1;
        private iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk_Button_2 iTalk_Button_22;
        private iTalk_Label iTalk_Label1;
        private iTalk_Separator iTalk_Separator1;
        private iTalk_ProgressBar iTalk_ProgressBar2;
        private iTalk_Button_2 iTalk_Button_23;
        private iTalk_Label iTalk_Label5;
        private iTalk_Label iTalk_Label4;
        private iTalk_Label iTalk_Label3;
        private iTalk_Label iTalk_Label2;
        private iTalk_Label iTalk_Label6;
        private Ambiance.Ambiance_Button_2 ambiance_Button_21;
        private Ambiance.Ambiance_Button_2 ambiance_Button_22;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtpath;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private iTalk_Label iTalk_Label7;
        private Ambiance.Ambiance_ComboBox ambiance_ComboBox1;
        private Ambiance.Ambiance_Button_1 btnDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage4;
        private Ambiance.Ambiance_LinkLabel ambiance_LinkLabel2;
        private Ambiance.Ambiance_LinkLabel ambiance_LinkLabel1;
        private iTalk_Label iTalk_Label9;
        private iTalk_HeaderLabel iTalk_HeaderLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

