namespace TareaOrdenar
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstNum = new System.Windows.Forms.ListBox();
            this.btnNumero = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numeros:";
            // 
            // lstNum
            // 
            this.lstNum.FormattingEnabled = true;
            this.lstNum.Location = new System.Drawing.Point(46, 87);
            this.lstNum.Name = "lstNum";
            this.lstNum.Size = new System.Drawing.Size(120, 95);
            this.lstNum.TabIndex = 2;
            // 
            // btnNumero
            // 
            this.btnNumero.Location = new System.Drawing.Point(247, 46);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(108, 23);
            this.btnNumero.TabIndex = 3;
            this.btnNumero.Text = "Agregar Numeros";
            this.btnNumero.UseVisualStyleBackColor = true;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(247, 76);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 227);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.lstNum);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNum;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

