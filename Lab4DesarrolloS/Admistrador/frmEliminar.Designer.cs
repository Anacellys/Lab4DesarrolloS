namespace Lab4DesarrolloS.Admistrador
{
    partial class frmEliminar
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEliminacion = new System.Windows.Forms.DataGridView();
            this.btnMostar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvEliminacion
            // 
            this.dgvEliminacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminacion.Location = new System.Drawing.Point(143, 88);
            this.dgvEliminacion.Name = "dgvEliminacion";
            this.dgvEliminacion.RowHeadersWidth = 51;
            this.dgvEliminacion.RowTemplate.Height = 24;
            this.dgvEliminacion.Size = new System.Drawing.Size(734, 211);
            this.dgvEliminacion.TabIndex = 1;
            this.dgvEliminacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminacion_CellContentClick);
            this.dgvEliminacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminacion_CellDoubleClick);
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(465, 354);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(93, 36);
            this.btnMostar.TabIndex = 4;
            this.btnMostar.Text = "Mostar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.ForeColor = System.Drawing.Color.Red;
            this.lblInformacion.Location = new System.Drawing.Point(451, 302);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(426, 16);
            this.lblInformacion.TabIndex = 5;
            this.lblInformacion.Text = "Para eliminar un registro, debera darle doble click al registro deseado.";
            this.lblInformacion.Visible = false;
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.dgvEliminacion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEliminacion;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Label lblInformacion;
    }
}