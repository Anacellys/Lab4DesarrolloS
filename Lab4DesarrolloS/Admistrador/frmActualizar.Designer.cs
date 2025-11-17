namespace Lab4DesarrolloS.Admistrador
{
    partial class frmActualizar
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblCant);
            this.panel1.Controls.Add(this.txtCant);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.dgvVisualizacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(92, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 438);
            this.panel1.TabIndex = 1;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(673, 49);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(93, 36);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Mostar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dgvVisualizacion
            // 
            this.dgvVisualizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizacion.Location = new System.Drawing.Point(249, 91);
            this.dgvVisualizacion.Name = "dgvVisualizacion";
            this.dgvVisualizacion.RowHeadersWidth = 51;
            this.dgvVisualizacion.RowTemplate.Height = 24;
            this.dgvVisualizacion.Size = new System.Drawing.Size(386, 211);
            this.dgvVisualizacion.TabIndex = 6;
            this.dgvVisualizacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizacion_CellContentClick);
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
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(488, 364);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 34);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(329, 370);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 22);
            this.txtCant.TabIndex = 9;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(246, 375);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(61, 16);
            this.lblCant.TabIndex = 10;
            this.lblCant.Text = "Cantidad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(246, 335);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(329, 332);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 12;
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 502);
            this.Controls.Add(this.panel1);
            this.Name = "frmActualizar";
            this.Text = "frmActualizar";
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
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}