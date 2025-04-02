namespace Gridview
{
    partial class Form1
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
            this.DGdatos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAnio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAnio = new System.Windows.Forms.TextBox();
            this.tbxGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDuracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDirector = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxClasificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGdatos
            // 
            this.DGdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdatos.Location = new System.Drawing.Point(61, 32);
            this.DGdatos.Name = "DGdatos";
            this.DGdatos.Size = new System.Drawing.Size(485, 179);
            this.DGdatos.TabIndex = 0;
            this.DGdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(274, 217);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAnio
            // 
            this.btnAnio.Location = new System.Drawing.Point(65, 303);
            this.btnAnio.Name = "btnAnio";
            this.btnAnio.Size = new System.Drawing.Size(75, 23);
            this.btnAnio.TabIndex = 2;
            this.btnAnio.Text = "Eliminar";
            this.btnAnio.UseVisualStyleBackColor = true;
            this.btnAnio.Click += new System.EventHandler(this.btnAnio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Año";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbAnio
            // 
            this.txbAnio.Location = new System.Drawing.Point(61, 277);
            this.txbAnio.Name = "txbAnio";
            this.txbAnio.Size = new System.Drawing.Size(100, 20);
            this.txbAnio.TabIndex = 4;
            // 
            // tbxGenero
            // 
            this.tbxGenero.Location = new System.Drawing.Point(446, 237);
            this.tbxGenero.Name = "tbxGenero";
            this.tbxGenero.Size = new System.Drawing.Size(100, 20);
            this.tbxGenero.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genero";
            // 
            // tbxDuracion
            // 
            this.tbxDuracion.Location = new System.Drawing.Point(446, 277);
            this.tbxDuracion.Name = "tbxDuracion";
            this.tbxDuracion.Size = new System.Drawing.Size(100, 20);
            this.tbxDuracion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duracion";
            // 
            // tbxDirector
            // 
            this.tbxDirector.Location = new System.Drawing.Point(446, 319);
            this.tbxDirector.Name = "tbxDirector";
            this.tbxDirector.Size = new System.Drawing.Size(100, 20);
            this.tbxDirector.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Director";
            // 
            // tbxClasificacion
            // 
            this.tbxClasificacion.Location = new System.Drawing.Point(446, 362);
            this.tbxClasificacion.Name = "tbxClasificacion";
            this.tbxClasificacion.Size = new System.Drawing.Size(100, 20);
            this.tbxClasificacion.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Clasificacion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(455, 398);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 451);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxClasificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxDirector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxDuracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnio);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.DGdatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGdatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAnio;
        private System.Windows.Forms.TextBox tbxGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDirector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxClasificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
    }
}

