using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVMKatPlan
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		bool secim = false;
		
		private void btnStb_Click_1(object sender, EventArgs e)
		{

			lblYol1.Visible = true;
			lblYol2.Visible = true;
			lblYol3.Visible = true;

			lblSecim.Visible = false;

			checkBox1.Checked = false;
			checkBox2.Checked = false;

			checkBox1.Enabled = false;
			checkBox2.Enabled = false;

			lblYol1.ForeColor = System.Drawing.Color.Green;
			lblYol2.ForeColor = System.Drawing.Color.Green;
			lblYol3.ForeColor = System.Drawing.Color.Green;
			//3 FARKLI KİOKS İÇİN 3 FARKLI LABEL BELİRLEDİK VE 3 FARKLI YOLDAN GİDİŞ SEÇENEĞİ SUNDUK

			lblYol1.Text = "Eğer 1. Kiokstaysanız >> E1-D1-D2-D3";
			lblYol2.Text = "Eğer 2. Kiokstaysanız >> K4-K3-J3-I3-H3-G3-F3-E3-D4";
			lblYol3.Text = "Eğer 3. Kiokstaysanız >> E11-D11-D10-D9-D8-D7-D6-D5-D4-D3";
		}

		private void btnLcw_Click_1(object sender, EventArgs e)
		{
			lblYol1.Visible = true;
			lblYol2.Visible = true;
			lblYol3.Visible = true;

			lblSecim.Visible = false;

			checkBox1.Checked = false;
			checkBox2.Checked = false;

			checkBox1.Enabled = false;
			checkBox2.Enabled = false;

			lblYol1.ForeColor = System.Drawing.Color.Blue;
			lblYol2.ForeColor = System.Drawing.Color.Blue;
			lblYol3.ForeColor = System.Drawing.Color.Blue;

			lblYol1.Text = "Eğer 1. Kiokstaysanız >> E1-D1-C1-B1-B2-B3-B4-B5-B6-B7";
			lblYol2.Text = "Eğer 2. Kiokstaysanız >> K6-K7-J7-I7-H7-G7-F7-E7-D7-C7-B7";
			lblYol3.Text = "Eğer 3. Kiokstaysanız >> E11-D11-C11-B11-B10";
		}

		private void btnKtn_Click_1(object sender, EventArgs e)
		{
			lblYol1.Visible = true;
			lblYol2.Visible = true;
			lblYol3.Visible = true;

			lblSecim.Visible = false;

			checkBox1.Checked = false;
			checkBox2.Checked = false;

			checkBox1.Enabled = false;
			checkBox2.Enabled = false;

			lblYol1.ForeColor = System.Drawing.Color.Black;
			lblYol2.ForeColor = System.Drawing.Color.Black;
			lblYol3.ForeColor = System.Drawing.Color.Black;

			lblYol1.Text = "Eğer 1. Kiokstaysanız >> F2-F3-F4-F5-F6-F7-G7-H7";
			lblYol2.Text = "Eğer 2. Kiokstaysanız >> K6-K7-J7-I7-H7";
			lblYol3.Text = "Eğer 3. Kiokstaysanız >>G11-H11-H10-H9-H8-H7";
		}

		private void btnBgr_Click_1(object sender, EventArgs e)
		{
			lblSecim.Visible = true;

			checkBox1.Enabled = true;
			checkBox2.Enabled = true;
			checkBox1.ForeColor = System.Drawing.Color.Red;
			checkBox2.ForeColor = System.Drawing.Color.Red;
			lblYol1.Visible = false;
			lblYol2.Visible = false;
			lblYol3.Visible = false;
		}

		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			lblSecim.Visible = true;

			lblYol1.Visible = true;
			lblYol2.Visible = true;
			lblYol3.Visible = true;

			if (!secim)
			{
				if (checkBox2.Checked)
				{
					secim = true;
					checkBox2.Checked = false;
				}
			}
			else
			{
				secim = false;
			}

			lblYol1.ForeColor = System.Drawing.Color.Red;
			lblYol2.ForeColor = System.Drawing.Color.Red;
			lblYol3.ForeColor = System.Drawing.Color.Red;

			lblYol1.Text = "Eğer 1. Kiokstaysanız >> E1-E2-E3-E4-E5- Asansöre ulaştınız -D5-C5-C6";
			lblYol2.Text = "Eğer 2. Kiokstaysanız >> K5-J5-I5-H5-G5-F5-E5- Asansöre ulaştınız -D5-C5-C6";
			lblYol3.Text = "Eğer 3. kiokstaysanız >> E11-E10-E9-E8-E7-E6-E5- Asansöre ulaştınız -D5-C5-C6";
		}

		private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
		{
			lblSecim.Visible = true;

			lblYol1.Visible = true;
			lblYol2.Visible = true;
			lblYol3.Visible = true;

			if (!secim)
			{
				if (checkBox1.Checked)
				{
					secim = true;
					checkBox1.Checked = false;
				}
			}
			else
			{
				secim = false;
			}

			lblYol1.ForeColor = System.Drawing.Color.Red;
			lblYol2.ForeColor = System.Drawing.Color.Red;
			lblYol3.ForeColor = System.Drawing.Color.Red;

			lblYol1.Text = "Eğer 1. Kiokstaysanız >> F2-F3-F4-F5-E5-D5-C5-B5-A5- Merdivene ulaştınız -A6-B6-C6";
			lblYol2.Text = "Eğer 2. Kiokstaysanız >> J5-I5-H5-G5-F5-E5-D5-C5-B5-A5- Merdivene ulaştınız -A6-B6-C6";
			lblYol3.Text = "Eğer 3. kiokstaysanız >> E11-D11-C11-A11-A10-A9-A8-A7-A6-A5- Merdivene ulaştınız -A6-B6-C6";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblYol1.Visible = false;
			lblYol2.Visible = false;
			lblYol3.Visible = false;
			lblSecim.Visible = false;
			checkBox1.Enabled = false;
			checkBox2.Enabled = false;
			checkBox1.Checked = false;
			checkBox2.Checked = false;
			
		}

		//KULLANICI HANGİ MAĞAZAYA GİTMEK İSTİYORSA O MAĞAZAYI SEÇER VE EKRANA GELEN YOLLARI İZLER.




	}
}
