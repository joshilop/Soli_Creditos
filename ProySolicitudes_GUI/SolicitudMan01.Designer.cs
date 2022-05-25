
namespace ProySolicitudes_GUI
{
    partial class SolicitudMan01
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgSolicitud = new System.Windows.Forms.DataGridView();
            this.Id_solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomApeCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomApeAnalis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_analista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_solicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_aprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_rechazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo_rechazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est_desembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_desembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnalistaFiltro = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(860, 492);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 28);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(908, 437);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(76, 34);
            this.lblRegistros.TabIndex = 14;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(845, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registros:";
            // 
            // dtgSolicitud
            // 
            this.dtgSolicitud.AllowUserToAddRows = false;
            this.dtgSolicitud.AllowUserToDeleteRows = false;
            this.dtgSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSolicitud.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSolicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_solicitud,
            this.NomApeCli,
            this.Id_cliente,
            this.NomApeAnalis,
            this.Id_analista,
            this.Produto,
            this.Monto_solicitado,
            this.Cuotas,
            this.Estado,
            this.Fec_aprobacion,
            this.Fec_rechazo,
            this.Motivo_rechazo,
            this.Est_desembolso,
            this.Fec_desembolso,
            this.Fec_pago});
            this.dtgSolicitud.Location = new System.Drawing.Point(16, 46);
            this.dtgSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.dtgSolicitud.Name = "dtgSolicitud";
            this.dtgSolicitud.ReadOnly = true;
            this.dtgSolicitud.RowHeadersVisible = false;
            this.dtgSolicitud.RowHeadersWidth = 51;
            this.dtgSolicitud.RowTemplate.Height = 24;
            this.dtgSolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSolicitud.Size = new System.Drawing.Size(968, 370);
            this.dtgSolicitud.TabIndex = 10;
            // 
            // Id_solicitud
            // 
            this.Id_solicitud.DataPropertyName = "Id_solicitud";
            this.Id_solicitud.HeaderText = "Id solicitud";
            this.Id_solicitud.MinimumWidth = 6;
            this.Id_solicitud.Name = "Id_solicitud";
            this.Id_solicitud.ReadOnly = true;
            // 
            // NomApeCli
            // 
            this.NomApeCli.DataPropertyName = "Nombre cliente";
            this.NomApeCli.HeaderText = "Nombre y apellido Cliente";
            this.NomApeCli.MinimumWidth = 6;
            this.NomApeCli.Name = "NomApeCli";
            this.NomApeCli.ReadOnly = true;
            // 
            // Id_cliente
            // 
            this.Id_cliente.DataPropertyName = "Id_cli";
            this.Id_cliente.HeaderText = "Id cliente";
            this.Id_cliente.MinimumWidth = 6;
            this.Id_cliente.Name = "Id_cliente";
            this.Id_cliente.ReadOnly = true;
            // 
            // NomApeAnalis
            // 
            this.NomApeAnalis.DataPropertyName = "Nombre analista";
            this.NomApeAnalis.HeaderText = "Nombre y apellido Analista";
            this.NomApeAnalis.MinimumWidth = 6;
            this.NomApeAnalis.Name = "NomApeAnalis";
            this.NomApeAnalis.ReadOnly = true;
            // 
            // Id_analista
            // 
            this.Id_analista.DataPropertyName = "id_analista";
            this.Id_analista.HeaderText = "Id Analista";
            this.Id_analista.MinimumWidth = 6;
            this.Id_analista.Name = "Id_analista";
            this.Id_analista.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "PRODUCTO";
            this.Produto.HeaderText = "Producto";
            this.Produto.MinimumWidth = 6;
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Monto_solicitado
            // 
            this.Monto_solicitado.DataPropertyName = "Monto_solici";
            this.Monto_solicitado.HeaderText = "Monto solicitado";
            this.Monto_solicitado.MinimumWidth = 6;
            this.Monto_solicitado.Name = "Monto_solicitado";
            this.Monto_solicitado.ReadOnly = true;
            // 
            // Cuotas
            // 
            this.Cuotas.DataPropertyName = "Cuotas";
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.MinimumWidth = 6;
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Fec_aprobacion
            // 
            this.Fec_aprobacion.DataPropertyName = "Fec_aprobacion";
            this.Fec_aprobacion.HeaderText = "Fecha aprobación";
            this.Fec_aprobacion.MinimumWidth = 6;
            this.Fec_aprobacion.Name = "Fec_aprobacion";
            this.Fec_aprobacion.ReadOnly = true;
            // 
            // Fec_rechazo
            // 
            this.Fec_rechazo.DataPropertyName = "Fec_rechazo";
            this.Fec_rechazo.HeaderText = "Fecha rechazo";
            this.Fec_rechazo.MinimumWidth = 6;
            this.Fec_rechazo.Name = "Fec_rechazo";
            this.Fec_rechazo.ReadOnly = true;
            // 
            // Motivo_rechazo
            // 
            this.Motivo_rechazo.DataPropertyName = "Motivo_rechazo";
            this.Motivo_rechazo.HeaderText = "Motivo rechazo";
            this.Motivo_rechazo.MinimumWidth = 6;
            this.Motivo_rechazo.Name = "Motivo_rechazo";
            this.Motivo_rechazo.ReadOnly = true;
            // 
            // Est_desembolso
            // 
            this.Est_desembolso.DataPropertyName = "Estado desembolso";
            this.Est_desembolso.HeaderText = "Desembolso";
            this.Est_desembolso.MinimumWidth = 6;
            this.Est_desembolso.Name = "Est_desembolso";
            this.Est_desembolso.ReadOnly = true;
            // 
            // Fec_desembolso
            // 
            this.Fec_desembolso.DataPropertyName = "Fec_desembolso";
            this.Fec_desembolso.HeaderText = "Fecha desembolso";
            this.Fec_desembolso.MinimumWidth = 6;
            this.Fec_desembolso.Name = "Fec_desembolso";
            this.Fec_desembolso.ReadOnly = true;
            // 
            // Fec_pago
            // 
            this.Fec_pago.DataPropertyName = "Fec_pago";
            this.Fec_pago.HeaderText = "Fecha de pago";
            this.Fec_pago.MinimumWidth = 6;
            this.Fec_pago.Name = "Fec_pago";
            this.Fec_pago.ReadOnly = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(820, 15);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(164, 20);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filtrar por:";
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Cliente",
            "Analista"});
            this.cboFiltro.Location = new System.Drawing.Point(88, 14);
            this.cboFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(143, 21);
            this.cboFiltro.TabIndex = 0;
            this.cboFiltro.SelectionChangeCommitted += new System.EventHandler(this.cboFiltro_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre Analista:";
            // 
            // txtAnalistaFiltro
            // 
            this.txtAnalistaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnalistaFiltro.Location = new System.Drawing.Point(572, 15);
            this.txtAnalistaFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnalistaFiltro.Name = "txtAnalistaFiltro";
            this.txtAnalistaFiltro.Size = new System.Drawing.Size(138, 20);
            this.txtAnalistaFiltro.TabIndex = 1;
            this.txtAnalistaFiltro.TextChanged += new System.EventHandler(this.txtAnalistaFiltro_TextChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(117, 438);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 28);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(20, 437);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(77, 28);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(222, 438);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 30);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // SolicitudMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 544);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtAnalistaFiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgSolicitud);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SolicitudMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Solicitud";
            this.Load += new System.EventHandler(this.SolicitudMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgSolicitud;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnalistaFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomApeCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomApeAnalis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_analista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_solicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_aprobacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_rechazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo_rechazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Est_desembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_desembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_pago;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
    }
}