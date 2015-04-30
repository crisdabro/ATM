namespace ATM.Vista
{
    partial class ImprimirOperacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMontoCajaAhorro = new System.Windows.Forms.Label();
            this.lblMontoCtaCte = new System.Windows.Forms.Label();
            this.lblSaldoCajaAhorro = new System.Windows.Forms.Label();
            this.lblSaldoCtaCte = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMontoCajaAhorro);
            this.groupBox1.Controls.Add(this.lblMontoCtaCte);
            this.groupBox1.Controls.Add(this.lblSaldoCajaAhorro);
            this.groupBox1.Controls.Add(this.lblSaldoCtaCte);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TEST";
            // 
            // lblMontoCajaAhorro
            // 
            this.lblMontoCajaAhorro.AutoSize = true;
            this.lblMontoCajaAhorro.Location = new System.Drawing.Point(135, 92);
            this.lblMontoCajaAhorro.Name = "lblMontoCajaAhorro";
            this.lblMontoCajaAhorro.Size = new System.Drawing.Size(58, 13);
            this.lblMontoCajaAhorro.TabIndex = 4;
            this.lblMontoCajaAhorro.Text = "MontoCaja";
            // 
            // lblMontoCtaCte
            // 
            this.lblMontoCtaCte.AutoSize = true;
            this.lblMontoCtaCte.Location = new System.Drawing.Point(135, 63);
            this.lblMontoCtaCte.Name = "lblMontoCtaCte";
            this.lblMontoCtaCte.Size = new System.Drawing.Size(79, 13);
            this.lblMontoCtaCte.TabIndex = 3;
            this.lblMontoCtaCte.Text = "MontoCTACTE";
            // 
            // lblSaldoCajaAhorro
            // 
            this.lblSaldoCajaAhorro.AutoSize = true;
            this.lblSaldoCajaAhorro.Location = new System.Drawing.Point(28, 92);
            this.lblSaldoCajaAhorro.Name = "lblSaldoCajaAhorro";
            this.lblSaldoCajaAhorro.Size = new System.Drawing.Size(95, 13);
            this.lblSaldoCajaAhorro.TabIndex = 2;
            this.lblSaldoCajaAhorro.Text = "Saldo Caja Ahorro:";
            // 
            // lblSaldoCtaCte
            // 
            this.lblSaldoCtaCte.AutoSize = true;
            this.lblSaldoCtaCte.Location = new System.Drawing.Point(41, 63);
            this.lblSaldoCtaCte.Name = "lblSaldoCtaCte";
            this.lblSaldoCtaCte.Size = new System.Drawing.Size(82, 13);
            this.lblSaldoCtaCte.TabIndex = 1;
            this.lblSaldoCtaCte.Text = "Saldo CTACTE:";
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
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(92, 206);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(98, 23);
            this.btnVolverMenu.TabIndex = 3;
            this.btnVolverMenu.Text = "Volver al Menu";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // ImprimirOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImprimirOperacion";
            this.Text = "ImprimirOperacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMontoCajaAhorro;
        private System.Windows.Forms.Label lblMontoCtaCte;
        private System.Windows.Forms.Label lblSaldoCajaAhorro;
        private System.Windows.Forms.Label lblSaldoCtaCte;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}