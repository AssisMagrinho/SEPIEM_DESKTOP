using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPIEM
{
    public partial class frmPrincipal : Form
    {
        private Button currentButtom;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public static string usuarioLogado;

        public frmPrincipal(string nome)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            usuarioLogado = nome;

            

        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "YWyipBmZ7YgkVUp2W6ukKuYvGgBpRujnqcCEveeL",
            BasePath = "https://newsepiem-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        

        public void Alert(string msg, formAlert.enmType type)
        {
            formAlert frm = new formAlert();
            frm.mostrarAlert(msg, type);
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam , int lParam);


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButtom(Object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButtom != (Button)btnSender)
                {
                    DisableButtom();

                    Color color = SelectThemeColor();
                    currentButtom = (Button)btnSender;
                    currentButtom.BackColor = color;
                    currentButtom.ForeColor = Color.White;
                    currentButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                    btnCloseChildForm.BackColor = color;
                    
                }
            }
        }

        private void DisableButtom()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 87, 143);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
            }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButtom(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);

                // this.Alert("Ligado à Internet ", formAlert.enmType.Conneted);

                lblCurUsu.Text = usuarioLogado;
            }
            catch
            {

                this.Alert("Sem Ligado à Internet ", formAlert.enmType.NotConnected);
            }
            
            string Date = DateTime.Today.ToString("D");
            lblData.Text = Date;
        }

        private void btnUusuarios_Click(object sender, EventArgs e)
        { 
            OpenChildForm(new frmUsuarios(usuarioLogado), sender);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCursos(usuarioLogado), sender);
        }

        private void btnEscolas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEscolas(usuarioLogado), sender);
        }

        private void btnInscritos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmInscricoes(usuarioLogado), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)            
                activeForm.Close();         
            Reset();
        }

        private void Reset()
        {
            DisableButtom();
            lblTitle.Text = "Home";
            panelTitleBar.BackColor = Color.FromArgb(7, 43, 71);
            panelLogo.BackColor = Color.FromArgb(9, 58, 96);
            currentButtom = null;
            btnCloseChildForm.Visible = false;

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult obj = MessageBox.Show("TEM CERTEZA QUE DESEJA SAIR?", "ATENÇÃO",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (obj == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (obj == DialogResult.No)
            {
                e.ToString();
                
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCurUsu_Click(object sender, EventArgs e)
        {

        }
    }
}
