﻿namespace listaOrdenado
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
            this.btnAgregarOrdenado = new System.Windows.Forms.Button();
            this.btnReporteVolteado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.txtCodigoConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.grbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarOrdenado
            // 
            this.btnAgregarOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOrdenado.Location = new System.Drawing.Point(37, 317);
            this.btnAgregarOrdenado.Name = "btnAgregarOrdenado";
            this.btnAgregarOrdenado.Size = new System.Drawing.Size(136, 74);
            this.btnAgregarOrdenado.TabIndex = 54;
            this.btnAgregarOrdenado.Text = "Agregar\r\nOrdenado";
            this.btnAgregarOrdenado.UseVisualStyleBackColor = true;
            this.btnAgregarOrdenado.Click += new System.EventHandler(this.btnAgregarOrdenado_Click_1);
            // 
            // btnReporteVolteado
            // 
            this.btnReporteVolteado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVolteado.Location = new System.Drawing.Point(37, 561);
            this.btnReporteVolteado.Name = "btnReporteVolteado";
            this.btnReporteVolteado.Size = new System.Drawing.Size(136, 70);
            this.btnReporteVolteado.TabIndex = 53;
            this.btnReporteVolteado.Text = "Reporte\r\nvolteado\r\n";
            this.btnReporteVolteado.UseVisualStyleBackColor = true;
            this.btnReporteVolteado.Click += new System.EventHandler(this.btnReporteVolteado_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 52;
            this.label2.Text = "Posición:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(937, 603);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 45);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.txtCodigoConsulta);
            this.grbConsulta.Controls.Add(this.label1);
            this.grbConsulta.Controls.Add(this.btnEliminar);
            this.grbConsulta.Controls.Add(this.btnBuscar);
            this.grbConsulta.Location = new System.Drawing.Point(223, 426);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(386, 200);
            this.grbConsulta.TabIndex = 51;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Buscar/Eliminar";
            // 
            // txtCodigoConsulta
            // 
            this.txtCodigoConsulta.Location = new System.Drawing.Point(24, 83);
            this.txtCodigoConsulta.Name = "txtCodigoConsulta";
            this.txtCodigoConsulta.Size = new System.Drawing.Size(164, 38);
            this.txtCodigoConsulta.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(240, 140);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 45);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 45);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(786, 453);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(107, 38);
            this.txtPos.TabIndex = 50;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(654, 497);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(136, 45);
            this.btnInsertar.TabIndex = 49;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(586, 12);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(340, 392);
            this.txtReporte.TabIndex = 48;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(117, 271);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 32);
            this.lblContador.TabIndex = 47;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(37, 497);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(136, 45);
            this.btnReporte.TabIndex = 46;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(141, 214);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(192, 38);
            this.txtPrecio.TabIndex = 44;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(31, 220);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(104, 32);
            this.lblPrecio.TabIndex = 43;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(166, 158);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(192, 38);
            this.txtCantidad.TabIndex = 42;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(22, 164);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(138, 32);
            this.lblCantidad.TabIndex = 41;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 38);
            this.txtNombre.TabIndex = 40;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 32);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(142, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(192, 38);
            this.txtCodigo.TabIndex = 38;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(114, 32);
            this.lblCodigo.TabIndex = 36;
            this.lblCodigo.Text = "Código:";
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInicio.Location = new System.Drawing.Point(37, 407);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(136, 74);
            this.btnAgregarInicio.TabIndex = 55;
            this.btnAgregarInicio.Text = "Agregar\r\nen inicio";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 660);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.btnAgregarOrdenado);
            this.Controls.Add(this.btnReporteVolteado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarOrdenado;
        private System.Windows.Forms.Button btnReporteVolteado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.TextBox txtCodigoConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregarInicio;
    }
}

