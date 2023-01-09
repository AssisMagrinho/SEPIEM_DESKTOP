using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SEPIEM
{
    public partial class frmSplash : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nleftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeigthEllipse
            );

        public frmSplash()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularProgressBar.Value = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circularProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar.Value += 1;
            circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
            
            if(circularProgressBar.Value == 100)
            {
                timer1.Enabled = false;
                frmLogin fPrincipal = new frmLogin();
                fPrincipal.Show();
                this.Hide();
            }

        }
    }
}
