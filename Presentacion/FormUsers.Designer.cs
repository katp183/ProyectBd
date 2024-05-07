namespace Presentacion
{
    partial class FormUsers
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
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_nuevousuario = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_modusuario = new System.Windows.Forms.Button();
            this.Btn_eliminarusuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(949, 358);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // Btn_nuevousuario
            // 
            this.Btn_nuevousuario.Location = new System.Drawing.Point(29, 342);
            this.Btn_nuevousuario.Name = "Btn_nuevousuario";
            this.Btn_nuevousuario.Size = new System.Drawing.Size(108, 55);
            this.Btn_nuevousuario.TabIndex = 2;
            this.Btn_nuevousuario.Text = "Nuevo Usuario";
            this.Btn_nuevousuario.UseVisualStyleBackColor = true;
            this.Btn_nuevousuario.Click += new System.EventHandler(this.Btn_nuevousuario_Click);
            // 
            // Btn_modusuario
            // 
            this.Btn_modusuario.Location = new System.Drawing.Point(167, 342);
            this.Btn_modusuario.Name = "Btn_modusuario";
            this.Btn_modusuario.Size = new System.Drawing.Size(103, 55);
            this.Btn_modusuario.TabIndex = 3;
            this.Btn_modusuario.Text = "Modificar Usuario";
            this.Btn_modusuario.UseVisualStyleBackColor = true;
            this.Btn_modusuario.Click += new System.EventHandler(this.Btn_modusuario_Click);
            // 
            // Btn_eliminarusuario
            // 
            this.Btn_eliminarusuario.Location = new System.Drawing.Point(319, 342);
            this.Btn_eliminarusuario.Name = "Btn_eliminarusuario";
            this.Btn_eliminarusuario.Size = new System.Drawing.Size(113, 55);
            this.Btn_eliminarusuario.TabIndex = 4;
            this.Btn_eliminarusuario.Text = "Eliminar Usuario";
            this.Btn_eliminarusuario.UseVisualStyleBackColor = true;
            this.Btn_eliminarusuario.Click += new System.EventHandler(this.Btn_eliminarusuario_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.Btn_eliminarusuario);
            this.Controls.Add(this.Btn_modusuario);
            this.Controls.Add(this.Btn_nuevousuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Cerrar);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_nuevousuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_modusuario;
        private System.Windows.Forms.Button Btn_eliminarusuario;
    }
}