
namespace MascotasElHuerfanito
{
    partial class EliminarAdopcion
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
            this.dataGridDeleteAdop = new System.Windows.Forms.DataGridView();
            this.idMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.datosTablaAdopcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeleteAdop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaAdopcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDeleteAdop
            // 
            this.dataGridDeleteAdop.AutoGenerateColumns = false;
            this.dataGridDeleteAdop.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridDeleteAdop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeleteAdop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMascotaDataGridViewTextBoxColumn,
            this.nombreMascotaDataGridViewTextBoxColumn,
            this.tipoMascotaDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dataGridDeleteAdop.DataSource = this.datosTablaAdopcionBindingSource;
            this.dataGridDeleteAdop.Location = new System.Drawing.Point(49, 56);
            this.dataGridDeleteAdop.Name = "dataGridDeleteAdop";
            this.dataGridDeleteAdop.Size = new System.Drawing.Size(443, 245);
            this.dataGridDeleteAdop.TabIndex = 0;
            this.dataGridDeleteAdop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idMascotaDataGridViewTextBoxColumn
            // 
            this.idMascotaDataGridViewTextBoxColumn.DataPropertyName = "idMascota";
            this.idMascotaDataGridViewTextBoxColumn.HeaderText = "idMascota";
            this.idMascotaDataGridViewTextBoxColumn.Name = "idMascotaDataGridViewTextBoxColumn";
            // 
            // nombreMascotaDataGridViewTextBoxColumn
            // 
            this.nombreMascotaDataGridViewTextBoxColumn.DataPropertyName = "nombreMascota";
            this.nombreMascotaDataGridViewTextBoxColumn.HeaderText = "nombreMascota";
            this.nombreMascotaDataGridViewTextBoxColumn.Name = "nombreMascotaDataGridViewTextBoxColumn";
            // 
            // tipoMascotaDataGridViewTextBoxColumn
            // 
            this.tipoMascotaDataGridViewTextBoxColumn.DataPropertyName = "tipoMascota";
            this.tipoMascotaDataGridViewTextBoxColumn.HeaderText = "tipoMascota";
            this.tipoMascotaDataGridViewTextBoxColumn.Name = "tipoMascotaDataGridViewTextBoxColumn";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // datosTablaAdopcionBindingSource
            // 
            this.datosTablaAdopcionBindingSource.DataSource = typeof(MascotasElHuerfanito.DatosTablaAdopcion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminar Adopción";
            // 
            // EliminarAdopcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDeleteAdop);
            this.Name = "EliminarAdopcion";
            this.Text = "EliminarAdopcion";
            this.Load += new System.EventHandler(this.EliminarAdopcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeleteAdop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaAdopcionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDeleteAdop;
        private System.Windows.Forms.BindingSource datosTablaAdopcionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}