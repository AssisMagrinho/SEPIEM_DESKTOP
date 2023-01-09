namespace SEPIEM
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBI = new System.Windows.Forms.TextBox();
            this.linkRegistrar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnSair.Location = new System.Drawing.Point(554, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 47);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(251, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(77, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 1);
            this.panel2.TabIndex = 12;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSenha.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSenha.Location = new System.Drawing.Point(77, 375);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(453, 19);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(75, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 1);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBI
            // 
            this.txtBI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txtBI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBI.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBI.Location = new System.Drawing.Point(77, 291);
            this.txtBI.Name = "txtBI";
            this.txtBI.Size = new System.Drawing.Size(453, 19);
            this.txtBI.TabIndex = 9;
            this.txtBI.Text = "Bilhete de Identidade";
            this.txtBI.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtBI.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // linkRegistrar
            // 
            this.linkRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.linkRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.linkRegistrar.Location = new System.Drawing.Point(79, 656);
            this.linkRegistrar.Name = "linkRegistrar";
            this.linkRegistrar.Size = new System.Drawing.Size(451, 49);
            this.linkRegistrar.TabIndex = 17;
            this.linkRegistrar.Text = "Registrar";
            this.linkRegistrar.UseVisualStyleBackColor = false;
            this.linkRegistrar.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(79, 564);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(451, 49);
            this.btnEntrar.TabIndex = 18;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(621, 791);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.linkRegistrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarUsu";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBI;
        private System.Windows.Forms.Button linkRegistrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}