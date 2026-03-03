namespace WinFormsApp2
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtTitulo = new TextBox();
            dtpFecha = new DateTimePicker();
            lstTareas = new ListBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnCompletar = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(107, 23);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(218, 27);
            txtTitulo.TabIndex = 0;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(489, 23);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(289, 27);
            dtpFecha.TabIndex = 3;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(24, 190);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(418, 224);
            lstTareas.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(107, 84);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(335, 81);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(569, 173);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 59);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Añadir";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(569, 255);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 59);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(569, 344);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(152, 57);
            btnCompletar.TabIndex = 6;
            btnCompletar.Text = "Marcar";
            btnCompletar.UseVisualStyleBackColor = true;
            btnCompletar.Click += btnCompletar_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.Location = new Point(24, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(66, 27);
            textBox3.TabIndex = 7;
            textBox3.Text = "Nombre: ";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.Location = new Point(22, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(67, 27);
            textBox4.TabIndex = 8;
            textBox4.Text = "Desc";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.MenuBar;
            textBox5.Location = new Point(400, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(70, 27);
            textBox5.TabIndex = 9;
            textBox5.Text = "Fecha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(btnCompletar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(lstTareas);
            Controls.Add(dtpFecha);
            Controls.Add(txtTitulo);
            Name = "Form1";
            Text = "Gestor de Tareas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}