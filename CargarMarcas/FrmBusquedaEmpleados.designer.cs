namespace CargarMarcas
{
    partial class FrmBusquedaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaEmpleados));
            btnAceptar = new Button();
            label3 = new Label();
            txtCliente = new TextBox();
            lstClientes = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel1 = new Panel();
            panel15 = new Panel();
            pictureBox1 = new PictureBox();
            label42 = new Label();
            txtTitulo = new Label();
            panel1.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = SystemColors.Control;
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(534, 559);
            btnAceptar.Margin = new Padding(4, 6, 4, 6);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(89, 24);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 13);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.ForeColor = Color.Black;
            txtCliente.Location = new Point(16, 106);
            txtCliente.Margin = new Padding(4, 6, 4, 6);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(607, 20);
            txtCliente.TabIndex = 1;
            txtCliente.TextChanged += txtCliente_TextChanged;
            txtCliente.KeyDown += txtCliente_KeyDown;
            // 
            // lstClientes
            // 
            lstClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstClientes.BackColor = Color.White;
            lstClientes.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            lstClientes.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstClientes.FullRowSelect = true;
            lstClientes.Location = new Point(16, 138);
            lstClientes.Margin = new Padding(4, 6, 4, 6);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(607, 409);
            lstClientes.TabIndex = 3;
            lstClientes.UseCompatibleStateImageBehavior = false;
            lstClientes.View = View.Details;
            lstClientes.DoubleClick += lstClientes_DoubleClick;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Rut";
            columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nombres";
            columnHeader4.Width = 455;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(lstClientes);
            panel1.Controls.Add(txtCliente);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 598);
            panel1.TabIndex = 487;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.Controls.Add(pictureBox1);
            panel15.Controls.Add(label42);
            panel15.Dock = DockStyle.Top;
            panel15.ForeColor = Color.White;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(640, 69);
            panel15.TabIndex = 2007;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label42
            // 
            label42.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label42.ForeColor = SystemColors.ControlDarkDark;
            label42.Location = new Point(57, 28);
            label42.Name = "label42";
            label42.Size = new Size(235, 27);
            label42.TabIndex = 2;
            label42.Text = "Busqueda de empleados";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.ForeColor = Color.White;
            txtTitulo.Location = new Point(1, -37);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(315, 32);
            txtTitulo.TabIndex = 488;
            txtTitulo.Text = "Búsqueda de beneficiarios";
            txtTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmBusquedaClientes
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            CancelButton = btnAceptar;
            ClientSize = new Size(640, 598);
            Controls.Add(txtTitulo);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBusquedaClientes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmBusquedaClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label3;
        private TextBox txtCliente;
        private ListView lstClientes;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panel1;
        private Label txtTitulo;
        private Panel panel15;

        private Label label42;
        private PictureBox pictureBox1;
    }
}