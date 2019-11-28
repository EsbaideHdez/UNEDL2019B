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
            this.entrada = new System.Windows.Forms.TextBox();
            this.read_button1 = new System.Windows.Forms.Button();
            this.look_button2 = new System.Windows.Forms.Button();
            this.Contenido = new System.Windows.Forms.ListBox();
            this.ver_lista = new System.Windows.Forms.Button();
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
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(121, 31);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(163, 20);
            this.entrada.TabIndex = 1;
            // 
            // read_button1
            // 
            this.read_button1.Location = new System.Drawing.Point(315, 31);
            this.read_button1.Name = "read_button1";
            this.read_button1.Size = new System.Drawing.Size(75, 23);
            this.read_button1.TabIndex = 2;
            this.read_button1.Text = "Agregar";
            this.read_button1.UseVisualStyleBackColor = true;
            this.read_button1.Click += new System.EventHandler(this.read_button1_Click);
            // 
            // look_button2
            // 
            this.look_button2.Location = new System.Drawing.Point(315, 74);
            this.look_button2.Name = "look_button2";
            this.look_button2.Size = new System.Drawing.Size(75, 23);
            this.look_button2.TabIndex = 3;
            this.look_button2.Text = "Ver";
            this.look_button2.UseVisualStyleBackColor = true;
            this.look_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Contenido
            // 
            this.Contenido.FormattingEnabled = true;
            this.Contenido.Location = new System.Drawing.Point(61, 74);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(231, 95);
            this.Contenido.TabIndex = 5;
            // 
            // ver_lista
            // 
            this.ver_lista.Location = new System.Drawing.Point(315, 125);
            this.ver_lista.Name = "ver_lista";
            this.ver_lista.Size = new System.Drawing.Size(75, 23);
            this.ver_lista.TabIndex = 6;
            this.ver_lista.Text = "Ver lista";
            this.ver_lista.UseVisualStyleBackColor = true;
            this.ver_lista.Click += new System.EventHandler(this.ver_lista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 192);
            this.Controls.Add(this.ver_lista);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.look_button2);
            this.Controls.Add(this.read_button1);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entrada;
        private System.Windows.Forms.Button read_button1;
        private System.Windows.Forms.Button look_button2;
        private System.Windows.Forms.ListBox Contenido;
        private System.Windows.Forms.Button ver_lista;
    }
}

