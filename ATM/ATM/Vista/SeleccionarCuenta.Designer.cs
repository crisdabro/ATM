namespace ATM.Vista
{
    partial class SeleccionarCuenta
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
            this.groupPropias = new System.Windows.Forms.GroupBox();
            this.btnCtaCte = new System.Windows.Forms.Button();
            this.btnCajaAhorro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPropias.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPropias
            // 
            this.groupPropias.Controls.Add(this.btnCtaCte);
            this.groupPropias.Controls.Add(this.btnCajaAhorro);
            this.groupPropias.Controls.Add(this.label1);
            this.groupPropias.Location = new System.Drawing.Point(12, 21);
            this.groupPropias.Name = "groupPropias";
            this.groupPropias.Size = new System.Drawing.Size(260, 183);
            this.groupPropias.TabIndex = 2;
            this.groupPropias.TabStop = false;
            // 
            // btnCtaCte
            // 
            this.btnCtaCte.Location = new System.Drawing.Point(179, 83);
            this.btnCtaCte.Name = "btnCtaCte";
            this.btnCtaCte.Size = new System.Drawing.Size(75, 40);
            this.btnCtaCte.TabIndex = 5;
            this.btnCtaCte.Text = "Cuenta Corriente";
            this.btnCtaCte.UseVisualStyleBackColor = true;
            this.btnCtaCte.Click += new System.EventHandler(this.btnCtaCte_Click);
            // 
            // btnCajaAhorro
            // 
            this.btnCajaAhorro.Location = new System.Drawing.Point(20, 83);
            this.btnCajaAhorro.Name = "btnCajaAhorro";
            this.btnCajaAhorro.Size = new System.Drawing.Size(75, 40);
            this.btnCajaAhorro.TabIndex = 4;
            this.btnCajaAhorro.Text = "Caja Ahorro";
            this.btnCajaAhorro.UseVisualStyleBackColor = true;
            this.btnCajaAhorro.Click += new System.EventHandler(this.btnCajaAhorro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONAR CUENTA ";
            // 
            // SeleccionarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupPropias);
            this.Name = "SeleccionarCuenta";
            this.Text = "SeleccionarCuenta";
            this.groupPropias.ResumeLayout(false);
            this.groupPropias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPropias;
        private System.Windows.Forms.Button btnCtaCte;
        private System.Windows.Forms.Button btnCajaAhorro;
        private System.Windows.Forms.Label label1;
    }
}