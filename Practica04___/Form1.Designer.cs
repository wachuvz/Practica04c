namespace Practica04___
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblestatura = new System.Windows.Forms.Label();
            this.txnombre = new System.Windows.Forms.TextBox();
            this.txapellido = new System.Windows.Forms.TextBox();
            this.txtelefono = new System.Windows.Forms.TextBox();
            this.txedad = new System.Windows.Forms.TextBox();
            this.txestatura = new System.Windows.Forms.TextBox();
            this.gbgenero = new System.Windows.Forms.GroupBox();
            this.rbotro = new System.Windows.Forms.RadioButton();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.gbgenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(179, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(56, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(179, 41);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(57, 16);
            this.lblapellido.TabIndex = 1;
            this.lblapellido.Text = "Apellido";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(179, 84);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(61, 16);
            this.lbltelefono.TabIndex = 2;
            this.lbltelefono.Text = "Telefono";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(179, 120);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(40, 16);
            this.lbledad.TabIndex = 3;
            this.lbledad.Text = "Edad";
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Location = new System.Drawing.Point(179, 160);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(56, 16);
            this.lblestatura.TabIndex = 4;
            this.lblestatura.Text = "Estatura";
            // 
            // txnombre
            // 
            this.txnombre.Location = new System.Drawing.Point(265, 3);
            this.txnombre.Name = "txnombre";
            this.txnombre.Size = new System.Drawing.Size(202, 22);
            this.txnombre.TabIndex = 5;
            this.txnombre.TextChanged += new System.EventHandler(this.txnombre_TextChanged);
            // 
            // txapellido
            // 
            this.txapellido.Location = new System.Drawing.Point(265, 41);
            this.txapellido.Name = "txapellido";
            this.txapellido.Size = new System.Drawing.Size(202, 22);
            this.txapellido.TabIndex = 6;
            // 
            // txtelefono
            // 
            this.txtelefono.Location = new System.Drawing.Point(265, 81);
            this.txtelefono.Name = "txtelefono";
            this.txtelefono.Size = new System.Drawing.Size(202, 22);
            this.txtelefono.TabIndex = 7;
            // 
            // txedad
            // 
            this.txedad.Location = new System.Drawing.Point(265, 120);
            this.txedad.Name = "txedad";
            this.txedad.Size = new System.Drawing.Size(202, 22);
            this.txedad.TabIndex = 8;
            // 
            // txestatura
            // 
            this.txestatura.Location = new System.Drawing.Point(265, 160);
            this.txestatura.Name = "txestatura";
            this.txestatura.Size = new System.Drawing.Size(202, 22);
            this.txestatura.TabIndex = 9;
            // 
            // gbgenero
            // 
            this.gbgenero.Controls.Add(this.rbotro);
            this.gbgenero.Controls.Add(this.rbfemenino);
            this.gbgenero.Controls.Add(this.rbmasculino);
            this.gbgenero.Location = new System.Drawing.Point(69, 241);
            this.gbgenero.Name = "gbgenero";
            this.gbgenero.Size = new System.Drawing.Size(398, 100);
            this.gbgenero.TabIndex = 10;
            this.gbgenero.TabStop = false;
            this.gbgenero.Text = "Genero";
            // 
            // rbotro
            // 
            this.rbotro.AutoSize = true;
            this.rbotro.Location = new System.Drawing.Point(289, 40);
            this.rbotro.Name = "rbotro";
            this.rbotro.Size = new System.Drawing.Size(53, 20);
            this.rbotro.TabIndex = 2;
            this.rbotro.TabStop = true;
            this.rbotro.Text = "Otro";
            this.rbotro.UseVisualStyleBackColor = true;
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(148, 40);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(88, 20);
            this.rbfemenino.TabIndex = 1;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(6, 37);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(89, 20);
            this.rbmasculino.TabIndex = 0;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(149, 347);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(109, 91);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(336, 347);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(111, 91);
            this.btnguardar.TabIndex = 12;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.gbgenero);
            this.Controls.Add(this.txestatura);
            this.Controls.Add(this.txedad);
            this.Controls.Add(this.txtelefono);
            this.Controls.Add(this.txapellido);
            this.Controls.Add(this.txnombre);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbgenero.ResumeLayout(false);
            this.gbgenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.TextBox txnombre;
        private System.Windows.Forms.TextBox txapellido;
        private System.Windows.Forms.TextBox txtelefono;
        private System.Windows.Forms.TextBox txedad;
        private System.Windows.Forms.TextBox txestatura;
        private System.Windows.Forms.GroupBox gbgenero;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.RadioButton rbotro;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
    }
}

