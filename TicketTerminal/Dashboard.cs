using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketTerminal
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();           
        }

        struct CinemaInfo
        {
            public int idCinema;
            public Image image;
        }
        private struct SeanceInfo
        {
            public string infoLab;
            public string price;
            public int idSeace, hall;
            public TimeSpan time;
        }

        CinemaInfo[] masCI;
        SeanceInfo[] masSI;

        #region фильмы
        //заполнение массива изображений (для списка фильмов в панели
        void FMC(ref CinemaInfo[] masCI)
        {
            if (0 >= bsCinemaNow.Count) return;
            masCI = new CinemaInfo[bsCinemaNow.Count];
            for (int i = 0; i < bsCinemaNow.Count; i++)
            {
                DataRowView t = (DataRowView)bsCinemaNow[i];
                masCI[i].idCinema = (int)t[0];
                try
                {
                    MemoryStream ms = new MemoryStream((byte[])t["image"]);
                    masCI[i].image = Image.FromStream(ms);
                }
                catch
                {
                    masCI[i].image = Properties.Resources.Error;
                }
            }
        }

        private void FVC(CinemaInfo[] masCI, Panel panelChildForm)
        {
            panelChildForm.Controls.Clear();
            if (0 >= bsCinemaNow.Count)
                return;
            PictureBox[] pictureBoxArray = new PictureBox[masCI.Length];
            Label[] labelArray = new Label[masCI.Length];
            int num1 = 25;
            int num2 = 25;
            int num3 = num1;
            int num4 = num2;
            int num5 = 150;
            for (int index = 0; index < masCI.Length; ++index)
            {
                pictureBoxArray[index] = new PictureBox();
                pictureBoxArray[index].SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxArray[index].Name = masCI[index].idCinema.ToString();
                pictureBoxArray[index].Image = masCI[index].image;
                pictureBoxArray[index].Width = num5;
                pictureBoxArray[index].Height = 200;
                pictureBoxArray[index].Cursor = Cursors.Hand;
                pictureBoxArray[index].Left = num3;
                pictureBoxArray[index].Top = num4;
                pictureBoxArray[index].Click += new EventHandler(Info_Click);
                panelChildForm.Controls.Add((Control)pictureBoxArray[index]);
                panelChildForm.Controls.SetChildIndex((Control)pictureBoxArray[index], 0);
                num3 = num3 + pictureBoxArray[index].Width + 25;
            }
        }
        #endregion



        #region сеансы
        public void FillSeanse()
        {
            seanceTableAdapter.Fill(dsCinema.Seance);
            FMS(ref masSI);
            FVS(masSI, pSeance);
        }
        private void FMS(ref SeanceInfo[] masSI)
        {
            if (0 >= bsSeance.Count)
            {
                masSI = (SeanceInfo[])null;
            }
            else
            {
                masSI = new SeanceInfo[bsSeance.Count];
                for (int index = 0; index < bsSeance.Count; ++index)
                {
                    DataRowView dataRowView = (DataRowView)bsSeance[index];
                    masSI[index].price = dataRowView["price"].ToString();
                    string[] strArray = dataRowView["time"].ToString().Split(':');
                    masSI[index].time = new TimeSpan(Convert.ToInt32(strArray[0]), Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[2]));
                    masSI[index].idSeace = (int)dataRowView["idSeance"]; 
                    masSI[index].hall = (int)dataRowView["hall"];
                    masSI[index].infoLab = dataRowView["time"].ToString().Remove(5) + " - " + dataRowView["price"].ToString().Remove(dataRowView["price"].ToString().IndexOf(',')) + " р.";
                }
            }
        }
        private void FVS(SeanceInfo[] masSI, Panel panelSeance)
        {
            panelSeance.Controls.Clear();
            if (0 >= bsSeance.Count)
                return;
            Button[] buttonArray = new Button[masSI.Length];
            int x = 0;
            int num = 175;
            for (int index = 0; index < masSI.Length; ++index)
            {
                buttonArray[index] = new Button();
                buttonArray[index].Height = 70;
                buttonArray[index].Width = num;
                buttonArray[index].Location = new Point(x, 0);
                buttonArray[index].Padding = new Padding(0, 15, 0, 15);
                buttonArray[index].Text = masSI[index].infoLab;
                buttonArray[index].FlatStyle = FlatStyle.Flat;
                buttonArray[index].Tag = (object)index;
                buttonArray[index].Cursor = Cursors.Hand;
                buttonArray[index].BackColor = Color.FromArgb(1, 73, 156);
                buttonArray[index].TextAlign = ContentAlignment.MiddleCenter;
                //if (masSI[index].time < DateTime.Now.TimeOfDay)
               //     buttonArray[index].Enabled = false;
                buttonArray[index].Click += new EventHandler(Seance_Click);
                panelSeance.Controls.Add((Control)buttonArray[index]);
                panelSeance.Controls.SetChildIndex((Control)buttonArray[index], 0);
                x = x + num + 25;
            }
        }

        private void Seance_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            panel1.Hide();
            Seance.idSeance = masSI[(int)button.Tag].idSeace;
            Seance.hall = masSI[(int)button.Tag].hall;
            Seance.price = Convert.ToDouble(masSI[(int)button.Tag].price);
            Seance frm = new Seance();
            frm.labAge.Text = this.labAge.Text;
            frm.Owner = (Form)this;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            Controls.Add((Control)frm);
            frm.BringToFront();
            frm.Show();
        }
        #endregion

        private void Info_Click(object sender, EventArgs e)
        {
            PictureBox pbThis = sender as PictureBox;
            Seance.idCinema = Convert.ToInt32(pbThis.Name);
            bsCinema.Filter = $"idCinema = '{pbThis.Name}'";
            bsSeance.Filter = $"idCinema = '{pbThis.Name}'";
            DataRowView t = (DataRowView)bsCinema[0];
            labAge.Text = (int)t["age"] + "+";
            FillSeanse();
        }

        public void Fill()
        {
            seanceTableAdapter.Fill(dsCinema.Seance);
            cinemaNowTableAdapter.Fill(dsCinema.CinemaNow);
            cinemaTableAdapter.Fill(dsCinema.Cinema);
            FMC(ref masCI);
            FVC(masCI, pCinemaNow);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Fill();
            DataRowView t = (DataRowView)bsCinemaNow[0];
            Seance.idCinema = (int)t["idCinema"];
            bsCinema.Filter = $"idCinema = '{(int)t["idCinema"]}'";
            bsSeance.Filter = $"idCinema = '{(int)t["idCinema"]}'";
            FillSeanse(); 
            t = (DataRowView)bsCinema[0];
            labAge.Text = (int)t["age"] + "+"; 
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            panel4.Width = 315;
            else
                panel4.Width = (int)(pMain.Width * 0.25);
            labName.MaximumSize = new Size(pInfo.Width, 0);
        }
    }
}
