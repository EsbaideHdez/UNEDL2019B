namespace Examen_TPV2doParcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.read_button1 = new System.Windows.Forms.Button();
            this.write_button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(121, 31);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(163, 20);
            this.filename.TabIndex = 1;
            // 
            // read_button1
            // 
            this.read_button1.Location = new System.Drawing.Point(315, 31);
            this.read_button1.Name = "read_button1";
            this.read_button1.Size = new System.Drawing.Size(75, 23);
            this.read_button1.TabIndex = 2;
            this.read_button1.Text = "Leer";
            this.read_button1.UseVisualStyleBackColor = true;
            // 
            // write_button2
            // 
            this.write_button2.Location = new System.Drawing.Point(415, 31);
            this.write_button2.Name = "write_button2";
            this.write_button2.Size = new System.Drawing.Size(75, 23);
            this.write_button2.TabIndex = 3;
            this.write_button2.Text = "Escribir";
            this.write_button2.UseVisualStyleBackColor = true;
            this.write_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contenido";
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(61, 86);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(303, 20);
            this.content.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 145);
            this.Controls.Add(this.content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.write_button2);
            this.Controls.Add(this.read_button1);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button read_button1;
        private System.Windows.Forms.Button write_button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox content;
    }
}

