namespace gestionador_de_tareas
{
    partial class Gestor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnTa = new System.Windows.Forms.Button();
            this.btnTi = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtFlag = new System.Windows.Forms.TextBox();
            this.Btnt = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.lblAI = new System.Windows.Forms.Label();
            this.LblGestionador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(718, 65);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(718, 112);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(718, 165);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnTa
            // 
            this.BtnTa.Location = new System.Drawing.Point(663, 219);
            this.BtnTa.Name = "BtnTa";
            this.BtnTa.Size = new System.Drawing.Size(130, 23);
            this.BtnTa.TabIndex = 4;
            this.BtnTa.Text = "Mostrar tareas activas";
            this.BtnTa.UseVisualStyleBackColor = true;
            this.BtnTa.Click += new System.EventHandler(this.BtnTa_Click);
            // 
            // btnTi
            // 
            this.btnTi.Location = new System.Drawing.Point(663, 273);
            this.btnTi.Name = "btnTi";
            this.btnTi.Size = new System.Drawing.Size(130, 23);
            this.btnTi.TabIndex = 5;
            this.btnTi.Text = "Mostrar tareas inactivas";
            this.btnTi.UseVisualStyleBackColor = true;
            this.btnTi.Click += new System.EventHandler(this.btnTi_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(62, 276);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(298, 276);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(102, 20);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // TxtFlag
            // 
            this.TxtFlag.Location = new System.Drawing.Point(519, 273);
            this.TxtFlag.Name = "TxtFlag";
            this.TxtFlag.Size = new System.Drawing.Size(100, 20);
            this.TxtFlag.TabIndex = 8;
            // 
            // Btnt
            // 
            this.Btnt.Location = new System.Drawing.Point(663, 328);
            this.Btnt.Name = "Btnt";
            this.Btnt.Size = new System.Drawing.Size(130, 23);
            this.Btnt.TabIndex = 9;
            this.Btnt.Text = "Mostrar tareas";
            this.Btnt.UseVisualStyleBackColor = true;
            this.Btnt.Click += new System.EventHandler(this.Btnt_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(62, 260);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(100, 13);
            this.LblNombre.TabIndex = 10;
            this.LblNombre.Text = "Nombre de la tarea ";
            this.LblNombre.UseMnemonic = false;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(315, 259);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 11;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Location = new System.Drawing.Point(532, 257);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(87, 13);
            this.lblAI.TabIndex = 12;
            this.lblAI.Text = "Activo e Inactivo";
            // 
            // LblGestionador
            // 
            this.LblGestionador.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.LblGestionador.AutoSize = true;
            this.LblGestionador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblGestionador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblGestionador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblGestionador.Location = new System.Drawing.Point(261, 9);
            this.LblGestionador.Name = "LblGestionador";
            this.LblGestionador.Size = new System.Drawing.Size(152, 15);
            this.LblGestionador.TabIndex = 13;
            this.LblGestionador.Text = "GESTIONADOR DE TAREAS";
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblGestionador);
            this.Controls.Add(this.lblAI);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.Btnt);
            this.Controls.Add(this.TxtFlag);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.btnTi);
            this.Controls.Add(this.BtnTa);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gestor";
            this.Text = "Gestionador de tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnTa;
        private System.Windows.Forms.Button btnTi;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtFlag;
        private System.Windows.Forms.Button Btnt;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.Label LblGestionador;
    }
}

