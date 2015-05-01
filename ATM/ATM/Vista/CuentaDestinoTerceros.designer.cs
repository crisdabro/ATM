namespace ATM.Vista
{
    partial class CuentaDestinoTerceros
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
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRealizarDepositoTerceros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroDeCuenta = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(26, 25);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtSucursal.TabIndex = 0;
            // 
            // txtCBU
            // 
            this.txtCBU.Location = new System.Drawing.Point(28, 75);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(100, 20);
            this.txtCBU.TabIndex = 1;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(25, 9);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(65, 13);
            this.lblSucursal.TabIndex = 2;
            this.lblSucursal.Text = "SUCURSAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CBU";
            // 
            // btnRealizarDepositoTerceros
            // 
            this.btnRealizarDepositoTerceros.Location = new System.Drawing.Point(219, 214);
            this.btnRealizarDepositoTerceros.Name = "btnRealizarDepositoTerceros";
            this.btnRealizarDepositoTerceros.Size = new System.Drawing.Size(158, 23);
            this.btnRealizarDepositoTerceros.TabIndex = 4;
            this.btnRealizarDepositoTerceros.Text = "Realizar Deposito";
            this.btnRealizarDepositoTerceros.UseVisualStyleBackColor = true;
            this.btnRealizarDepositoTerceros.Click += new System.EventHandler(this.btnRealizarDepositoTerceros_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NUMERO CUENTA";
            // 
            // txtNumeroDeCuenta
            // 
            this.txtNumeroDeCuenta.Location = new System.Drawing.Point(277, 25);
            this.txtNumeroDeCuenta.Name = "txtNumeroDeCuenta";
            this.txtNumeroDeCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDeCuenta.TabIndex = 5;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(277, 75);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "IMPORTE";
            // 
            // CuentaDestinoTerceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroDeCuenta);
            this.Controls.Add(this.btnRealizarDepositoTerceros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.txtCBU);
            this.Controls.Add(this.txtSucursal);
            this.Name = "CuentaDestinoTerceros";
            this.Text = "CuentaDestinoOtroBanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtCBU;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRealizarDepositoTerceros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroDeCuenta;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label4;
    }
}