namespace ATM.Vista
{
    partial class Menu
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMontoCajaAhorro = new System.Windows.Forms.Label();
            this.lblMontoCtaCte = new System.Windows.Forms.Label();
            this.lblCajaAhorro = new System.Windows.Forms.Label();
            this.lblCtaCte = new System.Windows.Forms.Label();
            this.btnExtraccion = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "USUARIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMontoCajaAhorro);
            this.groupBox1.Controls.Add(this.lblMontoCtaCte);
            this.groupBox1.Controls.Add(this.lblCajaAhorro);
            this.groupBox1.Controls.Add(this.lblCtaCte);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TEST";
            // 
            // lblMontoCajaAhorro
            // 
            this.lblMontoCajaAhorro.AutoSize = true;
            this.lblMontoCajaAhorro.Location = new System.Drawing.Point(134, 61);
            this.lblMontoCajaAhorro.Name = "lblMontoCajaAhorro";
            this.lblMontoCajaAhorro.Size = new System.Drawing.Size(58, 13);
            this.lblMontoCajaAhorro.TabIndex = 4;
            this.lblMontoCajaAhorro.Text = "MontoCaja";
            // 
            // lblMontoCtaCte
            // 
            this.lblMontoCtaCte.AutoSize = true;
            this.lblMontoCtaCte.Location = new System.Drawing.Point(134, 32);
            this.lblMontoCtaCte.Name = "lblMontoCtaCte";
            this.lblMontoCtaCte.Size = new System.Drawing.Size(79, 13);
            this.lblMontoCtaCte.TabIndex = 3;
            this.lblMontoCtaCte.Text = "MontoCTACTE";
            // 
            // lblCajaAhorro
            // 
            this.lblCajaAhorro.AutoSize = true;
            this.lblCajaAhorro.Location = new System.Drawing.Point(70, 61);
            this.lblCajaAhorro.Name = "lblCajaAhorro";
            this.lblCajaAhorro.Size = new System.Drawing.Size(59, 13);
            this.lblCajaAhorro.TabIndex = 2;
            this.lblCajaAhorro.Text = "CajaAhorro";
            // 
            // lblCtaCte
            // 
            this.lblCtaCte.AutoSize = true;
            this.lblCtaCte.Location = new System.Drawing.Point(70, 32);
            this.lblCtaCte.Name = "lblCtaCte";
            this.lblCtaCte.Size = new System.Drawing.Size(49, 13);
            this.lblCtaCte.TabIndex = 1;
            this.lblCtaCte.Text = "CTACTE";
            // 
            // btnExtraccion
            // 
            this.btnExtraccion.Location = new System.Drawing.Point(12, 118);
            this.btnExtraccion.Name = "btnExtraccion";
            this.btnExtraccion.Size = new System.Drawing.Size(75, 23);
            this.btnExtraccion.TabIndex = 2;
            this.btnExtraccion.Text = "Extracción";
            this.btnExtraccion.UseVisualStyleBackColor = true;
            this.btnExtraccion.Click += new System.EventHandler(this.btnExtraccion_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(197, 118);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 5;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnExtraccion);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMontoCajaAhorro;
        private System.Windows.Forms.Label lblMontoCtaCte;
        private System.Windows.Forms.Label lblCajaAhorro;
        private System.Windows.Forms.Label lblCtaCte;
        private System.Windows.Forms.Button btnExtraccion;
        private System.Windows.Forms.Button btnDeposito;
    }
}