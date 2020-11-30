namespace Astrologia
{
    partial class Form1
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
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnCalcularIdade = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(43, 66);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpNascimento.TabIndex = 1;
            // 
            // btnCalcularIdade
            // 
            this.btnCalcularIdade.Location = new System.Drawing.Point(43, 120);
            this.btnCalcularIdade.Name = "btnCalcularIdade";
            this.btnCalcularIdade.Size = new System.Drawing.Size(200, 23);
            this.btnCalcularIdade.TabIndex = 2;
            this.btnCalcularIdade.Text = "Calcular";
            this.btnCalcularIdade.UseVisualStyleBackColor = true;
            this.btnCalcularIdade.Click += new System.EventHandler(this.btnCalcularIdade_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdade.Location = new System.Drawing.Point(43, 179);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 15);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnCalcularIdade);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mistério";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button btnCalcularIdade;
        private System.Windows.Forms.Label lblIdade;
    }
}

