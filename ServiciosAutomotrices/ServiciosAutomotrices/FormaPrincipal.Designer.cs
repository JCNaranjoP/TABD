namespace ServiciosAutomotrices
{
    partial class FormaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PaginaDetallePlaca = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextoPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.TextoMarcaVehiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextoModeloVehiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBoxPlacas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaginaMarcas = new System.Windows.Forms.TabPage();
            this.dataGridViewMarcas = new System.Windows.Forms.DataGridView();
            this.clmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaginaSedes = new System.Windows.Forms.TabPage();
            this.dataGridViewSedes = new System.Windows.Forms.DataGridView();
            this.clmNombreSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaginaServicios = new System.Windows.Forms.TabPage();
            this.dataGridViewServicios = new System.Windows.Forms.DataGridView();
            this.clmServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalServicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewServiciosVehiculo = new System.Windows.Forms.DataGridView();
            this.clmServicioFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmServicioPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmServicioSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxJsonVehiculo = new System.Windows.Forms.TextBox();
            this.PaginaDBJSON = new System.Windows.Forms.TabPage();
            this.textBoxDBJson = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.PaginaDetallePlaca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PaginaMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarcas)).BeginInit();
            this.PaginaSedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSedes)).BeginInit();
            this.PaginaServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiciosVehiculo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.PaginaDBJSON.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PaginaDetallePlaca);
            this.tabControl1.Controls.Add(this.PaginaMarcas);
            this.tabControl1.Controls.Add(this.PaginaSedes);
            this.tabControl1.Controls.Add(this.PaginaServicios);
            this.tabControl1.Controls.Add(this.PaginaDBJSON);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // PaginaDetallePlaca
            // 
            this.PaginaDetallePlaca.Controls.Add(this.groupBox3);
            this.PaginaDetallePlaca.Controls.Add(this.groupBox2);
            this.PaginaDetallePlaca.Controls.Add(this.groupBox1);
            this.PaginaDetallePlaca.Controls.Add(this.ListBoxPlacas);
            this.PaginaDetallePlaca.Controls.Add(this.label1);
            this.PaginaDetallePlaca.Location = new System.Drawing.Point(4, 22);
            this.PaginaDetallePlaca.Name = "PaginaDetallePlaca";
            this.PaginaDetallePlaca.Padding = new System.Windows.Forms.Padding(3);
            this.PaginaDetallePlaca.Size = new System.Drawing.Size(801, 347);
            this.PaginaDetallePlaca.TabIndex = 0;
            this.PaginaDetallePlaca.Text = "Detalle Placa";
            this.PaginaDetallePlaca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextoPlacaVehiculo);
            this.groupBox1.Controls.Add(this.TextoMarcaVehiculo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextoModeloVehiculo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculo seleccionado:";
            // 
            // TextoPlacaVehiculo
            // 
            this.TextoPlacaVehiculo.Enabled = false;
            this.TextoPlacaVehiculo.Location = new System.Drawing.Point(63, 29);
            this.TextoPlacaVehiculo.Name = "TextoPlacaVehiculo";
            this.TextoPlacaVehiculo.Size = new System.Drawing.Size(109, 20);
            this.TextoPlacaVehiculo.TabIndex = 2;
            this.TextoPlacaVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextoMarcaVehiculo
            // 
            this.TextoMarcaVehiculo.Enabled = false;
            this.TextoMarcaVehiculo.Location = new System.Drawing.Point(63, 56);
            this.TextoMarcaVehiculo.Name = "TextoMarcaVehiculo";
            this.TextoMarcaVehiculo.Size = new System.Drawing.Size(109, 20);
            this.TextoMarcaVehiculo.TabIndex = 3;
            this.TextoMarcaVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modelo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextoModeloVehiculo
            // 
            this.TextoModeloVehiculo.Enabled = false;
            this.TextoModeloVehiculo.Location = new System.Drawing.Point(63, 83);
            this.TextoModeloVehiculo.Name = "TextoModeloVehiculo";
            this.TextoModeloVehiculo.Size = new System.Drawing.Size(109, 20);
            this.TextoModeloVehiculo.TabIndex = 4;
            this.TextoModeloVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Placa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListBoxPlacas
            // 
            this.ListBoxPlacas.FormattingEnabled = true;
            this.ListBoxPlacas.Location = new System.Drawing.Point(122, 21);
            this.ListBoxPlacas.Name = "ListBoxPlacas";
            this.ListBoxPlacas.Size = new System.Drawing.Size(97, 43);
            this.ListBoxPlacas.TabIndex = 8;
            this.ListBoxPlacas.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlacas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placas registradas:";
            // 
            // PaginaMarcas
            // 
            this.PaginaMarcas.Controls.Add(this.dataGridViewMarcas);
            this.PaginaMarcas.Location = new System.Drawing.Point(4, 22);
            this.PaginaMarcas.Name = "PaginaMarcas";
            this.PaginaMarcas.Padding = new System.Windows.Forms.Padding(3);
            this.PaginaMarcas.Size = new System.Drawing.Size(519, 347);
            this.PaginaMarcas.TabIndex = 1;
            this.PaginaMarcas.Text = "Marcas más atendidas";
            this.PaginaMarcas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMarcas
            // 
            this.dataGridViewMarcas.AllowUserToAddRows = false;
            this.dataGridViewMarcas.AllowUserToDeleteRows = false;
            this.dataGridViewMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMarca,
            this.clmTotalMarca});
            this.dataGridViewMarcas.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewMarcas.Name = "dataGridViewMarcas";
            this.dataGridViewMarcas.ReadOnly = true;
            this.dataGridViewMarcas.Size = new System.Drawing.Size(430, 336);
            this.dataGridViewMarcas.TabIndex = 0;
            // 
            // clmMarca
            // 
            this.clmMarca.DataPropertyName = "nombre_marca";
            this.clmMarca.HeaderText = "Marca Vehiculo";
            this.clmMarca.Name = "clmMarca";
            this.clmMarca.ReadOnly = true;
            // 
            // clmTotalMarca
            // 
            this.clmTotalMarca.DataPropertyName = "total_marca";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmTotalMarca.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmTotalMarca.HeaderText = "Total Marca";
            this.clmTotalMarca.Name = "clmTotalMarca";
            this.clmTotalMarca.ReadOnly = true;
            // 
            // PaginaSedes
            // 
            this.PaginaSedes.Controls.Add(this.dataGridViewSedes);
            this.PaginaSedes.Location = new System.Drawing.Point(4, 22);
            this.PaginaSedes.Name = "PaginaSedes";
            this.PaginaSedes.Padding = new System.Windows.Forms.Padding(3);
            this.PaginaSedes.Size = new System.Drawing.Size(519, 347);
            this.PaginaSedes.TabIndex = 2;
            this.PaginaSedes.Text = "Sedes más visitadas";
            this.PaginaSedes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSedes
            // 
            this.dataGridViewSedes.AllowUserToAddRows = false;
            this.dataGridViewSedes.AllowUserToDeleteRows = false;
            this.dataGridViewSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombreSede,
            this.clmTotalSede});
            this.dataGridViewSedes.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewSedes.Name = "dataGridViewSedes";
            this.dataGridViewSedes.ReadOnly = true;
            this.dataGridViewSedes.Size = new System.Drawing.Size(430, 336);
            this.dataGridViewSedes.TabIndex = 0;
            // 
            // clmNombreSede
            // 
            this.clmNombreSede.DataPropertyName = "nombre_sede";
            this.clmNombreSede.HeaderText = "Nombre Sede";
            this.clmNombreSede.Name = "clmNombreSede";
            this.clmNombreSede.ReadOnly = true;
            this.clmNombreSede.Width = 150;
            // 
            // clmTotalSede
            // 
            this.clmTotalSede.DataPropertyName = "total_sede";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmTotalSede.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmTotalSede.HeaderText = "Total Visitas";
            this.clmTotalSede.Name = "clmTotalSede";
            this.clmTotalSede.ReadOnly = true;
            // 
            // PaginaServicios
            // 
            this.PaginaServicios.Controls.Add(this.dataGridViewServicios);
            this.PaginaServicios.Location = new System.Drawing.Point(4, 22);
            this.PaginaServicios.Name = "PaginaServicios";
            this.PaginaServicios.Padding = new System.Windows.Forms.Padding(3);
            this.PaginaServicios.Size = new System.Drawing.Size(519, 347);
            this.PaginaServicios.TabIndex = 3;
            this.PaginaServicios.Text = "Servicios más solicitados";
            this.PaginaServicios.UseVisualStyleBackColor = true;
            // 
            // dataGridViewServicios
            // 
            this.dataGridViewServicios.AllowUserToAddRows = false;
            this.dataGridViewServicios.AllowUserToDeleteRows = false;
            this.dataGridViewServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmServicio,
            this.clmTotalServicios});
            this.dataGridViewServicios.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewServicios.Name = "dataGridViewServicios";
            this.dataGridViewServicios.ReadOnly = true;
            this.dataGridViewServicios.Size = new System.Drawing.Size(430, 336);
            this.dataGridViewServicios.TabIndex = 0;
            // 
            // clmServicio
            // 
            this.clmServicio.DataPropertyName = "nombre_servicio";
            this.clmServicio.HeaderText = "Servicio";
            this.clmServicio.Name = "clmServicio";
            this.clmServicio.ReadOnly = true;
            this.clmServicio.Width = 180;
            // 
            // clmTotalServicios
            // 
            this.clmTotalServicios.DataPropertyName = "total_servicio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmTotalServicios.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmTotalServicios.HeaderText = "Total Visitas";
            this.clmTotalServicios.Name = "clmTotalServicios";
            this.clmTotalServicios.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewServiciosVehiculo);
            this.groupBox2.Location = new System.Drawing.Point(242, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 187);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servicios registrados:";
            // 
            // dataGridViewServiciosVehiculo
            // 
            this.dataGridViewServiciosVehiculo.AllowUserToAddRows = false;
            this.dataGridViewServiciosVehiculo.AllowUserToDeleteRows = false;
            this.dataGridViewServiciosVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiciosVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmServicioFecha,
            this.clmServicioPlaca,
            this.clmServicioSede});
            this.dataGridViewServiciosVehiculo.Location = new System.Drawing.Point(5, 20);
            this.dataGridViewServiciosVehiculo.Name = "dataGridViewServiciosVehiculo";
            this.dataGridViewServiciosVehiculo.ReadOnly = true;
            this.dataGridViewServiciosVehiculo.Size = new System.Drawing.Size(526, 150);
            this.dataGridViewServiciosVehiculo.TabIndex = 0;
            // 
            // clmServicioFecha
            // 
            this.clmServicioFecha.DataPropertyName = "fecha_servicio";
            this.clmServicioFecha.HeaderText = "Fecha";
            this.clmServicioFecha.Name = "clmServicioFecha";
            this.clmServicioFecha.ReadOnly = true;
            this.clmServicioFecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmServicioFecha.Width = 70;
            // 
            // clmServicioPlaca
            // 
            this.clmServicioPlaca.DataPropertyName = "nombre_servicio";
            this.clmServicioPlaca.HeaderText = "Servicio";
            this.clmServicioPlaca.Name = "clmServicioPlaca";
            this.clmServicioPlaca.ReadOnly = true;
            this.clmServicioPlaca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmServicioPlaca.Width = 180;
            // 
            // clmServicioSede
            // 
            this.clmServicioSede.DataPropertyName = "sede_servicio";
            this.clmServicioSede.HeaderText = "Sede";
            this.clmServicioSede.Name = "clmServicioSede";
            this.clmServicioSede.ReadOnly = true;
            this.clmServicioSede.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmServicioSede.Width = 180;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxJsonVehiculo);
            this.groupBox3.Location = new System.Drawing.Point(23, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 95);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Representación en JSON";
            // 
            // textBoxJsonVehiculo
            // 
            this.textBoxJsonVehiculo.Location = new System.Drawing.Point(5, 20);
            this.textBoxJsonVehiculo.Multiline = true;
            this.textBoxJsonVehiculo.Name = "textBoxJsonVehiculo";
            this.textBoxJsonVehiculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxJsonVehiculo.Size = new System.Drawing.Size(745, 69);
            this.textBoxJsonVehiculo.TabIndex = 0;
            // 
            // PaginaDBJSON
            // 
            this.PaginaDBJSON.Controls.Add(this.textBoxDBJson);
            this.PaginaDBJSON.Location = new System.Drawing.Point(4, 22);
            this.PaginaDBJSON.Name = "PaginaDBJSON";
            this.PaginaDBJSON.Padding = new System.Windows.Forms.Padding(3);
            this.PaginaDBJSON.Size = new System.Drawing.Size(801, 347);
            this.PaginaDBJSON.TabIndex = 4;
            this.PaginaDBJSON.Text = "DB en JSON";
            this.PaginaDBJSON.UseVisualStyleBackColor = true;
            // 
            // textBoxDBJson
            // 
            this.textBoxDBJson.Location = new System.Drawing.Point(6, 6);
            this.textBoxDBJson.Multiline = true;
            this.textBoxDBJson.Name = "textBoxDBJson";
            this.textBoxDBJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDBJson.Size = new System.Drawing.Size(495, 335);
            this.textBoxDBJson.TabIndex = 0;
            // 
            // FormaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios Automotrices";
            this.Load += new System.EventHandler(this.FormaPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.PaginaDetallePlaca.ResumeLayout(false);
            this.PaginaDetallePlaca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PaginaMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarcas)).EndInit();
            this.PaginaSedes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSedes)).EndInit();
            this.PaginaServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiciosVehiculo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PaginaDBJSON.ResumeLayout(false);
            this.PaginaDBJSON.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PaginaDetallePlaca;
        private System.Windows.Forms.TabPage PaginaMarcas;
        private System.Windows.Forms.TabPage PaginaSedes;
        private System.Windows.Forms.TabPage PaginaServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextoModeloVehiculo;
        private System.Windows.Forms.TextBox TextoMarcaVehiculo;
        private System.Windows.Forms.TextBox TextoPlacaVehiculo;
        private System.Windows.Forms.ListBox ListBoxPlacas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalMarca;
        private System.Windows.Forms.DataGridView dataGridViewSedes;
        private System.Windows.Forms.DataGridView dataGridViewServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalServicios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewServiciosVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmServicioFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmServicioPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmServicioSede;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxJsonVehiculo;
        private System.Windows.Forms.TabPage PaginaDBJSON;
        private System.Windows.Forms.TextBox textBoxDBJson;
    }
}

