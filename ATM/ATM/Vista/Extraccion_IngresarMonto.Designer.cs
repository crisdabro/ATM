namespace ATM.Vista
{
    partial class ExtraccionIngresarMonto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMonto100 = new System.Windows.Forms.Button();
            this.btnMonto200 = new System.Windows.Forms.Button();
            this.btnMonto500 = new System.Windows.Forms.Button();
            this.btnMonto1000 = new System.Windows.Forms.Button();
            this.btnMonto2000 = new System.Windows.Forms.Button();
            this.btnMonto3000 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONAR MONTO A RETIRAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGREASR MONTO A RETIRAR";
            // 
            // btnMonto100
            // 
            this.btnMonto100.Location = new System.Drawing.Point(12, 51);
            this.btnMonto100.Name = "btnMonto100";
            this.btnMonto100.Size = new System.Drawing.Size(75, 23);
            this.btnMonto100.TabIndex = 2;
            this.btnMonto100.Text = "100";
            this.btnMonto100.UseVisualStyleBackColor = true;
           
            // 
            // btnMonto200
            // 
            this.btnMonto200.Location = new System.Drawing.Point(13, 93);
            this.btnMonto200.Name = "btnMonto200";
            this.btnMonto200.Size = new System.Drawing.Size(75, 23);
            this.btnMonto200.TabIndex = 3;
            this.btnMonto200.Text = "200";
            this.btnMonto200.UseVisualStyleBackColor = true;
            // 
            // btnMonto500
            // 
            this.btnMonto500.Location = new System.Drawing.Point(13, 130);
            this.btnMonto500.Name = "btnMonto500";
            this.btnMonto500.Size = new System.Drawing.Size(75, 23);
            this.btnMonto500.TabIndex = 4;
            this.btnMonto500.Text = "500";
            this.btnMonto500.UseVisualStyleBackColor = true;
            // 
            // btnMonto1000
            // 
            this.btnMonto1000.Location = new System.Drawing.Point(197, 51);
            this.btnMonto1000.Name = "btnMonto1000";
            this.btnMonto1000.Size = new System.Drawing.Size(75, 23);
            this.btnMonto1000.TabIndex = 5;
            this.btnMonto1000.Text = "1000";
            this.btnMonto1000.UseVisualStyleBackColor = true;
            // 
            // btnMonto2000
            // 
            this.btnMonto2000.Location = new System.Drawing.Point(197, 91);
            this.btnMonto2000.Name = "btnMonto2000";
            this.btnMonto2000.Size = new System.Drawing.Size(75, 23);
            this.btnMonto2000.TabIndex = 6;
            this.btnMonto2000.Text = "2000";
            this.btnMonto2000.UseVisualStyleBackColor = true;
            // 
            // btnMonto3000
            // 
            this.btnMonto3000.Location = new System.Drawing.Point(197, 130);
            this.btnMonto3000.Name = "btnMonto3000";
            this.btnMonto3000.Size = new System.Drawing.Size(75, 23);
            this.btnMonto3000.TabIndex = 7;
            this.btnMonto3000.Text = "3000";
            this.btnMonto3000.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(33, 227);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(205, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // ExtraccionIngresarMonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMonto3000);
            this.Controls.Add(this.btnMonto2000);
            this.Controls.Add(this.btnMonto1000);
            this.Controls.Add(this.btnMonto500);
            this.Controls.Add(this.btnMonto200);
            this.Controls.Add(this.btnMonto100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExtraccionIngresarMonto";
            this.Text = "Extraccion_IngresarMonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMonto100;
        private System.Windows.Forms.Button btnMonto200;
        private System.Windows.Forms.Button btnMonto500;
        private System.Windows.Forms.Button btnMonto1000;
        private System.Windows.Forms.Button btnMonto2000;
        private System.Windows.Forms.Button btnMonto3000;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConfirmar;
    }
}