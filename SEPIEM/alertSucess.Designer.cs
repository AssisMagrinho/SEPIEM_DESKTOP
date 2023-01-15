namespace SEPIEM
{
    partial class formAlert
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PbImgAlert = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbImgAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMsg.Location = new System.Drawing.Point(154, 24);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(149, 30);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Mensagem";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PbImgAlert
            // 
            this.PbImgAlert.Image = global::SEPIEM.Properties.Resources.sucesso;
            this.PbImgAlert.Location = new System.Drawing.Point(12, 12);
            this.PbImgAlert.Name = "PbImgAlert";
            this.PbImgAlert.Size = new System.Drawing.Size(54, 50);
            this.PbImgAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImgAlert.TabIndex = 2;
            this.PbImgAlert.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Image = global::SEPIEM.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(540, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 44);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(607, 80);
            this.Controls.Add(this.PbImgAlert);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAlert";
            this.Text = "alertSucess";
            this.Load += new System.EventHandler(this.alertSucess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbImgAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox PbImgAlert;
        private System.Windows.Forms.Timer timer1;
    }
}