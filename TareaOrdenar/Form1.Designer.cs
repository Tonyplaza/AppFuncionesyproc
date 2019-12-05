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
            this.listBoxVector = new System.Windows.Forms.ListBox();
            this.btnNumero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstVexctorOrdenado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxVector
            // 
            this.listBoxVector.FormattingEnabled = true;
            this.listBoxVector.Location = new System.Drawing.Point(46, 87);
            this.listBoxVector.Name = "listBoxVector";
            this.listBoxVector.Size = new System.Drawing.Size(126, 173);
            this.listBoxVector.TabIndex = 2;
            // 
            // btnNumero
            // 
            this.btnNumero.Location = new System.Drawing.Point(290, 29);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(108, 23);
            this.btnNumero.TabIndex = 3;
            this.btnNumero.Text = "Agregar Numeros";
            this.btnNumero.UseVisualStyleBackColor = true;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tamaño del vector:";
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(164, 29);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 20);
            this.txtTamanio.TabIndex = 6;
            this.txtTamanio.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vector Original:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vector Ordenado:";
            // 
            // lstVexctorOrdenado
            // 
            this.lstVexctorOrdenado.FormattingEnabled = true;
            this.lstVexctorOrdenado.Location = new System.Drawing.Point(218, 87);
            this.lstVexctorOrdenado.Name = "lstVexctorOrdenado";
            this.lstVexctorOrdenado.Size = new System.Drawing.Size(126, 173);
            this.lstVexctorOrdenado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstVexctorOrdenado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.listBoxVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxVector;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstVexctorOrdenado;
    }
}

