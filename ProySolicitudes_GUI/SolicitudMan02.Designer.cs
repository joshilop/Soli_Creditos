﻿
namespace ProySolicitudes_GUI
{
    partial class SolicitudMan02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAnalista = new System.Windows.Forms.ComboBox();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCuenta = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecRechazo = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.chkDesembolso = new System.Windows.Forms.CheckBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.dtpFecAprobacion = new System.Windows.Forms.DateTimePicker();
            this.mskMonto = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboAnalista);
            this.groupBox1.Controls.Add(this.cboCuotas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskCuenta);
            this.groupBox1.Controls.Add(this.dtpFecRechazo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.chkDesembolso);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Controls.Add(this.dtpFecAprobacion);
            this.groupBox1.Controls.Add(this.mskMonto);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGrabar);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 578);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cboAnalista
            // 
            this.cboAnalista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnalista.FormattingEnabled = true;
            this.cboAnalista.Location = new System.Drawing.Point(180, 115);
            this.cboAnalista.Name = "cboAnalista";
            this.cboAnalista.Size = new System.Drawing.Size(290, 24);
            this.cboAnalista.TabIndex = 1;
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Items.AddRange(new object[] {
            "6",
            "12",
            "18",
            "24",
            "60"});
            this.cboCuotas.Location = new System.Drawing.Point(180, 373);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(77, 24);
            this.cboCuotas.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cuotas:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Items.AddRange(new object[] {
            "Probando 1",
            "Probando 2"});
            this.cboCliente.Location = new System.Drawing.Point(180, 61);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(306, 24);
            this.cboCliente.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cliente:";
            // 
            // mskCuenta
            // 
            this.mskCuenta.Location = new System.Drawing.Point(180, 444);
            this.mskCuenta.Mask = "99999999999999";
            this.mskCuenta.Name = "mskCuenta";
            this.mskCuenta.Size = new System.Drawing.Size(125, 22);
            this.mskCuenta.TabIndex = 9;
            this.mskCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFecRechazo
            // 
            this.dtpFecRechazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecRechazo.Location = new System.Drawing.Point(609, 265);
            this.dtpFecRechazo.Name = "dtpFecRechazo";
            this.dtpFecRechazo.Size = new System.Drawing.Size(109, 22);
            this.dtpFecRechazo.TabIndex = 6;
            this.dtpFecRechazo.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Analista:";
            // 
            // chkDesembolso
            // 
            this.chkDesembolso.AutoSize = true;
            this.chkDesembolso.Location = new System.Drawing.Point(472, 447);
            this.chkDesembolso.Name = "chkDesembolso";
            this.chkDesembolso.Size = new System.Drawing.Size(42, 21);
            this.chkDesembolso.TabIndex = 10;
            this.chkDesembolso.Text = "Si";
            this.chkDesembolso.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Rechazada",
            "En proceso",
            "Aprobada"});
            this.cboEstado.Location = new System.Drawing.Point(180, 235);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(204, 24);
            this.cboEstado.TabIndex = 4;
            this.cboEstado.SelectionChangeCommitted += new System.EventHandler(this.cboEstado_SelectionChangeCommitted);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(180, 311);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(254, 22);
            this.txtMotivo.TabIndex = 7;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Prestamo Facil",
            "Credito Hipotecario",
            "Credito Vehicular",
            "Tarjeta de Credito"});
            this.cboProducto.Location = new System.Drawing.Point(180, 176);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(211, 24);
            this.cboProducto.TabIndex = 2;
            // 
            // dtpFecAprobacion
            // 
            this.dtpFecAprobacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFecAprobacion.CustomFormat = "";
            this.dtpFecAprobacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecAprobacion.Location = new System.Drawing.Point(607, 220);
            this.dtpFecAprobacion.Name = "dtpFecAprobacion";
            this.dtpFecAprobacion.Size = new System.Drawing.Size(111, 22);
            this.dtpFecAprobacion.TabIndex = 5;
            this.dtpFecAprobacion.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // mskMonto
            // 
            this.mskMonto.Location = new System.Drawing.Point(609, 176);
            this.mskMonto.Mask = "99999.99";
            this.mskMonto.Name = "mskMonto";
            this.mskMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskMonto.Size = new System.Drawing.Size(81, 22);
            this.mskMonto.TabIndex = 3;
            this.mskMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(697, 541);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Location = new System.Drawing.Point(593, 541);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(85, 31);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Desembolsado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Fecha Rechazo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Motivo de rechazo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Aprobación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto Solicitado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "N. Cuenta:";
            // 
            // SolicitudMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 603);
            this.Controls.Add(this.groupBox1);
            this.Name = "SolicitudMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Solicitud";
            this.Load += new System.EventHandler(this.SolicitudMan02_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDesembolso;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.DateTimePicker dtpFecAprobacion;
        private System.Windows.Forms.MaskedTextBox mskMonto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFecRechazo;
        private System.Windows.Forms.MaskedTextBox mskCuenta;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAnalista;
    }
}