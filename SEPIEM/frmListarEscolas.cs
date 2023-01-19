using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV2Printer;

namespace SEPIEM
{
    public partial class frmListarEscolas : Form
    {
        public static string usuarioLogado;
        public frmListarEscolas(string nome)
        {
            InitializeComponent();

            usuarioLogado = nome;
        }

        public void Alert(string msg, formAlert.enmType type)
        {
            formAlert frm = new formAlert();
            frm.mostrarAlert(msg, type);
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "YWyipBmZ7YgkVUp2W6ukKuYvGgBpRujnqcCEveeL",
            BasePath = "https://newsepiem-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void frmListarEscolas_Load(object sender, EventArgs e)
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

            preencherTabelaEscola();
            totalEscolas();


        }

        private void totalEscolas()
        {
            try
            {
                int totalInscritos = int.Parse(dataGridView1.Rows.Count.ToString());
                lblTotalEscolas.Text = totalInscritos.ToString();

            }
            catch (Exception e)
            {
                this.Alert("Não foi possível carregar as informações...\n Verifique a ligação à internet", formAlert.enmType.Error);
            }
        }

        private async void preencherTabelaEscola()
        {
            try
            {
                FirebaseResponse res2 = client.Get(@"Escolas");
                Dictionary<string, Escolas> data = JsonConvert.DeserializeObject<Dictionary<string, Escolas>>(res2.Body.ToString());

                conteudoTabela(data);
            }
            catch
            {
                this.Alert("Não foi possível carregar as informações...\n Verifique a ligação à internet", formAlert.enmType.Error);
            }
            
        }

        void conteudoTabela(Dictionary<string, Escolas> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            dataGridView1.ForeColor = Color.Black;



            dataGridView1.Columns.Add("", "Designaçãp");
            dataGridView1.Columns.Add("", "Longitude");
            dataGridView1.Columns.Add("", "Latitude");
            dataGridView1.Columns.Add("", "Localização");
           
          

            dataGridView1.Columns[0].Width = 340;
            dataGridView1.Columns[1].Width = 340;
            dataGridView1.Columns[2].Width = 340;
            dataGridView1.Columns[3].Width = 340;



            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();


            columnHeaderStyle.BackColor = Color.DarkBlue;

            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            columnHeaderStyle.Padding = new Padding(10, 10, 10, 10);


            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            

            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Value.designacao, item.Value.longitude, item.Value.latitude, item.Value.localizacao);
            }


        }

        private void btnImprimirEscolas_Click(object sender, EventArgs e)
        {
            //Capturar Hora
            string hora = DateTime.Now.ToShortTimeString();
            //Capturar data
            string data = DateTime.Now.ToShortDateString();


            PrintDataGridView pr = new PrintDataGridView(dataGridView1);
            pr.isRightToLeft = false;
            pr.ReportFooter = "Usuário:" + usuarioLogado + " \t Relatório - ESCOLAS - SEPIEM - DATA :" + data + " " + hora;
            pr.ReportHeader = "ESCOLAS CADASTRADAS - TOTAL :" + lblTotalEscolas.Text;
            pr.Print();
        }
    }
}
