namespace ATM.Vista
{
    partial class SeleccionarCuentaDestino
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
            this.btnOtroBanco = new System.Windows.Forms.Button();
            this.btnMismoBanco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPropias.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPropias
            // 
            this.groupPropias.Controls.Add(this.btnOtroBanco);
            this.groupPropias.Controls.Add(this.btnMismoBanco);
            this.groupPropias.Controls.Add(this.label1);
            this.groupPropias.Location = new System.Drawing.Point(12, 22);
            this.groupPropias.Name = "groupPropias";
            this.groupPropias.Size = new System.Drawing.Size(260, 183);
            this.groupPropias.TabIndex = 3;
            this.groupPropias.TabStop = false;
            // 
            // btnOtroBanco
            // 
            this.btnOtroBanco.Location = new System.Drawing.Point(168, 78);
            this.btnOtroBanco.Name = "btnOtroBanco";
            this.btnOtroBanco.Size = new System.Drawing.Size(75, 40);
            this.btnOtroBanco.TabIndex = 5;
            this.btnOtroBanco.Text = "Otro Banco";
            this.btnOtroBanco.UseVisualStyleBackColor = true;
            this.btnOtroBanco.Click += new System.EventHandler(this.btnOtroBanco_Click);
            // 
            // btnMismoBanco
            // 
            this.btnMismoBanco.Location = new System.Drawing.Point(17, 78);
            this.btnMismoBanco.Name = "btnMismoBanco";
            this.btnMismoBanco.Size = new System.Drawing.Size(75, 40);
            this.btnMismoBanco.TabIndex = 4;
            this.btnMismoBanco.Text = "Mismo Banco";
            this.btnMismoBanco.UseVisualStyleBackColor = true;
            this.btnMismoBanco.Click += new System.EventHandler(this.btnMismoBanco_Click);
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
            // SeleccionarCuentaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupPropias);
            this.Name = "SeleccionarCuentaDestino";
            this.Text = "SeleccionarCuentaDestino";
            this.groupPropias.ResumeLayout(false);
            this.groupPropias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPropias;
        private System.Windows.Forms.Button btnOtroBanco;
        private System.Windows.Forms.Button btnMismoBanco;
        private System.Windows.Forms.Label label1;
    }
}