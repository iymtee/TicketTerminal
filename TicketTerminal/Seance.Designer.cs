
namespace TicketTerminal
{
	partial class Seance
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
			this.bsTicket = new System.Windows.Forms.BindingSource(this.components);
			this.dsCinema = new TicketTerminal.dsCinema();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.bsCinema = new System.Windows.Forms.BindingSource(this.components);
			this.tableAdapterManager = new TicketTerminal.dsCinemaTableAdapters.TableAdapterManager();
			this.ticketTableAdapter = new TicketTerminal.dsCinemaTableAdapters.TicketTableAdapter();
			this.cinemaTableAdapter = new TicketTerminal.dsCinemaTableAdapters.CinemaTableAdapter();
			this.pRight = new System.Windows.Forms.Panel();
			this.pImageAge = new System.Windows.Forms.Panel();
			this.labAge = new System.Windows.Forms.Label();
			this.pImage = new System.Windows.Forms.PictureBox();
			this.pImL = new System.Windows.Forms.Panel();
			this.pImR = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labHall = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.labOnePrice = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labCountSeats = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.labPrice = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnBuy = new FontAwesome.Sharp.IconButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnPrev = new FontAwesome.Sharp.IconButton();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labName = new System.Windows.Forms.Label();
			this.pLeft = new System.Windows.Forms.Panel();
			this.pRightR = new System.Windows.Forms.Panel();
			this.pSeats = new System.Windows.Forms.Panel();
			this.pFlow = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bsTicket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCinema)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCinema)).BeginInit();
			this.pRight.SuspendLayout();
			this.pImageAge.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bsTicket
			// 
			this.bsTicket.DataMember = "Ticket";
			this.bsTicket.DataSource = this.dsCinema;
			// 
			// dsCinema
			// 
			this.dsCinema.DataSetName = "dsCinema";
			this.dsCinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bsCinema
			// 
			this.bsCinema.DataMember = "Cinema";
			this.bsCinema.DataSource = this.dsCinema;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CinemaTableAdapter = null;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.SeanceTableAdapter = null;
			this.tableAdapterManager.TicketTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TicketTerminal.dsCinemaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// ticketTableAdapter
			// 
			this.ticketTableAdapter.ClearBeforeFill = true;
			// 
			// cinemaTableAdapter
			// 
			this.cinemaTableAdapter.ClearBeforeFill = true;
			// 
			// pRight
			// 
			this.pRight.Controls.Add(this.pImageAge);
			this.pRight.Controls.Add(this.panel2);
			this.pRight.Controls.Add(this.labHall);
			this.pRight.Controls.Add(this.panel8);
			this.pRight.Controls.Add(this.labOnePrice);
			this.pRight.Controls.Add(this.panel3);
			this.pRight.Controls.Add(this.labCountSeats);
			this.pRight.Controls.Add(this.panel4);
			this.pRight.Controls.Add(this.labPrice);
			this.pRight.Controls.Add(this.panel6);
			this.pRight.Controls.Add(this.btnBuy);
			this.pRight.Controls.Add(this.panel5);
			this.pRight.Controls.Add(this.btnPrev);
			this.pRight.Controls.Add(this.panel7);
			this.pRight.Controls.Add(this.labName);
			this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.pRight.Location = new System.Drawing.Point(574, 0);
			this.pRight.Name = "pRight";
			this.pRight.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
			this.pRight.Size = new System.Drawing.Size(226, 700);
			this.pRight.TabIndex = 30;
			// 
			// pImageAge
			// 
			this.pImageAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pImageAge.Controls.Add(this.labAge);
			this.pImageAge.Controls.Add(this.pImage);
			this.pImageAge.Controls.Add(this.pImL);
			this.pImageAge.Controls.Add(this.pImR);
			this.pImageAge.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pImageAge.Location = new System.Drawing.Point(25, 42);
			this.pImageAge.MinimumSize = new System.Drawing.Size(0, 300);
			this.pImageAge.Name = "pImageAge";
			this.pImageAge.Size = new System.Drawing.Size(201, 300);
			this.pImageAge.TabIndex = 116;
			// 
			// labAge
			// 
			this.labAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
			this.labAge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.labAge.Location = new System.Drawing.Point(0, 275);
			this.labAge.Name = "labAge";
			this.labAge.Size = new System.Drawing.Size(59, 25);
			this.labAge.TabIndex = 78;
			this.labAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pImage
			// 
			this.pImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsCinema, "image", true));
			this.pImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pImage.Location = new System.Drawing.Point(34, 0);
			this.pImage.Name = "pImage";
			this.pImage.Size = new System.Drawing.Size(133, 300);
			this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pImage.TabIndex = 76;
			this.pImage.TabStop = false;
			// 
			// pImL
			// 
			this.pImL.Dock = System.Windows.Forms.DockStyle.Left;
			this.pImL.Location = new System.Drawing.Point(0, 0);
			this.pImL.Name = "pImL";
			this.pImL.Size = new System.Drawing.Size(34, 300);
			this.pImL.TabIndex = 74;
			this.pImL.Visible = false;
			// 
			// pImR
			// 
			this.pImR.Dock = System.Windows.Forms.DockStyle.Right;
			this.pImR.Location = new System.Drawing.Point(167, 0);
			this.pImR.Name = "pImR";
			this.pImR.Size = new System.Drawing.Size(34, 300);
			this.pImR.TabIndex = 75;
			this.pImR.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(25, 317);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(201, 10);
			this.panel2.TabIndex = 115;
			// 
			// labHall
			// 
			this.labHall.AutoSize = true;
			this.labHall.BackColor = System.Drawing.Color.Green;
			this.labHall.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labHall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.labHall.ForeColor = System.Drawing.Color.White;
			this.labHall.Location = new System.Drawing.Point(25, 327);
			this.labHall.Name = "labHall";
			this.labHall.Size = new System.Drawing.Size(103, 21);
			this.labHall.TabIndex = 114;
			this.labHall.Text = "зелёный зал";
			this.labHall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel8
			// 
			this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel8.Location = new System.Drawing.Point(25, 348);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(201, 10);
			this.panel8.TabIndex = 113;
			// 
			// labOnePrice
			// 
			this.labOnePrice.AutoEllipsis = true;
			this.labOnePrice.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labOnePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.labOnePrice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labOnePrice.Location = new System.Drawing.Point(25, 358);
			this.labOnePrice.Name = "labOnePrice";
			this.labOnePrice.Size = new System.Drawing.Size(201, 26);
			this.labOnePrice.TabIndex = 111;
			this.labOnePrice.Text = "Цена билета:";
			this.labOnePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(25, 384);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(201, 5);
			this.panel3.TabIndex = 110;
			// 
			// labCountSeats
			// 
			this.labCountSeats.AutoEllipsis = true;
			this.labCountSeats.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labCountSeats.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.labCountSeats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labCountSeats.Location = new System.Drawing.Point(25, 389);
			this.labCountSeats.Name = "labCountSeats";
			this.labCountSeats.Size = new System.Drawing.Size(201, 26);
			this.labCountSeats.TabIndex = 107;
			this.labCountSeats.Text = "Выбрано мест: 0";
			this.labCountSeats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(25, 415);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(201, 10);
			this.panel4.TabIndex = 100;
			// 
			// labPrice
			// 
			this.labPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.labPrice.Location = new System.Drawing.Point(25, 425);
			this.labPrice.Name = "labPrice";
			this.labPrice.Size = new System.Drawing.Size(201, 50);
			this.labPrice.TabIndex = 99;
			this.labPrice.Text = "Итого к оплате:\r\n0 ₽";
			this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.panel6.Location = new System.Drawing.Point(25, 475);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(201, 25);
			this.panel6.TabIndex = 98;
			// 
			// btnBuy
			// 
			this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
			this.btnBuy.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnBuy.FlatAppearance.BorderSize = 0;
			this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnBuy.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
			this.btnBuy.IconColor = System.Drawing.Color.White;
			this.btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnBuy.IconSize = 50;
			this.btnBuy.Location = new System.Drawing.Point(25, 500);
			this.btnBuy.Margin = new System.Windows.Forms.Padding(0);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(201, 60);
			this.btnBuy.TabIndex = 97;
			this.btnBuy.Text = "оплатить";
			this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnBuy.UseVisualStyleBackColor = false;
			this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(25, 560);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(201, 75);
			this.panel5.TabIndex = 90;
			// 
			// btnPrev
			// 
			this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
			this.btnPrev.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnPrev.FlatAppearance.BorderSize = 0;
			this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
			this.btnPrev.IconColor = System.Drawing.Color.White;
			this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPrev.IconSize = 50;
			this.btnPrev.Location = new System.Drawing.Point(25, 635);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(201, 65);
			this.btnPrev.TabIndex = 89;
			this.btnPrev.Text = "вернуться назад";
			this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btnPrev.UseVisualStyleBackColor = false;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// panel7
			// 
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(25, 32);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(201, 10);
			this.panel7.TabIndex = 66;
			// 
			// labName
			// 
			this.labName.AutoSize = true;
			this.labName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCinema, "name", true));
			this.labName.Dock = System.Windows.Forms.DockStyle.Top;
			this.labName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.labName.Location = new System.Drawing.Point(25, 0);
			this.labName.Name = "labName";
			this.labName.Size = new System.Drawing.Size(128, 32);
			this.labName.TabIndex = 65;
			this.labName.Text = "Название";
			this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pLeft
			// 
			this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pLeft.Location = new System.Drawing.Point(0, 0);
			this.pLeft.Name = "pLeft";
			this.pLeft.Size = new System.Drawing.Size(201, 700);
			this.pLeft.TabIndex = 68;
			this.pLeft.Visible = false;
			// 
			// pRightR
			// 
			this.pRightR.Dock = System.Windows.Forms.DockStyle.Right;
			this.pRightR.Location = new System.Drawing.Point(373, 0);
			this.pRightR.Name = "pRightR";
			this.pRightR.Size = new System.Drawing.Size(201, 700);
			this.pRightR.TabIndex = 73;
			this.pRightR.Visible = false;
			// 
			// pSeats
			// 
			this.pSeats.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.pSeats.Location = new System.Drawing.Point(201, 55);
			this.pSeats.Name = "pSeats";
			this.pSeats.Padding = new System.Windows.Forms.Padding(10);
			this.pSeats.Size = new System.Drawing.Size(172, 645);
			this.pSeats.TabIndex = 76;
			// 
			// pFlow
			// 
			this.pFlow.Dock = System.Windows.Forms.DockStyle.Top;
			this.pFlow.Location = new System.Drawing.Point(201, 30);
			this.pFlow.Name = "pFlow";
			this.pFlow.Size = new System.Drawing.Size(172, 25);
			this.pFlow.TabIndex = 75;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(201, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(172, 30);
			this.panel1.TabIndex = 74;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 30);
			this.label2.TabIndex = 29;
			this.label2.Text = "Э К Р А Н";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Seance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 700);
			this.Controls.Add(this.pSeats);
			this.Controls.Add(this.pFlow);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pRightR);
			this.Controls.Add(this.pLeft);
			this.Controls.Add(this.pRight);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Seance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Seance";
			this.Load += new System.EventHandler(this.Seance_Load);
			this.Resize += new System.EventHandler(this.Seance_Resize);
			((System.ComponentModel.ISupportInitialize)(this.bsTicket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCinema)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCinema)).EndInit();
			this.pRight.ResumeLayout(false);
			this.pRight.PerformLayout();
			this.pImageAge.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.BindingSource bsTicket;
        private dsCinema dsCinema;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource bsCinema;
        private dsCinemaTableAdapters.TableAdapterManager tableAdapterManager;
		private dsCinemaTableAdapters.TicketTableAdapter ticketTableAdapter;
		private dsCinemaTableAdapters.CinemaTableAdapter cinemaTableAdapter;
		private System.Windows.Forms.Panel pRight;
		private System.Windows.Forms.Label labName;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label labPrice;
		private System.Windows.Forms.Panel panel6;
		private FontAwesome.Sharp.IconButton btnBuy;
		private System.Windows.Forms.Panel panel5;
		private FontAwesome.Sharp.IconButton btnPrev;
		private System.Windows.Forms.Panel pLeft;
		private System.Windows.Forms.Panel pRightR;
		private System.Windows.Forms.Panel pSeats;
		private System.Windows.Forms.Panel pFlow;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labCountSeats;
		private System.Windows.Forms.Label labHall;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label labOnePrice;
		private System.Windows.Forms.Panel pImageAge;
		public System.Windows.Forms.Label labAge;
		private System.Windows.Forms.PictureBox pImage;
		private System.Windows.Forms.Panel pImL;
		private System.Windows.Forms.Panel pImR;
		private System.Windows.Forms.Panel panel2;
	}
}