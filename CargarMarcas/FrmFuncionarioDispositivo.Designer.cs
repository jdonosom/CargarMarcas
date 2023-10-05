namespace CargarMarcas
{
    partial class FrmFuncionarioDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarioDispositivo));
            lstEmpleado = new ListBox();
            lstDispositivo = new ListBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnMinus = new Button();
            lstAsignacion = new ListView();
            colEmpleado = new ColumnHeader();
            colDispositivo = new ColumnHeader();
            colIdDispositivo = new ColumnHeader();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lstEmpleado
            // 
            lstEmpleado.FormattingEnabled = true;
            lstEmpleado.ItemHeight = 15;
            lstEmpleado.Location = new Point(12, 61);
            lstEmpleado.Name = "lstEmpleado";
            lstEmpleado.Size = new Size(277, 304);
            lstEmpleado.TabIndex = 0;
            lstEmpleado.Click += lstEmpleado_Click;
            // 
            // lstDispositivo
            // 
            lstDispositivo.FormattingEnabled = true;
            lstDispositivo.ItemHeight = 15;
            lstDispositivo.Location = new Point(305, 61);
            lstDispositivo.Name = "lstDispositivo";
            lstDispositivo.SelectionMode = SelectionMode.MultiExtended;
            lstDispositivo.Size = new Size(277, 304);
            lstDispositivo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Empleado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 14);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Dispositivo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 377);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "Asignación";
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(536, 370);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(22, 22);
            btnAdd.TabIndex = 3;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMinus
            // 
            btnMinus.Image = (Image)resources.GetObject("btnMinus.Image");
            btnMinus.Location = new Point(561, 370);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(22, 22);
            btnMinus.TabIndex = 3;
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // lstAsignacion
            // 
            lstAsignacion.Columns.AddRange(new ColumnHeader[] { colEmpleado, colDispositivo, colIdDispositivo });
            lstAsignacion.FullRowSelect = true;
            lstAsignacion.GridLines = true;
            lstAsignacion.Location = new Point(12, 398);
            lstAsignacion.Name = "lstAsignacion";
            lstAsignacion.Size = new Size(570, 316);
            lstAsignacion.TabIndex = 4;
            lstAsignacion.UseCompatibleStateImageBehavior = false;
            lstAsignacion.View = View.Details;
            // 
            // colEmpleado
            // 
            colEmpleado.Text = "Empleado";
            colEmpleado.Width = 80;
            // 
            // colDispositivo
            // 
            colDispositivo.Text = "Dispositivo";
            colDispositivo.Width = 250;
            // 
            // colIdDispositivo
            // 
            colIdDispositivo.Text = "IdDevice";
            colIdDispositivo.Width = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(507, 725);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(426, 725);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmFuncionarioDispositivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 755);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lstAsignacion);
            Controls.Add(btnMinus);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lstDispositivo);
            Controls.Add(lstEmpleado);
            Name = "FrmFuncionarioDispositivo";
            Text = "FrmFuncionarioDispositivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleado;
        private ListBox lstDispositivo;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button btnAdd;
        private Button btnMinus;
        private ListView lstAsignacion;
        private ColumnHeader colEmpleado;
        private ColumnHeader colDispositivo;
        private ColumnHeader colIdDispositivo;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}