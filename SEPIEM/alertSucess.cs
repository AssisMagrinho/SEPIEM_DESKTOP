using SEPIEM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace SEPIEM
{
    public partial class formAlert : Form
    {
        public formAlert()
        {
            InitializeComponent();
        }

        public bool pingStatus()
        {
            bool pingStatus = false;
            string hostNameOrAddress = "Google.com";

            using (Ping p = new Ping())
            {
                string data = "aaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1000;

                try
                {
                    PingReply reply = p.Send(hostNameOrAddress, timeout, buffer);
                    pingStatus = (reply.Status == IPStatus.Success);
                }
                catch (Exception)
                {
                    pingStatus = false;
                }

                return pingStatus;
            }
        }

        private void alertSucess_Load(object sender, EventArgs e)
        {

        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Sucess,
            Warnig,
            Error,
            Info,
            Conneted,
            NotConnected
        }

        private formAlert.enmAction action;


        private int x, y;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*

            if(pingStatus() == true)
            {
                this.PbImgAlert.Image = Resources.connected;
                this.BackColor = Color.DarkBlue;
                lblMsg.Text = "Ligado à Internet";
            }
            else
            {
                this.PbImgAlert.Image = Resources.not_connected;
                this.BackColor = Color.DarkBlue;
                lblMsg.Text = "Sem ligação à Internet";
            }

    */

            switch(this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;

                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void mostrarAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fnome;

            for(int i = 1; i < 10; i++)
            {
                fnome = "alert" + i.ToString();
                formAlert frm = (formAlert)Application.OpenForms[fnome];

                if(frm == null)
                {
                    this.Name = fnome;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch(type)
            {
                case enmType.Sucess:
                    this.PbImgAlert.Image = Resources.sucesso;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.PbImgAlert.Image = Resources.erro;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.PbImgAlert.Image = Resources.informacao;
                    this.BackColor = Color.DarkBlue;
                    break;
                case enmType.Warnig:
                    this.PbImgAlert.Image = Resources.aviso;
                    this.BackColor = Color.DarkOrange;
                    break;
                case enmType.Conneted:
                    this.PbImgAlert.Image = Resources.connected;
                    this.BackColor = Color.DarkBlue;
                    break;
                case enmType.NotConnected:
                    this.PbImgAlert.Image = Resources.not_connected;
                    this.BackColor = Color.DarkBlue;
                    break;
            }

            this.lblMsg.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();

        }


    }
}
