namespace Lab4DesarrolloS.Admistrador
{
    partial class frmVer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dgvVisualizacion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.dgvVisualizacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(115, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 595);
            this.panel1.TabIndex = 0;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(402, 358);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(93, 36);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Mostar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvVisualizacion
            // 
            this.dgvVisualizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizacion.Location = new System.Drawing.Point(80, 92);
            this.dgvVisualizacion.Name = "dgvVisualizacion";
            this.dgvVisualizacion.RowHeadersWidth = 51;
            this.dgvVisualizacion.RowTemplate.Height = 24;
            this.dgvVisualizacion.Size = new System.Drawing.Size(734, 211);
            this.dgvVisualizacion.TabIndex = 6;
            this.dgvVisualizacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminacion_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 619);
            this.Controls.Add(this.panel1);
            this.Name = "frmVer";
            this.Text = "frmVer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView dgvVisualizacion;
        private System.Windows.Forms.Label label1;
    }
}