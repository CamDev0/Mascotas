
namespace MascotasElHuerfanito
{
    partial class MascotasAdoptadas
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
            this.dataGridAdopReg = new System.Windows.Forms.DataGridView();
            this.idMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosTablaAdopcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualiClien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdopReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaAdopcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mascotas Adoptadas!";
            // 
            // dataGridAdopReg
            // 
            this.dataGridAdopReg.AutoGenerateColumns = false;
            this.dataGridAdopReg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAdopReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdopReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMascotaDataGridViewTextBoxColumn,
            this.nombreMascotaDataGridViewTextBoxColumn,
            this.tipoMascotaDataGridViewTextBoxColumn});
            this.dataGridAdopReg.DataSource = this.datosTablaAdopcionBindingSource;
            this.dataGridAdopReg.Location = new System.Drawing.Point(16, 58);
            this.dataGridAdopReg.Name = "dataGridAdopReg";
            this.dataGridAdopReg.Size = new System.Drawing.Size(345, 224);
            this.dataGridAdopReg.TabIndex = 2;
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
            // datosTablaAdopcionBindingSource
            // 
            this.datosTablaAdopcionBindingSource.DataSource = typeof(MascotasElHuerfanito.DatosTablaAdopcion);
            // 
            // btnActualiClien
            // 
            this.btnActualiClien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiClien.Location = new System.Drawing.Point(424, 58);
            this.btnActualiClien.Name = "btnActualiClien";
            this.btnActualiClien.Size = new System.Drawing.Size(107, 38);
            this.btnActualiClien.TabIndex = 8;
            this.btnActualiClien.Text = "Actualizar Lista";
            this.btnActualiClien.UseVisualStyleBackColor = true;
            this.btnActualiClien.Click += new System.EventHandler(this.btnActualiClien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MascotasElHuerfanito.Properties.Resources.foto3;
            this.pictureBox1.Location = new System.Drawing.Point(381, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MascotasAdoptadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 327);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualiClien);
            this.Controls.Add(this.dataGridAdopReg);
            this.Controls.Add(this.label1);
            this.Name = "MascotasAdoptadas";
            this.Text = "MascotasAdoptadas";
            this.Load += new System.EventHandler(this.MascotasAdoptadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdopReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTablaAdopcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAdopReg;
        private System.Windows.Forms.BindingSource datosTablaAdopcionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualiClien;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}