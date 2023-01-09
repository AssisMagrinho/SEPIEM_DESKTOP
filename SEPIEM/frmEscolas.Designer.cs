namespace SEPIEM
{
    partial class frmEscolas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolas));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtDesignacao = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCarregarImagemEscola = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBoxEscola = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCadastrarEscola = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcurarEscola = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtProcurarEscola = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxEscola)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Controls.Add(this.tableLayoutPanel9);
            this.panel3.Controls.Add(this.tableLayoutPanel10);
            this.panel3.Controls.Add(this.tableLayoutPanel8);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(0, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1478, 519);
            this.panel3.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.txtDescricao, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(143, 57);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1123, 195);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.Location = new System.Drawing.Point(3, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1117, 189);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.Text = "Digite aquí sobre a escola a Descrição, Missão, Outros...";
            this.txtDescricao.Click += new System.EventHandler(this.txtDescricao_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.Controls.Add(this.txtLocalizacao, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtLat, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtLong, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtDesignacao, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(143, 6);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1126, 45);
            this.tableLayoutPanel9.TabIndex = 12;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.txtLocalizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalizacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLocalizacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacao.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLocalizacao.Location = new System.Drawing.Point(846, 3);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(277, 35);
            this.txtLocalizacao.TabIndex = 5;
            this.txtLocalizacao.Text = "Localização/Bairro";
            this.txtLocalizacao.Click += new System.EventHandler(this.txtLocalizacao_Click);
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.txtLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLat.Location = new System.Drawing.Point(565, 3);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(275, 35);
            this.txtLat.TabIndex = 4;
            this.txtLat.Text = "Latitude";
            this.txtLat.Click += new System.EventHandler(this.txtLat_Click);
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.txtLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLong.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLong.Location = new System.Drawing.Point(284, 3);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(275, 35);
            this.txtLong.TabIndex = 3;
            this.txtLong.Text = "Longitude";
            this.txtLong.Click += new System.EventHandler(this.txtLong_Click);
            // 
            // txtDesignacao
            // 
            this.txtDesignacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.txtDesignacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesignacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDesignacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesignacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignacao.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDesignacao.Location = new System.Drawing.Point(3, 3);
            this.txtDesignacao.Name = "txtDesignacao";
            this.txtDesignacao.Size = new System.Drawing.Size(275, 35);
            this.txtDesignacao.TabIndex = 2;
            this.txtDesignacao.Text = "Designação";
            this.txtDesignacao.Click += new System.EventHandler(this.txtDesignacao_Click);
            this.txtDesignacao.TextChanged += new System.EventHandler(this.txtDesignacao_TextChanged);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.Controls.Add(this.btnCarregarImagemEscola, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(146, 356);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(471, 72);
            this.tableLayoutPanel10.TabIndex = 11;
            // 
            // btnCarregarImagemEscola
            // 
            this.btnCarregarImagemEscola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCarregarImagemEscola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarImagemEscola.FlatAppearance.BorderSize = 0;
            this.btnCarregarImagemEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarImagemEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarImagemEscola.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCarregarImagemEscola.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarImagemEscola.Image")));
            this.btnCarregarImagemEscola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregarImagemEscola.Location = new System.Drawing.Point(71, 3);
            this.btnCarregarImagemEscola.Name = "btnCarregarImagemEscola";
            this.btnCarregarImagemEscola.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCarregarImagemEscola.Size = new System.Drawing.Size(329, 66);
            this.btnCarregarImagemEscola.TabIndex = 7;
            this.btnCarregarImagemEscola.Text = "Carregar Imagem";
            this.btnCarregarImagemEscola.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarregarImagemEscola.UseVisualStyleBackColor = true;
            this.btnCarregarImagemEscola.Click += new System.EventHandler(this.btnUusuarios_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.imageBoxEscola, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(634, 274);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(635, 157);
            this.tableLayoutPanel8.TabIndex = 9;
            // 
            // imageBoxEscola
            // 
            this.imageBoxEscola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBoxEscola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxEscola.Image = global::SEPIEM.Properties.Resources.UserButtom1;
            this.imageBoxEscola.Location = new System.Drawing.Point(3, 3);
            this.imageBoxEscola.Name = "imageBoxEscola";
            this.imageBoxEscola.Size = new System.Drawing.Size(629, 151);
            this.imageBoxEscola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxEscola.TabIndex = 0;
            this.imageBoxEscola.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.tableLayoutPanel5);
            this.panel5.Controls.Add(this.tableLayoutPanel6);
            this.panel5.Controls.Add(this.btnMaximizar);
            this.panel5.Controls.Add(this.btnCadastrarEscola);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 459);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1478, 60);
            this.panel5.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::SEPIEM.Properties.Resources.list_32px;
            this.button2.Location = new System.Drawing.Point(898, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 45);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1541, 100);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1450, 65);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximizar.Image = global::SEPIEM.Properties.Resources.RemoveUsu00;
            this.btnMaximizar.Location = new System.Drawing.Point(711, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(65, 45);
            this.btnMaximizar.TabIndex = 9;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCadastrarEscola
            // 
            this.btnCadastrarEscola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarEscola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarEscola.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEscola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarEscola.Image = global::SEPIEM.Properties.Resources.addUsu;
            this.btnCadastrarEscola.Location = new System.Drawing.Point(617, 3);
            this.btnCadastrarEscola.Name = "btnCadastrarEscola";
            this.btnCadastrarEscola.Size = new System.Drawing.Size(65, 45);
            this.btnCadastrarEscola.TabIndex = 8;
            this.btnCadastrarEscola.UseVisualStyleBackColor = true;
            this.btnCadastrarEscola.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = global::SEPIEM.Properties.Resources.updateUsu;
            this.btnClose.Location = new System.Drawing.Point(806, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btnProcurarEscola);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtProcurarEscola);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 154);
            this.panel1.TabIndex = 6;
            // 
            // btnProcurarEscola
            // 
            this.btnProcurarEscola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcurarEscola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnProcurarEscola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarEscola.FlatAppearance.BorderSize = 0;
            this.btnProcurarEscola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnProcurarEscola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnProcurarEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarEscola.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarEscola.Image")));
            this.btnProcurarEscola.Location = new System.Drawing.Point(331, 89);
            this.btnProcurarEscola.Name = "btnProcurarEscola";
            this.btnProcurarEscola.Size = new System.Drawing.Size(55, 42);
            this.btnProcurarEscola.TabIndex = 0;
            this.btnProcurarEscola.UseVisualStyleBackColor = false;
            this.btnProcurarEscola.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1478, 56);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.panel6.Controls.Add(this.tableLayoutPanel4);
            this.panel6.Controls.Add(this.tableLayoutPanel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1478, 56);
            this.panel6.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1541, 100);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1450, 65);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1541, 100);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1450, 65);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(392, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 1);
            this.panel4.TabIndex = 12;
            // 
            // txtProcurarEscola
            // 
            this.txtProcurarEscola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProcurarEscola.AutoCompleteCustomSource.AddRange(new string[] {
            "IMNE",
            "Garsu"});
            this.txtProcurarEscola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.txtProcurarEscola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcurarEscola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProcurarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurarEscola.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtProcurarEscola.Location = new System.Drawing.Point(394, 89);
            this.txtProcurarEscola.Multiline = true;
            this.txtProcurarEscola.Name = "txtProcurarEscola";
            this.txtProcurarEscola.Size = new System.Drawing.Size(649, 35);
            this.txtProcurarEscola.TabIndex = 1;
            this.txtProcurarEscola.Text = "Pesquisar";
            this.txtProcurarEscola.Click += new System.EventHandler(this.txtProcurarEscola_Click);
            this.txtProcurarEscola.TextChanged += new System.EventHandler(this.txtProcurarUsu_TextChanged);
            // 
            // frmEscolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1478, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1500, 729);
            this.Name = "frmEscolas";
            this.Text = "Escolas";
            this.Load += new System.EventHandler(this.frmEscolas_Load);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxEscola)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCadastrarEscola;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcurarEscola;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtProcurarEscola;
        private System.Windows.Forms.PictureBox imageBoxEscola;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnCarregarImagemEscola;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtDesignacao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}