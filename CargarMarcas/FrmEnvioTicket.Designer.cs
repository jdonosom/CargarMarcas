namespace CargarMarcas
{
    partial class FrmEnvioTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnvioTicket));
            btnGenerar = new Button();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            cmbDepartamento = new ComboBox();
            chkEnvioCorreo = new CheckBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(127, 167);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(136, 23);
            btnGenerar.TabIndex = 17;
            btnGenerar.Text = "Generar reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(18, 47);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(99, 23);
            dtpFecha.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 29);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 14;
            label3.Text = "Fecha Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 110);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 15;
            label2.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(18, 128);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(361, 23);
            cmbDepartamento.TabIndex = 13;
            // 
            // chkEnvioCorreo
            // 
            chkEnvioCorreo.AutoSize = true;
            chkEnvioCorreo.Location = new Point(18, 88);
            chkEnvioCorreo.Name = "chkEnvioCorreo";
            chkEnvioCorreo.Size = new Size(127, 19);
            chkEnvioCorreo.TabIndex = 10;
            chkEnvioCorreo.Text = "Enviar correo alerta";
            chkEnvioCorreo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGenerar);
            groupBox1.Controls.Add(chkEnvioCorreo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbDepartamento);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Location = new Point(12, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 206);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Envio de tickets";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 66);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 32);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Envio Ticket";
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
            // FrmEnvioTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 309);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEnvioTicket";
            ShowIcon = false;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerar;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Label label2;
        private ComboBox cmbDepartamento;
        private CheckBox chkEnvioCorreo;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}