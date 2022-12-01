using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TicketTerminal.Properties;

namespace TicketTerminal
{
    public partial class Seance : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
        public static int idSeance = 0, hall, idCinema;
        public static double price = 0;
        double buyPrice = 0, count = 0;
        int y, num2, num1, x;

        public Seance()
        {
            InitializeComponent();
            bsCinema.Filter = $"idCinema = '{idCinema}'";
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if ((int)button.Tag == 0)
            {
                button.BackgroundImage = (Image)Resources._2;
                buyPrice += Seance.price;
                count += 1;
                button.Text = "";
                labCountSeats.Text = $"Выбрано мест: {count}";
                labPrice.Text = $"Итого к оплате: \r\n{buyPrice} ₽";
                button.Tag = (object)2;
            }
            else
            {
                if ((int)button.Tag != 2)
                    return;
                button.BackgroundImage = (Image)Resources._0;
                buyPrice -= Seance.price;
                count -= 1;
                button.Text = toolTip.GetToolTip((Control)button);
                labCountSeats.Text = $"Выбрано мест: {count}";
                labPrice.Text = $"Итого к оплате:\r\n{buyPrice} ₽";
                button.Tag = (object)0;
            }
        }

        private void FVSRed(Panel panelSeance)
        {
            panelSeance.Controls.Clear();
            if (0 >= bsTicket.Count)
                return;
            Button[] buttonArray = new Button[bsTicket.Count];

            for (int index = 0; index < bsTicket.Count; ++index)
            {
                DataRowView dataRowView = (DataRowView)bsTicket[index];
                buttonArray[index] = new Button();
                if (Convert.ToBoolean(dataRowView["busy"]))
                {
                    buttonArray[index].BackgroundImage = (Image)Resources._1;
                    buttonArray[index].Tag = (object)1;
                    buttonArray[index].Enabled = false;
                }
                else
                {
                    buttonArray[index].BackgroundImage = (Image)Resources._0;
                    buttonArray[index].Text = dataRowView["numSeat"].ToString();
                    buttonArray[index].Tag = (object)0;
                }
                buttonArray[index].Name = dataRowView["idTicket"].ToString();
                toolTip.SetToolTip((Control)buttonArray[index], dataRowView["numSeat"].ToString());
                buttonArray[index].Height = num2;
                buttonArray[index].Width = num2;
                buttonArray[index].TextAlign = ContentAlignment.MiddleCenter;
                buttonArray[index].BackgroundImageLayout = ImageLayout.Stretch;
                buttonArray[index].FlatStyle = FlatStyle.Popup;
                buttonArray[index].Location = new Point(x, y);
                buttonArray[index].Cursor = Cursors.Hand;
                buttonArray[index].Click += new EventHandler(Seat_Click);
                if (index + 1 == 10 || index + 1 == 31 || index + 1 == 52 ||
                    index + 1 == 21 || index + 1 == 42 || index + 1 == 63)
                {
                    x = num1;
                    y += num2 + 10;
                }
                else
                    x += num2 + 5;
                panelSeance.Controls.Add((Control)buttonArray[index]);
                panelSeance.Controls.SetChildIndex((Control)buttonArray[index], 0);
            }
        }

		private void btnPrev_Click(object sender, EventArgs e)
        {
            (this.Owner as Dashboard).panel1.Visible = true;
            this.Close();

        }

		private void FVS(Panel panelSeance)
        {
            panelSeance.Controls.Clear();
            if (0 >= bsTicket.Count)
                return;
            Button[] buttonArray = new Button[bsTicket.Count];

            for (int index = 0; index < bsTicket.Count; ++index)
            {
                DataRowView dataRowView = (DataRowView)bsTicket[index];
                buttonArray[index] = new Button();
                if (Convert.ToBoolean(dataRowView["busy"]))
                {
                    buttonArray[index].BackgroundImage = (Image)Resources._1;
                    buttonArray[index].Tag = (object)1;
                    buttonArray[index].Enabled = false;
                }
                else
                {
                    buttonArray[index].BackgroundImage = (Image)Resources._0;
                    buttonArray[index].Text = dataRowView["numSeat"].ToString();
                    buttonArray[index].Tag = (object)0;
                }
                buttonArray[index].Name = dataRowView["idTicket"].ToString();
                toolTip.SetToolTip((Control)buttonArray[index], dataRowView["numSeat"].ToString());
                buttonArray[index].Height = num2;
                buttonArray[index].Width = num2;
                buttonArray[index].TextAlign = ContentAlignment.MiddleCenter;
                buttonArray[index].BackgroundImageLayout = ImageLayout.Stretch;
                buttonArray[index].FlatStyle = FlatStyle.Popup;
                buttonArray[index].Location = new Point(x, y);
                buttonArray[index].Cursor = Cursors.Hand;
                buttonArray[index].Click += new EventHandler(Seat_Click);
                if (index + 1 == 140)
                {
                    x = num1 + 10;
                    y += num2 + 30;
                }
                else
                if (index + 1 == 154)
                {
                    x = num1 + 10;
                    y += num2 + 10;
                }
                else
                if (index + 1 == 147 || index + 1 == 161)
                    x += num2 + 10;
                else
                if ((index + 1) % 14 == 0)
                {
                    x = num1;
                    y += num2 + 10;
                }
                else
                    x = (index + 1) % 7 != 0 ? x + num2 + 10 : x + num2 + 30;
                panelSeance.Controls.Add((Control)buttonArray[index]);
                panelSeance.Controls.SetChildIndex((Control)buttonArray[index], 0);
            }
        }

        private void Seance_Load(object sender, EventArgs e)
        {
            this.ticketTableAdapter.Fill(this.dsCinema.Ticket);
            this.cinemaTableAdapter.Fill(this.dsCinema.Cinema);
            bsTicket.Filter = $"idSeance = '{(object)Seance.idSeance}' and date = '{DateTime.Now.ToString("yyyy-MM-dd")}'";        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            (Owner as Dashboard).pMain.Visible = true;
            Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            foreach (Button control in pSeats.Controls)
            {
                if ((int)control.Tag == 2)
                {
                    SqlCommand sqlCommand = new SqlCommand("update ticket set busy = 1 where idTicket = " + control.Name, con);
                    con.Open();
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        int num = (int)MessageBox.Show(ex.Message);
                    }
                    con.Close();
                }
            }
            Dashboard owner = Owner as Dashboard;
            owner.FillSeanse();
            owner.Fill();
            owner.panel1.Visible = true;
            this.Close();
        }

        private void Seance_Resize(object sender, EventArgs e)
        {
            pLeft.Visible = false;
            pRightR.Visible = false;
            y = 0;
            num2 = 40;
            if (this.Owner.WindowState == FormWindowState.Maximized)
            {
                pSeats.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                pImL.Visible = true;
                pImR.Visible = true;
                pRight.Width = Convert.ToInt32(this.Width * 0.30);
                num2 = 50;
            }
            else
            {
                pSeats.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                pRight.Width = 225;
                pImL.Visible = false;
                pImR.Visible = false;
            }
            if (hall == 1)
            {
                num1 = (pSeats.Width - (num2 * 14 + 30 + 10 * 12)) / 2;
                x = num1;
                FVS(pSeats);
            }                
            else
            if (hall == 2)
            {
                num1 = 0;
                x = num1;
                labHall.BackColor = Color.FromArgb(222, 42, 22);
                labHall.Text = "красный зал";
                pLeft.Width = (pSeats.Width - (num2 * 10 + 10 * 9)) / 2 - 13;
                pRightR.Width = pLeft.Width;
                pLeft.Visible = true;
                pRightR.Visible = true;
                //pLeft.Width = pSeats.Width - (num2 * 10 + 10 * 9) + pLeft.Width - 25;
                FVSRed(pSeats);
            }
            labName.MaximumSize = new Size(pRight.Width, 0);
            labName.MinimumSize = new Size(pRight.Width, 0);
            labHall.MinimumSize = new Size(pRight.Width, 0);
            labOnePrice.Text = $"Цена билета: {price} ₽";

        }
    }
}
