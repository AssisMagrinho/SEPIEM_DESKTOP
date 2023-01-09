using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace SEPIEM
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
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

        private void principal_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                // MessageBox.Show("Houve um problema na internet"); 
                this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtBI.Text ==""|| txtNome.Text == "" || txtSobrenome.Text == "" || txtEmail.Text == "" || txtSenha.Text == "" ||
           txtBI.Text == "Bilhete de Identidade" || txtNome.Text == "Nome" || txtSobrenome.Text == "Sobrenome" || txtEmail.Text == "Email" || txtSenha.Text == "Senha")
            {
                this.Alert("Preencha todos os campos!!!", formAlert.enmType.Warnig);
            }
            else
            {
                Usuarios Usu = new Usuarios()
                {
                    BI = txtBI.Text,
                    nome = txtNome.Text,
                    sobrenome = txtSobrenome.Text,
                    email = txtEmail.Text,
                    senha = txtSenha.Text
                };


                try
                {
                    var setter = client.Set("Usuarios/" + txtBI.Text, Usu);
                    //   MessageBox.Show("Dados Inseridos com Sucesso !!!");
                    this.Alert("ÊXito no Cadastro", formAlert.enmType.Sucess);

                    this.Close();
                    frmLogin login = new frmLogin();
                    login.Show();

                }
                catch(Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet\n"+ex, formAlert.enmType.Error);

                   // this.Alert("" + ex, formAlert.enmType.Error);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_Click(object sender, EventArgs e)
        {
            txtSobrenome.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtBI.Clear();
        }
    }
}
