
namespace ProySolicitudes_GUI
{
    partial class GarantiaMan01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgGarantia = new System.Windows.Forms.DataGridView();
            this.Id_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGarantia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(655, 435);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 28);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(687, 392);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(76, 31);
            this.lblRegistros.TabIndex = 14;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registros:";
            // 
            // dtgGarantia
            // 
            this.dtgGarantia.AllowUserToAddRows = false;
            this.dtgGarantia.AllowUserToDeleteRows = false;
            this.dtgGarantia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGarantia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGarantia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgGarantia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgGarantia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGarantia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_garantia,
            this.Nom_cli,
            this.Ape_cli,
            this.Id_cli,
            this.Tip_garantia,
            this.Des_garantia,
            this.Valor_garantia,
            this.Est_garantia});
            this.dtgGarantia.Location = new System.Drawing.Point(17, 53);
            this.dtgGarantia.Margin = new System.Windows.Forms.Padding(2);
            this.dtgGarantia.Name = "dtgGarantia";
            this.dtgGarantia.ReadOnly = true;
            this.dtgGarantia.RowHeadersVisible = false;
            this.dtgGarantia.RowHeadersWidth = 51;
            this.dtgGarantia.RowTemplate.Height = 24;
            this.dtgGarantia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGarantia.Size = new System.Drawing.Size(745, 330);
            this.dtgGarantia.TabIndex = 10;
            // 
            // Id_garantia
            // 
            this.Id_garantia.DataPropertyName = "Id_garantia";
            this.Id_garantia.HeaderText = "Id garantia";
            this.Id_garantia.MinimumWidth = 6;
            this.Id_garantia.Name = "Id_garantia";
            this.Id_garantia.ReadOnly = true;
            // 
            // Nom_cli
            // 
            this.Nom_cli.DataPropertyName = "Nom_cli";
            this.Nom_cli.HeaderText = "Nombre cliente";
            this.Nom_cli.MinimumWidth = 6;
            this.Nom_cli.Name = "Nom_cli";
            this.Nom_cli.ReadOnly = true;
            // 
            // Ape_cli
            // 
            this.Ape_cli.DataPropertyName = "Ape_cli";
            this.Ape_cli.HeaderText = "Apellido Cliente";
            this.Ape_cli.MinimumWidth = 6;
            this.Ape_cli.Name = "Ape_cli";
            this.Ape_cli.ReadOnly = true;
            // 
            // Id_cli
            // 
            this.Id_cli.DataPropertyName = "Id_cli";
            this.Id_cli.HeaderText = "Id cliente";
            this.Id_cli.MinimumWidth = 6;
            this.Id_cli.Name = "Id_cli";
            this.Id_cli.ReadOnly = true;
            // 
            // Tip_garantia
            // 
            this.Tip_garantia.DataPropertyName = "Tip_garantia";
            this.Tip_garantia.HeaderText = "Tipo";
            this.Tip_garantia.MinimumWidth = 6;
            this.Tip_garantia.Name = "Tip_garantia";
            this.Tip_garantia.ReadOnly = true;
            // 
            // Des_garantia
            // 
            this.Des_garantia.DataPropertyName = "Des_garantia";
            this.Des_garantia.HeaderText = "Descripcion";
            this.Des_garantia.MinimumWidth = 6;
            this.Des_garantia.Name = "Des_garantia";
            this.Des_garantia.ReadOnly = true;
            // 
            // Valor_garantia
            // 
            this.Valor_garantia.DataPropertyName = "Valor_garantia";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor_garantia.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor_garantia.HeaderText = "Valor (S/.)";
            this.Valor_garantia.MinimumWidth = 6;
            this.Valor_garantia.Name = "Valor_garantia";
            this.Valor_garantia.ReadOnly = true;
            // 
            // Est_garantia
            // 
            this.Est_garantia.DataPropertyName = "Estado garantia";
            this.Est_garantia.HeaderText = "Estado";
            this.Est_garantia.MinimumWidth = 6;
            this.Est_garantia.Name = "Est_garantia";
            this.Est_garantia.ReadOnly = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(155, 21);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(164, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apellido del cliente:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(113, 401);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(77, 28);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(17, 401);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(77, 28);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(213, 401);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 30);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // GarantiaMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 485);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgGarantia);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GarantiaMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Garantía";
            this.Load += new System.EventHandler(this.GarantiaMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGarantia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgGarantia;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip_garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des_garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Est_garantia;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
    }
}