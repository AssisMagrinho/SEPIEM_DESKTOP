using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Net.NetworkInformation;


namespace SEPIEM
{
    public partial class frmEscolas : Form
    {
        public frmEscolas()
        {
            InitializeComponent();
        }

        

       
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "YWyipBmZ7YgkVUp2W6ukKuYvGgBpRujnqcCEveeL",
            BasePath = "https://newsepiem-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        

        public void Alert(string msg, formAlert.enmType type )
        {
            formAlert frm = new formAlert();
            frm.mostrarAlert(msg, type);
        }

        private void btnUusuarios_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecionar Imagem";
            ofd.Filter = "Image Files(*.jpg, *.jpeg, *.bmp, *.png ) | *.jpg; *.jpeg; *.bmp; *.png |All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageBoxEscola.Load(ofd.FileName);  

            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private  void btnMinimizar_Click(object sender, EventArgs e)
        {

            if (txtDesignacao.Text == "Designação" || txtLat.Text == "Latitude" || txtLong.Text == "Longitude" || txtLocalizacao.Text == "Localização/Bairro"
                || txtDescricao.Text == "Digite aquí sobre a escola a Descrição, Missão, Outros..." || imageBoxEscola == null 
                || txtDesignacao.Text == "" || txtLat.Text == "" || txtLong.Text == "" || txtLocalizacao.Text == ""
                || txtDescricao.Text == "")
            {
                this.Alert("Preencha todos os campos!!!", formAlert.enmType.Warnig);
            }
            else
            {

                Escolas escola = new Escolas()
                {
                    designacao = txtDesignacao.Text,
                    longitude = txtLong.Text,
                    latitude = txtLat.Text,
                    localizacao = txtLocalizacao.Text,
                    imagem = ImageIntoBase64String(imageBoxEscola),
                    descricao = txtDescricao.Text
                };

                try
                {
                    var set2 = client.Set("Escolas/" + txtDesignacao.Text, escola);
                    //MessageBox.Show("Dados Inseridos com Sucesso !!!");

                    this.Alert("ÊXito no Cadastro", formAlert.enmType.Sucess);
                }
                catch
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligação à internet", formAlert.enmType.Error);
                }

            }

            
            
            
        }



        private void frmEscolas_Load(object sender, EventArgs e)
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

      

        private void txtProcurarUsu_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            if (txtProcurarEscola.Text == "Pesquisar" || txtProcurarEscola.Text == "")
            {

                this.Alert("Informe a Escola, Por favor !!!", formAlert.enmType.Warnig);
            }
            else
            {

                try
                {
                    var res = client.Get("Escolas/" + txtProcurarEscola.Text);
                    Escolas escolas = res.ResultAs<Escolas>();

                    txtDesignacao.Text = escolas.designacao;
                    txtLong.Text = escolas.longitude;
                    txtLat.Text = escolas.latitude;
                    imageBoxEscola.Image = Base64StringIntoImage(escolas.imagem);
                    txtDescricao.Text = escolas.descricao;

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                }

            }
           
        }
        public static string ImageIntoBase64String(PictureBox pbox)
        {

            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        }

        public static Image Base64StringIntoImage(string str64)
        {
            byte[] img = Convert.FromBase64String(str64);
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.Alert("Não disponível no momento", formAlert.enmType.Info);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtDesignacao.Text == "Designação" || txtLat.Text == "Latitude" || txtLong.Text == "Longitude" || txtLocalizacao.Text == "Localização/Bairro"
               || txtDescricao.Text == "Digite aquí sobre a escola a Descrição, Missão, Outros..." || imageBoxEscola == null
               || txtDesignacao.Text == "" || txtLat.Text == "" || txtLong.Text == "" || txtLocalizacao.Text == ""
               || txtDescricao.Text == "")
            {
                this.Alert("Preencha todos os campos!!!", formAlert.enmType.Warnig);
            }
            else
            {
                Escolas escola = new Escolas()
                {
                    designacao = txtDesignacao.Text,
                    longitude = txtLong.Text,
                    latitude = txtLat.Text,
                    localizacao = txtLocalizacao.Text,
                    imagem = ImageIntoBase64String(imageBoxEscola),
                    descricao = txtDescricao.Text
                };

                try
                {
                    var set2 = client.Update("Escolas/" + txtProcurarEscola.Text, escola);
                    //MessageBox.Show("Dados Inseridos com Sucesso !!!");

                    this.Alert("ÊXito na Atualização", formAlert.enmType.Sucess);
                }
                catch
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligação à internet", formAlert.enmType.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmListarEscolas escola = new frmListarEscolas();

            escola.Show();

            //this.Alert("ÊXito na Impressão", formAlert.enmType.Info);
        }

        private void txtDesignacao_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDesignacao_Click(object sender, EventArgs e)
        {
            txtDesignacao.Clear();
        }

        private void txtProcurarEscola_Click(object sender, EventArgs e)
        {
            txtProcurarEscola.Clear();
        }

        private void txtLong_Click(object sender, EventArgs e)
        {
            txtLong.Clear();
        }

        private void txtLat_Click(object sender, EventArgs e)
        {
            txtLat.Clear();
        }
        private void txtLocalizacao_Click(object sender, EventArgs e)
        {
            txtLocalizacao.Clear();
        }

        private void txtDescricao_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
        }
    }
}
