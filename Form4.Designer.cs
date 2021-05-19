
namespace Registro
{
    partial class FormValidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidacion));
            this.lblEscanear = new System.Windows.Forms.Label();
            this.lblForoPerfilVal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalirVal = new System.Windows.Forms.PictureBox();
            this.btnValidar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnVolver = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pctFotoPerfil = new System.Windows.Forms.PictureBox();
            this.pctEscanear = new System.Windows.Forms.PictureBox();
            this.lblCamara = new System.Windows.Forms.Label();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtInfoEst = new System.Windows.Forms.TextBox();
            this.grpInfoPerfil = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEscanear)).BeginInit();
            this.grpInfoPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEscanear
            // 
            this.lblEscanear.AutoSize = true;
            this.lblEscanear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscanear.Location = new System.Drawing.Point(108, 93);
            this.lblEscanear.Name = "lblEscanear";
            this.lblEscanear.Size = new System.Drawing.Size(93, 19);
            this.lblEscanear.TabIndex = 1;
            this.lblEscanear.Text = "Código QR";
            // 
            // lblForoPerfilVal
            // 
            this.lblForoPerfilVal.AutoSize = true;
            this.lblForoPerfilVal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForoPerfilVal.Location = new System.Drawing.Point(338, 93);
            this.lblForoPerfilVal.Name = "lblForoPerfilVal";
            this.lblForoPerfilVal.Size = new System.Drawing.Size(106, 19);
            this.lblForoPerfilVal.TabIndex = 1;
            this.lblForoPerfilVal.Text = "Foto de Perfil";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnSalirVal);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 28);
            this.panel1.TabIndex = 4;
            // 
            // btnSalirVal
            // 
            this.btnSalirVal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalirVal.Image = global::Registro.Properties.Resources.emblemunreadable_93487;
            this.btnSalirVal.Location = new System.Drawing.Point(532, 3);
            this.btnSalirVal.Name = "btnSalirVal";
            this.btnSalirVal.Size = new System.Drawing.Size(24, 23);
            this.btnSalirVal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalirVal.TabIndex = 0;
            this.btnSalirVal.TabStop = false;
            this.btnSalirVal.Click += new System.EventHandler(this.btnSalirVal_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.ActiveBorderThickness = 1;
            this.btnValidar.ActiveCornerRadius = 20;
            this.btnValidar.ActiveFillColor = System.Drawing.Color.MidnightBlue;
            this.btnValidar.ActiveForecolor = System.Drawing.Color.White;
            this.btnValidar.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.btnValidar.BackColor = System.Drawing.Color.White;
            this.btnValidar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidar.BackgroundImage")));
            this.btnValidar.ButtonText = "Validar";
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnValidar.IdleBorderThickness = 1;
            this.btnValidar.IdleCornerRadius = 20;
            this.btnValidar.IdleFillColor = System.Drawing.Color.White;
            this.btnValidar.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnValidar.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.btnValidar.Location = new System.Drawing.Point(297, 579);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(201, 41);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.ActiveBorderThickness = 1;
            this.btnVolver.ActiveCornerRadius = 20;
            this.btnVolver.ActiveFillColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.ActiveForecolor = System.Drawing.Color.White;
            this.btnVolver.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.ButtonText = "Volver";
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.IdleBorderThickness = 1;
            this.btnVolver.IdleCornerRadius = 20;
            this.btnVolver.IdleFillColor = System.Drawing.Color.White;
            this.btnVolver.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.Location = new System.Drawing.Point(53, 579);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(201, 41);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pctFotoPerfil
            // 
            this.pctFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFotoPerfil.Location = new System.Drawing.Point(297, 123);
            this.pctFotoPerfil.Name = "pctFotoPerfil";
            this.pctFotoPerfil.Size = new System.Drawing.Size(182, 142);
            this.pctFotoPerfil.TabIndex = 0;
            this.pctFotoPerfil.TabStop = false;
            // 
            // pctEscanear
            // 
            this.pctEscanear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctEscanear.Location = new System.Drawing.Point(72, 123);
            this.pctEscanear.Name = "pctEscanear";
            this.pctEscanear.Size = new System.Drawing.Size(182, 142);
            this.pctEscanear.TabIndex = 0;
            this.pctEscanear.TabStop = false;
            // 
            // lblCamara
            // 
            this.lblCamara.AutoSize = true;
            this.lblCamara.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamara.Location = new System.Drawing.Point(69, 49);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(62, 16);
            this.lblCamara.TabIndex = 5;
            this.lblCamara.Text = "Cámara";
            // 
            // cmbCamara
            // 
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(137, 48);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(342, 21);
            this.cmbCamara.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtInfoEst
            // 
            this.txtInfoEst.Enabled = false;
            this.txtInfoEst.Location = new System.Drawing.Point(40, 59);
            this.txtInfoEst.Multiline = true;
            this.txtInfoEst.Name = "txtInfoEst";
            this.txtInfoEst.Size = new System.Drawing.Size(332, 160);
            this.txtInfoEst.TabIndex = 2;
            // 
            // grpInfoPerfil
            // 
            this.grpInfoPerfil.Controls.Add(this.txtInfoEst);
            this.grpInfoPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoPerfil.Location = new System.Drawing.Point(72, 282);
            this.grpInfoPerfil.Name = "grpInfoPerfil";
            this.grpInfoPerfil.Size = new System.Drawing.Size(407, 276);
            this.grpInfoPerfil.TabIndex = 2;
            this.grpInfoPerfil.TabStop = false;
            this.grpInfoPerfil.Text = "Información de Perfil";
            // 
            // FormValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 651);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCamara);
            this.Controls.Add(this.lblCamara);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpInfoPerfil);
            this.Controls.Add(this.lblForoPerfilVal);
            this.Controls.Add(this.lblEscanear);
            this.Controls.Add(this.pctFotoPerfil);
            this.Controls.Add(this.pctEscanear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormValidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormValidacion_FormClosing);
            this.Load += new System.EventHandler(this.FormValidacion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEscanear)).EndInit();
            this.grpInfoPerfil.ResumeLayout(false);
            this.grpInfoPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctEscanear;
        private System.Windows.Forms.PictureBox pctFotoPerfil;
        private System.Windows.Forms.Label lblEscanear;
        private System.Windows.Forms.Label lblForoPerfilVal;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSalirVal;
        private Bunifu.Framework.UI.BunifuThinButton2 btnValidar;
        private System.Windows.Forms.Label lblCamara;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtInfoEst;
        private System.Windows.Forms.GroupBox grpInfoPerfil;
    }
}