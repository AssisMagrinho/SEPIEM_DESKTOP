using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SEPIEM
{
    public partial class frmLogin : Form
    {
        public static string usuarioLogado;

        public frmLogin()
        {
            InitializeComponent();
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


        frmRegistrarUsuario registrar = new frmRegistrarUsuario();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            registrar.Show();
            timer1.Start();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);

                // this.Alert("Ligado à Internet ", formAlert.enmType.Conneted);
            }
            catch
            {

                this.Alert("Sem Ligado à Internet ", formAlert.enmType.NotConnected);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            registrar.Left += 10;
            if(registrar.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                registrar.TopMost = true;
                timer2.Start();
               
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            registrar.Left -= 100;
            if (registrar.Left <= 525)
            {
                timer2.Stop();

                this.Close();

            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtBI.Clear();
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtBI.Text == "" || txtSenha.Text == "" ||
                txtBI.Text == "Bilhete de Identidade" || txtSenha.Text == "Senha")
            {
                this.Alert("Preencha todos os campos!!!", formAlert.enmType.Warnig);

            }
            else
            {
                try
                {
                    var res = client.Get("Usuarios/"+txtBI.Text);
                    Usuarios ResUsu = res.ResultAs<Usuarios>();

                    usuarioLogado = ResUsu.nome + " " + ResUsu.sobrenome;

                    Usuarios CurUsu = new Usuarios()
                    {

                        BI = txtBI.Text,
                        senha = txtSenha.Text
                    };
                    
                    if(Usuarios.IsEqual(ResUsu, CurUsu))
                    {
                        frmPrincipal principal = new frmPrincipal(usuarioLogado);
                        principal.Show();                        
                        
                        this.Hide();
                    }
                    else
                    {
                        this.Alert(Usuarios.error, formAlert.enmType.Error);
                    }



                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet\n"+ex, formAlert.enmType.Error);
                }

            }



            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
