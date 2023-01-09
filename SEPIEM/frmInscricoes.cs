using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPIEM
{
    public partial class frmInscricoes : Form
    {
        public frmInscricoes()
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

        private void frmInscricoes_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);

                //this.Alert("Ligado à Internet ", formAlert.enmType.Conneted);

               
            }
            catch
            {

                this.Alert("Sem Ligado à Internet ", formAlert.enmType.NotConnected);
 }

            preencherTabelaInscritos();
        }


        private async void preencherTabelaInscritos()
        {

            try
            {
                FirebaseResponse res1 = client.Get(@"Inscritos");
                Dictionary<string, Inscritos> data = JsonConvert.DeserializeObject<Dictionary<string, Inscritos>>(res1.Body.ToString());

                conteudoTabela(data);

                

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                this.Alert("Não foi possível carregar as informações...\n Verifique a ligação à internet", formAlert.enmType.Error);
            }

        }

        void conteudoTabela(Dictionary<string, Inscritos> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
          //  dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue;


            dataGridView1.ForeColor = Color.Black;



            dataGridView1.Columns.Add("", "Nome");
            dataGridView1.Columns.Add("", "Apelido1");
            dataGridView1.Columns.Add("", "Apelido2");
            dataGridView1.Columns.Add("", "BI");
            dataGridView1.Columns.Add("", "Nascimento");
            dataGridView1.Columns.Add("", "Curso");
            dataGridView1.Columns.Add("", "Escola");
            dataGridView1.Columns.Add("", "Província");
            
            
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 130;
            dataGridView1.Columns[6].Width = 130;
            dataGridView1.Columns[7].Width = 130;
          
            
           

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();





            columnHeaderStyle.BackColor = Color.DarkBlue;

            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            columnHeaderStyle.Padding = new Padding(10, 10, 10, 10);


            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;








            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Value.nomeProprio, item.Value.apelido1, item.Value.apelido2,
                    item.Value.bilhete,item.Value.nascimento,item.Value.curso, item.Value.escola, item.Value.provincia);
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtProcurarIns.Text == ""|| txtProcurarIns.Text == "Informe o BI")
            {
                this.Alert("Informe o BI, Por favor !!!", formAlert.enmType.Warnig);
            }
            else
            {

                try
                {
                    var res = client.Get("Inscritos/" + txtProcurarIns.Text);
                    Inscritos inscritos = res.ResultAs<Inscritos>();

                    txtNomeProprio.Text = inscritos.nomeProprio;
                    txtApelido1.Text = inscritos.apelido1;
                    txtApelido2.Text = inscritos.apelido2;
                    txtBI.Text = inscritos.bilhete;
                    txtNaturalidade.Text = inscritos.naturalidade;
                    txtResidencia.Text = inscritos.residencia;
                    dtpNascimento.Text = inscritos.nascimento;
                    txtCurso.Text = inscritos.curso;
                    txtEscola.Text = inscritos.escola;
                    cmbProvincia.Text = inscritos.provincia;
                    txtLinkDoc.Text = inscritos.urlDocumentos;
                                      

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet\n"+ex, formAlert.enmType.Error);
                }

            }
        }

        private void txtProcurarIns_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProcurarIns_Click(object sender, EventArgs e)
        {
            txtProcurarIns.Clear();
        }

        private void txtNomeProprio_Click(object sender, EventArgs e)
        {
            txtNomeProprio.Clear();
        }

        private void txtApelido1_Click(object sender, EventArgs e)
        {
            txtApelido1.Clear();
        }

        private void txtApelido2_Click(object sender, EventArgs e)
        {
            txtApelido2.Clear();
        }

        private void txtBI_Click(object sender, EventArgs e)
        {
            txtBI.Clear();
        }

        private void txtNaturalidade_Click(object sender, EventArgs e)
        {
            txtNaturalidade.Clear();
        }

        private void txtResidencia_Click(object sender, EventArgs e)
        {
            txtResidencia.Clear();
        }

        private void txtCurso_Click(object sender, EventArgs e)
        {
            txtCurso.Clear();
        }

        private void txtEscola_Click(object sender, EventArgs e)
        {
            txtEscola.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLinkDoc_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtLinkDoc.Text);
            }
            catch
            {
                this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
            }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[3].Value);


                txtProcurarIns.Text = cellValue;

                if (cellValue == "")
                {
                    this.Alert("Campo Inválido !!!", formAlert.enmType.Warnig);
                }
                else
                {

                    try
                    {
                        var res = client.Get("Inscritos/" + txtProcurarIns.Text);
                        Inscritos inscritos = res.ResultAs<Inscritos>();

                        txtNomeProprio.Text = inscritos.nomeProprio;
                        txtApelido1.Text = inscritos.apelido1;
                        txtApelido2.Text = inscritos.apelido2;
                        txtBI.Text = inscritos.bilhete;
                        txtNaturalidade.Text = inscritos.naturalidade;
                        txtResidencia.Text = inscritos.residencia;
                        dtpNascimento.Text = inscritos.nascimento;
                        txtCurso.Text = inscritos.curso;
                        txtEscola.Text = inscritos.escola;
                        cmbProvincia.Text = inscritos.provincia;
                        txtLinkDoc.Text = inscritos.urlDocumentos;

                    }
                    catch (Exception ex)
                    {
                        this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                    }

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if  (txtNomeProprio.Text == "" || txtApelido1.Text == "" || txtApelido2.Text == "" ||
                txtBI.Text == "" || txtNaturalidade.Text == "" || txtResidencia.Text == "" || dtpNascimento.Text == "" ||
                txtCurso.Text == "" || txtEscola.Text == "" || cmbProvincia.Text == "" || txtLinkDoc.Text ==""||
                txtProcurarIns.Text == "Informe o BI" ||
                txtNomeProprio.Text == "Nome" || txtApelido1.Text == "Apelido1" || txtApelido2.Text == "Apelido2" ||
                txtBI.Text == "Bilhete" || txtNaturalidade.Text == "Naturalidade" || txtResidencia.Text == "Residência" ||
                txtCurso.Text == "Curso" || txtEscola.Text == "Curso" || txtLinkDoc.Text=="Documento")
            {
                this.Alert("Preencha todos os campos!!!", formAlert.enmType.Warnig);
            }
            else
            {


                Inscritos inscritos = new Inscritos()
                {
                    nomeProprio = txtNomeProprio.Text,
                    apelido1 = txtApelido1.Text,
                    apelido2 = txtApelido2.Text,
                    bilhete = txtBI.Text,
                    naturalidade = txtNaturalidade.Text,
                    residencia = txtResidencia.Text,
                    nascimento = dtpNascimento.Text,    
                    curso = txtCurso.Text,
                    escola = txtEscola.Text,
                    provincia = cmbProvincia.Text,
                    urlDocumentos = txtLinkDoc.Text                            

                };


                try
                {
                    var set = client.Update("Inscritos/" + txtProcurarIns.Text, inscritos);
                    // MessageBox.Show("Dados Inseridos com Sucesso !!!");
                    this.Alert("ÊXito na Actualização", formAlert.enmType.Sucess);

                    preencherTabelaInscritos();
                }
                catch
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                }
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (txtProcurarIns.Text == "" || txtProcurarIns.Text == "Informe o BI")
            {
                this.Alert("Informe o Curso, Por favor !!!", formAlert.enmType.Warnig);
            }
            else
            {

                try
                {
                    var res = client.Delete("Inscritos/" + txtProcurarIns.Text);

                    this.Alert("Inscrito Excluído com Êxito", formAlert.enmType.Sucess);

                    preencherTabelaInscritos();

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligação à internet", formAlert.enmType.Error);
                }

            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://newsepiem-default-rtdb.firebaseio.com/");
            }
            catch
            {
                this.Alert("Algo Correu Mal...\n ou Verifique a ligação à internet", formAlert.enmType.Error);

            }

        }

        private void txtLinkDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLinkConvert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://data.page/json/csv");
            }
            catch
            {
                this.Alert("Algo Correu Mal...\n ou Verifique a ligação à internet", formAlert.enmType.Error);
            }
        }
    }
}
