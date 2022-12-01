
namespace TicketTerminal
{
	partial class Dashboard
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pMain = new System.Windows.Forms.Panel();
			this.pInfo = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labDescription = new System.Windows.Forms.Label();
			this.bsCinema = new System.Windows.Forms.BindingSource(this.components);
			this.dsCinema = new TicketTerminal.dsCinema();
			this.pSeance = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labD = new System.Windows.Forms.Label();
			this.labRY = new System.Windows.Forms.Label();
			this.labC = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labName = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.labAge = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pBorder = new System.Windows.Forms.Panel();
			this.pCinemaNow = new System.Windows.Forms.Panel();
			this.bsCinemaNow = new System.Windows.Forms.BindingSource(this.components);
			this.bsSeance = new System.Windows.Forms.BindingSource(this.components);
			this.cinemaNowTableAdapter = new TicketTerminal.dsCinemaTableAdapters.CinemaNowTableAdapter();
			this.seanceTableAdapter = new TicketTerminal.dsCinemaTableAdapters.SeanceTableAdapter();
			this.cinemaTableAdapter = new TicketTerminal.dsCinemaTableAdapters.CinemaTableAdapter();
			this.panel1.SuspendLayout();
			this.pMain.SuspendLayout();
			this.pInfo.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsCinema)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCinema)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCinemaNow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSeance)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pMain);
			this.panel1.Controls.Add(this.pBorder);
			this.panel1.Controls.Add(this.pCinemaNow);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(25, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 711);
			this.panel1.TabIndex = 0;
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.pInfo);
			this.pMain.Controls.Add(this.panel4);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 0);
			this.pMain.Name = "pMain";
			this.pMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
			this.pMain.Size = new System.Drawing.Size(934, 460);
			this.pMain.TabIndex = 5;
			// 
			// pInfo
			// 
			this.pInfo.Controls.Add(this.panel2);
			this.pInfo.Controls.Add(this.pSeance);
			this.pInfo.Controls.Add(this.panel3);
			this.pInfo.Controls.Add(this.label2);
			this.pInfo.Controls.Add(this.labName);
			this.pInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pInfo.Location = new System.Drawing.Point(315, 0);
			this.pInfo.Name = "pInfo";
			this.pInfo.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
			this.pInfo.Size = new System.Drawing.Size(619, 435);
			this.pInfo.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.labDescription);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(25, 106);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(594, 257);
			this.panel2.TabIndex = 6;
			// 
			// labDescription
			// 
			this.labDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCinema, "description", true));
			this.labDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.labDescription.Location = new System.Drawing.Point(0, 0);
			this.labDescription.Name = "labDescription";
			this.labDescription.Size = new System.Drawing.Size(594, 257);
			this.labDescription.TabIndex = 9;
			this.labDescription.Text = "Описание";
			// 
			// bsCinema
			// 
			this.bsCinema.DataMember = "Cinema";
			this.bsCinema.DataSource = this.dsCinema;
			// 
			// dsCinema
			// 
			this.dsCinema.DataSetName = "dsCinema";
			this.dsCinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pSeance
			// 
			this.pSeance.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pSeance.Location = new System.Drawing.Point(25, 363);
			this.pSeance.Name = "pSeance";
			this.pSeance.Size = new System.Drawing.Size(594, 72);
			this.pSeance.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.labD);
			this.panel3.Controls.Add(this.labRY);
			this.panel3.Controls.Add(this.labC);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(25, 73);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panel3.Size = new System.Drawing.Size(594, 33);
			this.panel3.TabIndex = 2;
			// 
			// labD
			// 
			this.labD.AutoSize = true;
			this.labD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCinema, "duration", true));
			this.labD.Dock = System.Windows.Forms.DockStyle.Left;
			this.labD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labD.Location = new System.Drawing.Point(99, 0);
			this.labD.Margin = new System.Windows.Forms.Padding(0);
			this.labD.Name = "labD";
			this.labD.Size = new System.Drawing.Size(167, 23);
			this.labD.TabIndex = 8;
			this.labD.Text = "продолжительность";
			// 
			// labRY
			// 
			this.labRY.AutoSize = true;
			this.labRY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labRY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCinema, "releaseYear", true));
			this.labRY.Dock = System.Windows.Forms.DockStyle.Left;
			this.labRY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labRY.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labRY.Location = new System.Drawing.Point(62, 0);
			this.labRY.Margin = new System.Windows.Forms.Padding(0);
			this.labRY.Name = "labRY";
			this.labRY.Size = new System.Drawing.Size(37, 23);
			this.labRY.TabIndex = 7;
			this.labRY.Text = "год";
			// 
			// labC
			// 
			this.labC.AutoSize = true;
			this.labC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCinema, "country", true));
			this.labC.Dock = System.Windows.Forms.DockStyle.Left;
			this.labC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labC.Location = new System.Drawing.Point(0, 0);
			this.labC.Margin = new System.Windows.Forms.Padding(0);
			this.labC.Name = "labC";
			this.labC.Size = new System.Drawing.Size(62, 23);
			this.labC.TabIndex = 4;
			this.labC.Text = "страна";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCinema, "genre", true));
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(25, 32);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.label2.Size = new System.Drawing.Size(50, 41);
			this.label2.TabIndex = 1;
			this.label2.Text = "жанр";
			// 
			// labName
			// 
			this.labName.AutoSize = true;
			this.labName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCinema, "name", true));
			this.labName.Dock = System.Windows.Forms.DockStyle.Top;
			this.labName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labName.Location = new System.Drawing.Point(25, 0);
			this.labName.Name = "labName";
			this.labName.Size = new System.Drawing.Size(128, 32);
			this.labName.TabIndex = 0;
			this.labName.Text = "Название";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.labAge);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.panel4.Size = new System.Drawing.Size(315, 435);
			this.panel4.TabIndex = 1;
			// 
			// labAge
			// 
			this.labAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
			this.labAge.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labAge.Location = new System.Drawing.Point(0, 397);
			this.labAge.Name = "labAge";
			this.labAge.Size = new System.Drawing.Size(61, 35);
			this.labAge.TabIndex = 6;
			this.labAge.Text = "21+";
			this.labAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsCinema, "image", true));
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(290, 435);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// pBorder
			// 
			this.pBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
			this.pBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
			this.pBorder.Location = new System.Drawing.Point(0, 460);
			this.pBorder.Name = "pBorder";
			this.pBorder.Size = new System.Drawing.Size(934, 1);
			this.pBorder.TabIndex = 4;
			// 
			// pCinemaNow
			// 
			this.pCinemaNow.AutoScroll = true;
			this.pCinemaNow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pCinemaNow.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pCinemaNow.Location = new System.Drawing.Point(0, 461);
			this.pCinemaNow.Name = "pCinemaNow";
			this.pCinemaNow.Size = new System.Drawing.Size(934, 250);
			this.pCinemaNow.TabIndex = 3;
			// 
			// bsCinemaNow
			// 
			this.bsCinemaNow.DataMember = "CinemaNow";
			this.bsCinemaNow.DataSource = this.dsCinema;
			// 
			// bsSeance
			// 
			this.bsSeance.DataMember = "Seance";
			this.bsSeance.DataSource = this.dsCinema;
			// 
			// cinemaNowTableAdapter
			// 
			this.cinemaNowTableAdapter.ClearBeforeFill = true;
			// 
			// seanceTableAdapter
			// 
			this.seanceTableAdapter.ClearBeforeFill = true;
			// 
			// cinemaTableAdapter
			// 
			this.cinemaTableAdapter.ClearBeforeFill = true;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Dashboard";
			this.Padding = new System.Windows.Forms.Padding(25);
			this.Text = "Терминал";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.Resize += new System.EventHandler(this.Dashboard_Resize);
			this.panel1.ResumeLayout(false);
			this.pMain.ResumeLayout(false);
			this.pInfo.ResumeLayout(false);
			this.pInfo.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsCinema)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCinema)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCinemaNow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSeance)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.BindingSource bsCinema;
        private dsCinema dsCinema;
        private System.Windows.Forms.BindingSource bsCinemaNow;
        private System.Windows.Forms.BindingSource bsSeance;
        private dsCinemaTableAdapters.CinemaNowTableAdapter cinemaNowTableAdapter;
		private dsCinemaTableAdapters.SeanceTableAdapter seanceTableAdapter;
		private dsCinemaTableAdapters.CinemaTableAdapter cinemaTableAdapter;
		public System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Panel pInfo;
		private System.Windows.Forms.Panel pSeance;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labD;
		private System.Windows.Forms.Label labRY;
		private System.Windows.Forms.Label labC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labName;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label labAge;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pBorder;
		private System.Windows.Forms.Panel pCinemaNow;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labDescription;
	}
}

