namespace Examen_taller_esbaide
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
            this.personales = new System.Windows.Forms.GroupBox();
            this.direccion = new System.Windows.Forms.Label();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.otro = new System.Windows.Forms.RadioButton();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.femenino = new System.Windows.Forms.RadioButton();
            this.fechaN = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.bancarios = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEjecucion = new System.Windows.Forms.DateTimePicker();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.consulta = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.fechaEje = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.richTextBoxDireccion = new System.Windows.Forms.RichTextBox();
            this.ejecutar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.edicion = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.personales.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.bancarios.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // personales
            // 
            this.personales.Controls.Add(this.richTextBoxDireccion);
            this.personales.Controls.Add(this.direccion);
            this.personales.Controls.Add(this.dateTimePickerNacimiento);
            this.personales.Controls.Add(this.textBoxApellido);
            this.personales.Controls.Add(this.textBoxNombre);
            this.personales.Controls.Add(this.groupBox3);
            this.personales.Controls.Add(this.fechaN);
            this.personales.Controls.Add(this.apellido);
            this.personales.Controls.Add(this.nombre);
            this.personales.Location = new System.Drawing.Point(25, 21);
            this.personales.Name = "personales";
            this.personales.Size = new System.Drawing.Size(728, 218);
            this.personales.TabIndex = 0;
            this.personales.TabStop = false;
            this.personales.Text = "Datos Personales";
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(447, 29);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(55, 13);
            this.direccion.TabIndex = 7;
            this.direccion.Text = "Dirección:";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(134, 94);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(253, 20);
            this.dateTimePickerNacimiento.TabIndex = 6;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(84, 56);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(292, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(84, 22);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(292, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.otro);
            this.groupBox3.Controls.Add(this.masculino);
            this.groupBox3.Controls.Add(this.femenino);
            this.groupBox3.Location = new System.Drawing.Point(26, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 47);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // otro
            // 
            this.otro.AutoSize = true;
            this.otro.Location = new System.Drawing.Point(276, 19);
            this.otro.Name = "otro";
            this.otro.Size = new System.Drawing.Size(45, 17);
            this.otro.TabIndex = 2;
            this.otro.TabStop = true;
            this.otro.Text = "Otro";
            this.otro.UseVisualStyleBackColor = true;
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(151, 19);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(73, 17);
            this.masculino.TabIndex = 1;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.Location = new System.Drawing.Point(17, 19);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(71, 17);
            this.femenino.TabIndex = 0;
            this.femenino.TabStop = true;
            this.femenino.Text = "Femenino";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // fechaN
            // 
            this.fechaN.AutoSize = true;
            this.fechaN.Location = new System.Drawing.Point(22, 94);
            this.fechaN.Name = "fechaN";
            this.fechaN.Size = new System.Drawing.Size(105, 13);
            this.fechaN.TabIndex = 2;
            this.fechaN.Text = "Fecha deNacimiento";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(23, 63);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(44, 13);
            this.apellido.TabIndex = 1;
            this.apellido.Text = "Apellido";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(23, 29);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // bancarios
            // 
            this.bancarios.Controls.Add(this.limpiar);
            this.bancarios.Controls.Add(this.ejecutar);
            this.bancarios.Controls.Add(this.dateTimePickerEjecucion);
            this.bancarios.Controls.Add(this.textBoxSaldo);
            this.bancarios.Controls.Add(this.textBoxCantidad);
            this.bancarios.Controls.Add(this.groupBox4);
            this.bancarios.Controls.Add(this.fechaEje);
            this.bancarios.Controls.Add(this.saldo);
            this.bancarios.Controls.Add(this.cantidad);
            this.bancarios.Location = new System.Drawing.Point(25, 294);
            this.bancarios.Name = "bancarios";
            this.bancarios.Size = new System.Drawing.Size(728, 218);
            this.bancarios.TabIndex = 1;
            this.bancarios.TabStop = false;
            this.bancarios.Text = "Datos Bancarios";
            // 
            // dateTimePickerEjecucion
            // 
            this.dateTimePickerEjecucion.Location = new System.Drawing.Point(134, 100);
            this.dateTimePickerEjecucion.Name = "dateTimePickerEjecucion";
            this.dateTimePickerEjecucion.Size = new System.Drawing.Size(253, 20);
            this.dateTimePickerEjecucion.TabIndex = 8;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(84, 55);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(292, 20);
            this.textBoxSaldo.TabIndex = 7;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(84, 23);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(292, 20);
            this.textBoxCantidad.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.consulta);
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Location = new System.Drawing.Point(25, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 51);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operación:";
            // 
            // consulta
            // 
            this.consulta.AutoSize = true;
            this.consulta.Location = new System.Drawing.Point(255, 19);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(66, 17);
            this.consulta.TabIndex = 3;
            this.consulta.TabStop = true;
            this.consulta.Text = "Consulta";
            this.consulta.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(139, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(53, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Retiro";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Deposito";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // fechaEje
            // 
            this.fechaEje.AutoSize = true;
            this.fechaEje.Location = new System.Drawing.Point(22, 100);
            this.fechaEje.Name = "fechaEje";
            this.fechaEje.Size = new System.Drawing.Size(105, 13);
            this.fechaEje.TabIndex = 4;
            this.fechaEje.Text = "Fecha de Ejecución:";
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(23, 58);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(34, 13);
            this.saldo.TabIndex = 3;
            this.saldo.Text = "Saldo";
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Location = new System.Drawing.Point(23, 30);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(49, 13);
            this.cantidad.TabIndex = 2;
            this.cantidad.Text = "Cantidad";
            // 
            // richTextBoxDireccion
            // 
            this.richTextBoxDireccion.Location = new System.Drawing.Point(508, 29);
            this.richTextBoxDireccion.Name = "richTextBoxDireccion";
            this.richTextBoxDireccion.Size = new System.Drawing.Size(155, 117);
            this.richTextBoxDireccion.TabIndex = 8;
            this.richTextBoxDireccion.Text = "";
            // 
            // ejecutar
            // 
            this.ejecutar.Location = new System.Drawing.Point(474, 19);
            this.ejecutar.Name = "ejecutar";
            this.ejecutar.Size = new System.Drawing.Size(75, 23);
            this.ejecutar.TabIndex = 9;
            this.ejecutar.Text = "Ejecutar";
            this.ejecutar.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(474, 69);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 10;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // edicion
            // 
            this.edicion.Location = new System.Drawing.Point(782, 40);
            this.edicion.Name = "edicion";
            this.edicion.Size = new System.Drawing.Size(75, 23);
            this.edicion.TabIndex = 10;
            this.edicion.Text = "Edición";
            this.edicion.UseVisualStyleBackColor = true;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(782, 93);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 535);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.edicion);
            this.Controls.Add(this.bancarios);
            this.Controls.Add(this.personales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.personales.ResumeLayout(false);
            this.personales.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.bancarios.ResumeLayout(false);
            this.bancarios.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personales;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.GroupBox bancarios;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton otro;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.RadioButton femenino;
        private System.Windows.Forms.Label fechaN;
        private System.Windows.Forms.DateTimePicker dateTimePickerEjecucion;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton consulta;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label fechaEje;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.RichTextBox richTextBoxDireccion;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button ejecutar;
        private System.Windows.Forms.Button edicion;
        private System.Windows.Forms.Button cancelar;
    }
}

