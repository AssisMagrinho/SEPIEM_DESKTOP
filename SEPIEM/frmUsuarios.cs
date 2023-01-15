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

namespace SEPIEM
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
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

        private void frmUsuarios_Load(object sender, EventArgs e)
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

           
            LoadTheme();
            preencherTabelaUsuarios();

            totalUsuarios();


        }

        private void totalUsuarios()
        {
            try
            {
               // FirebaseResponse res1 = client.Get(@"contUsuarios");
                 //int qtdUsuarios = int.Parse(res1.ResultAs<string>());

                 //lblTotalUsuarios.Text = qtdUsuarios.ToString();

                int totalUsuarios = int.Parse(dataGridView1.Rows.Count.ToString())-1;
                 lblTotalUsuarios.Text = totalUsuarios.ToString();

            }
            catch (Exception e)
            {
                this.Alert("Não foi possível carregar as informações...\n Verifique a ligação à internet", formAlert.enmType.Error);
            }

        }

        private async void preencherTabelaUsuarios()
        {

            try
            {
                FirebaseResponse res1 = client.Get(@"Usuarios");
                Dictionary<string, Usuarios> data = JsonConvert.DeserializeObject<Dictionary<string, Usuarios>>(res1.Body.ToString());

                conteudoTabela(data);

            }
            catch (Exception e)
            {
                this.Alert("Não foi possível carregar as informações...\n Verifique a ligação à internet", formAlert.enmType.Error);

            }

        }

        void conteudoTabela(Dictionary<string, Usuarios> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.ForeColor = Color.Black;



            dataGridView1.Columns.Add("", "Nome");
            dataGridView1.Columns.Add("", "Sobrenome");
            dataGridView1.Columns.Add("", "BI");
            dataGridView1.Columns.Add("", "E-mail");


            dataGridView1.Columns[0].Width = 260;
            dataGridView1.Columns[1].Width = 260;
            dataGridView1.Columns[2].Width = 260;
            dataGridView1.Columns[3].Width = 260;



            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();





            columnHeaderStyle.BackColor = Color.DarkBlue;

            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            columnHeaderStyle.Padding = new Padding(10, 10, 10, 10);


            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;








            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Value.nome, item.Value.sobrenome, item.Value.BI, item.Value.email);
            }



        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;


                }
            }

            // label1.ForeColor = ThemeColor.SecondaryColor;
            // btnUsu1.ForeColor = ThemeColor.PrimaryColor;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProcurarUsu_Click(object sender, EventArgs e)
        {
            txtProcurarUsu.Clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddUsu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"contUsuarios");
            int qtdUsuarios = int.Parse(res.ResultAs<string>());

            if (txtBI.Text == "" || txtNome.Text == "" || txtSobrenome.Text == "" || txtEmail.Text == "" || txtSenha.Text == "" ||
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

                    var set1 = client.Set(@"contEscolas", ++qtdUsuarios);

                    totalUsuarios();
                    preencherTabelaUsuarios();
                    limparCampos();

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet\n" + ex, formAlert.enmType.Error);

                    // this.Alert("" + ex, formAlert.enmType.Error);
                }

            }
        }

        private void limparCampos()
        {
            txtProcurarUsu.Clear();
            txtNome.Clear();
            txtSobrenome.Clear();
            txtBI.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProcurarUsu_Click(object sender, EventArgs e)
        {
            if (txtProcurarUsu.Text == "Informe o BI" || txtProcurarUsu.Text == "")
            {
                this.Alert("Informe o BI, Por favor !!!", formAlert.enmType.Warnig);
            }
            else
            {

                try
                {
                    var res = client.Get("Usuarios/" + txtProcurarUsu.Text);
                    Usuarios usuarios = res.ResultAs<Usuarios>();

                    txtNome.Text = usuarios.nome;
                    txtSobrenome.Text = usuarios.sobrenome;
                    txtBI.Text = usuarios.BI;
                    txtEmail.Text = usuarios.email;
                    txtSenha.Text = usuarios.senha;

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[2].Value);

                txtProcurarUsu.Text = cellValue;

                if (cellValue == "")
                {
                    this.Alert("Campo Inválido !!!", formAlert.enmType.Warnig);
                }
                else
                {

                    try
                    {
                        var res = client.Get("Usuarios/" + cellValue);
                        Usuarios usuarios = res.ResultAs<Usuarios>();

                        txtNome.Text = usuarios.nome;
                        txtSobrenome.Text = usuarios.sobrenome;
                        txtBI.Text = usuarios.BI;
                        txtEmail.Text = usuarios.email;
                        txtSenha.Text = usuarios.senha;

                    }
                    catch (Exception ex)
                    {
                        this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                    }

                }
            }


        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            FirebaseResponse res1 = client.Get(@"contUsuarios");
            int qtdUsuarios = int.Parse(res1.ResultAs<string>());

            if (txtProcurarUsu.Text == "Informe o BI" || txtProcurarUsu.Text == "")
            {
                this.Alert("Informe o BI, Por favor !!!", formAlert.enmType.Warnig);
            }
            else
            {

                try
                {
                    var res = client.Delete("Usuarios/" + txtProcurarUsu.Text);

                    this.Alert("Usuário Excluído com Êxito", formAlert.enmType.Sucess);

                    preencherTabelaUsuarios();
                    var set1 = client.Set(@"contUsuarios", --qtdUsuarios);
                    totalUsuarios();
                    limparCampos();

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligação à internet", formAlert.enmType.Error);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtBI.Text == "" || txtNome.Text == "" || txtSobrenome.Text == "" || txtEmail.Text == "" || txtSenha.Text == "" ||
           txtBI.Text == "Bilhete de Identidade" || txtNome.Text == "Nome" || txtSobrenome.Text == "Sobrenome" || txtEmail.Text == "Email" || txtSenha.Text == "Senha")
            {
                this.Alert("Preencha todos os campos!!!", formAlert.enmType.Warnig);
            }
            else
            {


                Usuarios usuarios = new Usuarios()
                {
                    nome = txtNome.Text,
                    sobrenome = txtSobrenome.Text,
                    BI = txtBI.Text,
                    email = txtEmail.Text,
                    senha = txtSenha.Text

                };


                try
                {
                    var set = client.Update("Usuarios/" + txtBI.Text, usuarios);
                    // MessageBox.Show("Dados Inseridos com Sucesso !!!");
                    this.Alert("ÊXito na Actualização", formAlert.enmType.Sucess);

                    preencherTabelaUsuarios();
                }
                catch
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[2].Value);


                txtProcurarUsu.Text = cellValue;

                if (cellValue == "")
                {
                    this.Alert("Campo Inválido !!!", formAlert.enmType.Warnig);
                }
                else
                {

                    try
                    {
                        var res = client.Get("Usuarios/" + txtProcurarUsu.Text);
                        Usuarios usuarios = res.ResultAs<Usuarios>();

                        txtNome.Text = usuarios.nome;
                        txtSobrenome.Text = usuarios.sobrenome;
                        txtBI.Text = usuarios.BI;
                        txtEmail.Text = usuarios.email;
                        txtSenha.Text = usuarios.senha;

                    }
                    catch (Exception ex)
                    {
                        this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                    }

                }
            }
        }
    }
}
