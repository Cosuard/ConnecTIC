
namespace ConnecTic
{
    partial class FormValidacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQR = new System.Windows.Forms.Label();
            this.pctQR = new System.Windows.Forms.PictureBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.grpPerfil = new System.Windows.Forms.GroupBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.txtCodEstudiantil = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.lblCodEstudiantil = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctQR)).BeginInit();
            this.grpPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQR.Location = new System.Drawing.Point(64, 77);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(84, 16);
            this.lblQR.TabIndex = 0;
            this.lblQR.Text = "Código QR";
            // 
            // pctQR
            // 
            this.pctQR.Location = new System.Drawing.Point(13, 108);
            this.pctQR.Name = "pctQR";
            this.pctQR.Size = new System.Drawing.Size(182, 190);
            this.pctQR.TabIndex = 1;
            this.pctQR.TabStop = false;
            // 
            // btnValidar
            // 
            this.btnValidar.BackgroundImage = global::ConnecTic.Properties.Resources.Pficture1;
            this.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(12, 334);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(182, 32);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // grpPerfil
            // 
            this.grpPerfil.Controls.Add(this.txtRol);
            this.grpPerfil.Controls.Add(this.txtPrograma);
            this.grpPerfil.Controls.Add(this.txtCodEstudiantil);
            this.grpPerfil.Controls.Add(this.lblRol);
            this.grpPerfil.Controls.Add(this.txtNombre);
            this.grpPerfil.Controls.Add(this.lblPrograma);
            this.grpPerfil.Controls.Add(this.lblCodEstudiantil);
            this.grpPerfil.Controls.Add(this.lblNombre);
            this.grpPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPerfil.Location = new System.Drawing.Point(448, 108);
            this.grpPerfil.Name = "grpPerfil";
            this.grpPerfil.Size = new System.Drawing.Size(449, 190);
            this.grpPerfil.TabIndex = 3;
            this.grpPerfil.TabStop = false;
            this.grpPerfil.Text = "Perfil";
            // 
            // txtRol
            // 
            this.txtRol.Enabled = false;
            this.txtRol.Location = new System.Drawing.Point(152, 152);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(222, 22);
            this.txtRol.TabIndex = 3;
            // 
            // txtPrograma
            // 
            this.txtPrograma.Enabled = false;
            this.txtPrograma.Location = new System.Drawing.Point(152, 116);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(222, 22);
            this.txtPrograma.TabIndex = 3;
            // 
            // txtCodEstudiantil
            // 
            this.txtCodEstudiantil.Enabled = false;
            this.txtCodEstudiantil.Location = new System.Drawing.Point(152, 73);
            this.txtCodEstudiantil.Name = "txtCodEstudiantil";
            this.txtCodEstudiantil.Size = new System.Drawing.Size(222, 22);
            this.txtCodEstudiantil.TabIndex = 3;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(22, 155);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 16);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(152, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrograma.Location = new System.Drawing.Point(22, 119);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(68, 16);
            this.lblPrograma.TabIndex = 2;
            this.lblPrograma.Text = "Programa";
            // 
            // lblCodEstudiantil
            // 
            this.lblCodEstudiantil.AutoSize = true;
            this.lblCodEstudiantil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEstudiantil.Location = new System.Drawing.Point(19, 76);
            this.lblCodEstudiantil.Name = "lblCodEstudiantil";
            this.lblCodEstudiantil.Size = new System.Drawing.Size(116, 16);
            this.lblCodEstudiantil.TabIndex = 1;
            this.lblCodEstudiantil.Text = "Código Estudiantíl";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(924, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foto de perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(229, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 190);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 36);
            this.panel1.TabIndex = 5;
            // 
            // FormValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(955, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPerfil);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQR);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormValidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormValidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctQR)).EndInit();
            this.grpPerfil.ResumeLayout(false);
            this.grpPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQR;
        private System.Windows.Forms.PictureBox pctQR;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.GroupBox grpPerfil;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.Label lblCodEstudiantil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.TextBox txtCodEstudiantil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

