using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<seat> seats = new List<seat>();

        private void btnShow_Click(object sender, EventArgs e)
        {
            seats = new List<seat>();

            for (int i = 1; i < 11; i++)
            {
                seat s = new seat();
                s.Place = i;
                s.Price = 8;
                seats.Add(s);
            }
            var a = 0;
            var b = 0;
            for (int i = 1; i < seats.Count; i++)
            {
                Button buttons = new Button();
                buttons.Name = "btn" + i;
                buttons.Text = i.ToString();
                buttons.Left = a += 75;
                buttons.Top = 20;
                this.Controls.Add(buttons);
                buttons.Click += Buttons_Click;
            }
            for (int i = 1; i < seats.Count; i++)
            {
                Button buttons = new Button();
                buttons.Name = "btn" + i;
                buttons.Text = i.ToString();
                buttons.Left = b += 75;
                buttons.Top = 45;
                this.Controls.Add(buttons);
                buttons.Click += Buttons_Click;
            }
            var c = 0;
            for (int i = 1; i < seats.Count; i++)
            {
                Button buttons = new Button();
                buttons.Name = "btn" + i;
                buttons.Text = i.ToString();
                buttons.Left = c += 75;
                buttons.Top = 70;
                this.Controls.Add(buttons);
                buttons.Click += Buttons_Click;
            }
            var d = 0;
            for (int i = 1; i < seats.Count; i++)
            {
                Button buttons = new Button();
                buttons.Name = "btn" + i;
                buttons.Text = i.ToString();
                buttons.Left = d += 75;
                buttons.Top = 95;
                this.Controls.Add(buttons);
                buttons.Click += Buttons_Click;
            }
            Button reserve = new Button();
            reserve.Name = "btnReserve";
            reserve.Text = "RESERVE";
            reserve.Left = 450;
            reserve.Top = 250;
            this.Controls.Add(reserve);
            reserve.Click += Reserve_Click;
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            Button btns = (Button)sender;

            btns.BackColor = Color.Red;
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button btn4 = (Button)sender;
            for (int i = 1; i < seats.Count; i++)    
            {
                if (btn4.Name == "btn" + i)
                {
                    dgvV.DataSource = seats;
                }
            }
            btn4.BackColor = Color.Orange;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
