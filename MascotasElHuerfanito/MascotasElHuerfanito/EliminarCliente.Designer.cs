
namespace MascotasElHuerfanito
{
    partial class EliminarCliente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDeleteClientes = new System.Windows.Forms.DataGridView();
            this.idCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.datosTablaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataDeleteClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar un Cliente";
            // 
            // dataDeleteClientes
            // 
            this.dataDeleteClientes.AutoGenerateColumns = false;
            this.dataDeleteClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataDeleteClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDeleteClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCLIDataGridViewTextBoxColumn,
            this.idAdopDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dataDeleteClientes.DataSource = this.datosTablaClientesBindingSource;
            this.dataDeleteClientes.Location = new System.Drawing.Point(41, 60);
            this.dataDeleteClientes.Name = "dataDeleteClientes";
            this.dataDeleteClientes.Size = new System.Drawing.Size(746, 327);
            this.dataDeleteClientes.TabIndex = 1;
            this.dataDeleteClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCLIDataGridViewTextBoxColumn
            // 
            this.idCLIDataGridViewTextBoxColumn.DataPropertyName = "id_CLI";
            this.idCLIDataGridViewTextBoxColumn.HeaderText = "id_CLI";
            this.idCLIDataGridViewTextBoxColumn.Name = "idCLIDataGridViewTextBoxColumn";
            // 
            // idAdopDataGridViewTextBoxColumn
            // 
            this.idAdopDataGridViewTextBoxColumn.DataPropertyName = "idAdop";
            this.idAdopDataGridViewTextBoxColumn.HeaderText = "idAdop";
            this.idAdopDataGridViewTextBoxColumn.Name = "idAdopDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar Cliente";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // datosTablaClientesBindingSource
            // 
            this.datosTablaClientesBindingSource.DataSource = typeof(MascotasElHuerfanito.DatosTablaClientes);
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 429);
            this.Controls.Add(this.dataDeleteClientes);
            this.Controls.Add(this.label1);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDeleteClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataDeleteClientes;
        private System.Windows.Forms.BindingSource datosTablaClientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}