
namespace MascotasElHuerfanito
{
    partial class RegistroClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualiClien = new System.Windows.Forms.Button();
            this.gridDataCliCon = new System.Windows.Forms.DataGridView();
            this.idCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosTablaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataCliCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(285, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes Actuales";
            // 
            // btnActualiClien
            // 
            this.btnActualiClien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiClien.Location = new System.Drawing.Point(555, 19);
            this.btnActualiClien.Name = "btnActualiClien";
            this.btnActualiClien.Size = new System.Drawing.Size(127, 46);
            this.btnActualiClien.TabIndex = 7;
            this.btnActualiClien.Text = "Actualizar Lista";
            this.btnActualiClien.UseVisualStyleBackColor = true;
            this.btnActualiClien.Click += new System.EventHandler(this.btnActualiClien_Click);
            // 
            // gridDataCliCon
            // 
            this.gridDataCliCon.AutoGenerateColumns = false;
            this.gridDataCliCon.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDataCliCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDataCliCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataCliCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCLIDataGridViewTextBoxColumn,
            this.idAdopDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.gridDataCliCon.DataSource = this.datosTablaClientesBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDataCliCon.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridDataCliCon.Location = new System.Drawing.Point(37, 86);
            this.gridDataCliCon.Name = "gridDataCliCon";
            this.gridDataCliCon.Size = new System.Drawing.Size(645, 292);
            this.gridDataCliCon.TabIndex = 8;
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
            // datosTablaClientesBindingSource
            // 
            this.datosTablaClientesBindingSource.DataSource = typeof(MascotasElHuerfanito.DatosTablaClientes);
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 419);
            this.Controls.Add(this.gridDataCliCon);
            this.Controls.Add(this.btnActualiClien);
            this.Controls.Add(this.label1);
            this.Name = "RegistroClientes";
            this.Text = "RegistroClientes";
            this.Load += new System.EventHandler(this.RegistroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataCliCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualiClien;
        private System.Windows.Forms.DataGridView gridDataCliCon;
        private System.Windows.Forms.BindingSource datosTablaClientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}