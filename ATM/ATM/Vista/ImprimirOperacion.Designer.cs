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
            this.lblCajaAhorro = new System.Windows.Forms.Label();
            this.lblCtaCte = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMontoCajaAhorro);
            this.groupBox1.Controls.Add(this.lblMontoCtaCte);
            this.groupBox1.Controls.Add(this.lblCajaAhorro);
            this.groupBox1.Controls.Add(this.lblCtaCte);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 87);
            this.groupBox1.TabIndex = 2;
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "USUARIO";
            // 
            // ImprimirOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
        private System.Windows.Forms.Label lblCajaAhorro;
        private System.Windows.Forms.Label lblCtaCte;
        private System.Windows.Forms.Label lblUsuario;
    }
}