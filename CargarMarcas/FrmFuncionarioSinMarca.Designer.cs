namespace CargarMarcas
{
    partial class FrmFuncionarioSinMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarioSinMarca));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            cmbDepartamento = new ComboBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            btnGenerar = new Button();
            checkBox3 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 66);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 32);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(241, 25);
            label1.TabIndex = 1;
            label1.Text = "Validador de Marcaciones";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 85);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(196, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Empleados sin marca de ingreso";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 110);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(187, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Empleados sin marca de salida";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(12, 245);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(361, 23);
            cmbDepartamento.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 227);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 7;
            label2.Text = "Departamento";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(12, 185);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(99, 23);
            dtpFecha.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha Marca";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(126, 288);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(136, 23);
            btnGenerar.TabIndex = 9;
            btnGenerar.Text = "Generar reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 135);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(127, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Enviar correo alerta";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // FrmFuncionarioSinMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 330);
            Controls.Add(btnGenerar);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbDepartamento);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFuncionarioSinMarca";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox cmbDepartamento;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Button btnGenerar;
        private CheckBox checkBox3;
    }
}