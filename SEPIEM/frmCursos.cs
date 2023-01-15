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
    public partial class frmCursos : Form
    {
        public frmCursos()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"ContCursos");
            int qtdCursos = int.Parse(res.ResultAs<string>());
            
            if (txtDesignacaoCurso.Text == "Designação" || txtDesignacaoCurso.Text == "" ||
                txtEscola.Text == "Escola" || txtEscola.Text == "")
            {
                this.Alert("Preencha todos os campos!!!", formAlert.enmType.Warnig);
            }
            else
            {

                String ID_Curso = txtDesignacaoCurso.Text + "_" + txtEscola.Text;
                Cursos curso = new Cursos()
                {
                    designacao = txtDesignacaoCurso.Text,
                    escola = txtEscola.Text,

                };


                try
                {
                    var set = client.Set("Cursos/" + ID_Curso, curso);
                    // MessageBox.Show("Dados Inseridos com Sucesso !!!");

                    var set1 = client.Set(@"ContCursos", ++qtdCursos);


                    this.Alert("ÊXito no Cadastro", formAlert.enmType.Sucess);

                    preencherTabelaEscola();
                }
                catch
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligação à internet", formAlert.enmType.Error);
                }
            }
        }

        private void frmCursos_Load(object sender, EventArgs e)
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
            totalCursos();

        }

        private void totalCursos()
        {
            try
            {
                //   FirebaseResponse res1 = client.Get(@"ContCursos");
                //  int qtdCursos = int.Parse(res1.ResultAs<string>());
                //  lblTotalCursos.Text = qtdCursos.ToString();

                int totalInscritos = int.Parse(dataGridView1.Rows.Count.ToString());
                lblTotalCursos.Text = totalInscritos.ToString();



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
                FirebaseResponse res1 = client.Get(@"Cursos");
                Dictionary<string, Cursos> data = JsonConvert.DeserializeObject<Dictionary<string, Cursos>>(res1.Body.ToString());

                conteudoTabela(data);

            }
            catch(Exception e)
            {
                this.Alert("Não foi possível carregar as informações...\n Verifique a ligação à internet", formAlert.enmType.Error);
            }

        }

      void conteudoTabela(Dictionary<string, Cursos> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            

            dataGridView1.ForeColor = Color.Black;

            

            dataGridView1.Columns.Add("", "Curso");
            dataGridView1.Columns.Add("", "Escola");

            dataGridView1.Columns[0].Width = 510;
            dataGridView1.Columns[1].Width = 510;
            
            

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

           

            

            columnHeaderStyle.BackColor = Color.DarkBlue;           

            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            columnHeaderStyle.Padding = new Padding(10, 10, 10, 10);


            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

           

            

           


            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Value.designacao, item.Value.escola);
            }



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtProcurarEscola.Text == "Pesquisar Escola" || txtProcurarEscola.Text == "")
            {
                this.Alert("Informe a Escola, Por favor !!!", formAlert.enmType.Warnig);
            }
            else
            {

                try
                {
                    var res = client.Get("Escolas/" + txtProcurarEscola.Text);
                    Escolas escolas = res.ResultAs<Escolas>();

                    txtEscola.Text = escolas.designacao;

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                }

            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);

        }

        private void txtProcurarEscola_Click(object sender, EventArgs e)
        {
            txtProcurarEscola.Clear();
        }

        private void txtDesignacaoCurso_Click(object sender, EventArgs e)
        {
            txtDesignacaoCurso.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtDesignacaoCurso.Text == "Designação" || txtDesignacaoCurso.Text == "" ||
               txtEscola.Text == "Escola" || txtEscola.Text == "")
            {
                this.Alert("Preencha todos os campos!!!", formAlert.enmType.Warnig);
            }
            else
            {

                
                Cursos curso = new Cursos()
                {
                    designacao = txtDesignacaoCurso.Text,
                    escola = txtEscola.Text,

                };


                try
                {
                    var set = client.Update("Cursos/" + txtPesquisarCurso.Text, curso);
                    // MessageBox.Show("Dados Inseridos com Sucesso !!!");
                    this.Alert("ÊXito na Actualização", formAlert.enmType.Sucess);

                    preencherTabelaEscola();
                }
                catch
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                }
            }
        }

        private void btnProcurarEscola_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisarCurso_Click(object sender, EventArgs e)
        {

            if (txtPesquisarCurso.Text == "Pesquisar Curso [nomeCurso_nomeEscola]" || txtPesquisarCurso.Text == "")
            {
                this.Alert("Informe o Curso, Por favor !!!", formAlert.enmType.Warnig);
            }
            else
            {

                try
                {
                    var res = client.Get("Cursos/" + txtPesquisarCurso.Text);
                    Cursos cursos = res.ResultAs<Cursos>();

                    txtDesignacaoCurso.Text = cursos.designacao;
                    txtEscola.Text = cursos.escola;

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                }

            }
        }

        private void txtPesquisarCurso_Click(object sender, EventArgs e)
        {
            txtPesquisarCurso.Clear();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"ContCursos");
            int qtdCursos = int.Parse(res.ResultAs<string>());

            if (txtPesquisarCurso.Text == "Pesquisar Curso [nomeCurso_nomeEscola]" || txtPesquisarCurso.Text == "")
            {
                this.Alert("Informe o Curso, Por favor !!!", formAlert.enmType.Warnig);
            }
            else
            {

                try
                {
                    var res1 = client.Delete("Cursos/" + txtPesquisarCurso.Text);
                    var set1 = client.Set(@"ContCursos", --qtdCursos);

                    this.Alert("Curso Excluído com Êxito", formAlert.enmType.Sucess);

                    preencherTabelaEscola();
                    totalCursos();

                }
                catch (Exception ex)
                {
                    this.Alert("Algo Correu Mal...\n ou Verifique a ligação à internet", formAlert.enmType.Error);
                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string curso = Convert.ToString(selectedRow.Cells[0].Value);
                string escola = Convert.ToString(selectedRow.Cells[1].Value);
                string cellValue = curso + "_" + escola;

                txtPesquisarCurso.Text = cellValue;

                if (cellValue == "")
                {
                    this.Alert("Campo Inválido !!!", formAlert.enmType.Warnig);
                }
                else
                {

                    try
                    {
                        var res = client.Get("Cursos/" + cellValue);
                        Cursos cursos = res.ResultAs<Cursos>();

                        txtDesignacaoCurso.Text = cursos.designacao;
                        txtEscola.Text = cursos.escola;

                    }
                    catch (Exception ex)
                    {
                        this.Alert("Algo Correu Mal...\n ou Verifique a ligaão à internet", formAlert.enmType.Error);
                    }

                }



            }

            }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
