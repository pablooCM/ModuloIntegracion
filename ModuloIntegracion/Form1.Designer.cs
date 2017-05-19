namespace ModuloIntegracion
{
    partial class FormModuloIntegracion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonListaClientesMercadeo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRegistroNuevoCliente = new System.Windows.Forms.Button();
            this.dataGridViewModuloIntegracion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModuloIntegracion)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListaClientesMercadeo
            // 
            this.buttonListaClientesMercadeo.Location = new System.Drawing.Point(33, 35);
            this.buttonListaClientesMercadeo.Name = "buttonListaClientesMercadeo";
            this.buttonListaClientesMercadeo.Size = new System.Drawing.Size(196, 23);
            this.buttonListaClientesMercadeo.TabIndex = 0;
            this.buttonListaClientesMercadeo.Text = "Lista de Clientes Mercadeo";
            this.buttonListaClientesMercadeo.UseVisualStyleBackColor = true;
            this.buttonListaClientesMercadeo.Click += new System.EventHandler(this.buttonListaClientesMercadeo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Solicitudes de Servicio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonRegistroNuevoCliente
            // 
            this.buttonRegistroNuevoCliente.Location = new System.Drawing.Point(33, 515);
            this.buttonRegistroNuevoCliente.Name = "buttonRegistroNuevoCliente";
            this.buttonRegistroNuevoCliente.Size = new System.Drawing.Size(196, 23);
            this.buttonRegistroNuevoCliente.TabIndex = 2;
            this.buttonRegistroNuevoCliente.Text = "Registrar Nuevo Cliente";
            this.buttonRegistroNuevoCliente.UseVisualStyleBackColor = true;
            this.buttonRegistroNuevoCliente.Click += new System.EventHandler(this.buttonRegistroNuevoCliente_Click);
            // 
            // dataGridViewModuloIntegracion
            // 
            this.dataGridViewModuloIntegracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModuloIntegracion.Location = new System.Drawing.Point(339, 12);
            this.dataGridViewModuloIntegracion.Name = "dataGridViewModuloIntegracion";
            this.dataGridViewModuloIntegracion.Size = new System.Drawing.Size(586, 249);
            this.dataGridViewModuloIntegracion.TabIndex = 3;
            // 
            // FormModuloIntegracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 662);
            this.Controls.Add(this.dataGridViewModuloIntegracion);
            this.Controls.Add(this.buttonRegistroNuevoCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonListaClientesMercadeo);
            this.Name = "FormModuloIntegracion";
            this.Text = "Módulo Integración";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModuloIntegracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListaClientesMercadeo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRegistroNuevoCliente;
        private System.Windows.Forms.DataGridView dataGridViewModuloIntegracion;
    }
}

