namespace CargarMarcas
{
    partial class FrmHorarioFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorarioFuncionario));
            label3 = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnHlpEmpleado = new Button();
            btnTurno = new Button();
            process1 = new System.Diagnostics.Process();
            ucCtrlHorario1 = new Controls.ucCtrlHorario();
            lblHrsSemanales = new Label();
            label7 = new Label();
            btnLimpiar = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 94);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 5;
            label3.Text = "Rut";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(10, 111);
            txtRut.Margin = new Padding(3, 2, 3, 2);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(83, 23);
            txtRut.TabIndex = 6;
            txtRut.KeyDown += txtRut_KeyDown;
            txtRut.KeyPress += txtRut_KeyPress;
            txtRut.KeyUp += txtRut_KeyUp;
            txtRut.Leave += txtRut_Leave;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(142, 111);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(427, 23);
            txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 94);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Nombre";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(687, 64);
            panel3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(55, 25);
            label6.Name = "label6";
            label6.Size = new Size(228, 25);
            label6.TabIndex = 1;
            label6.Text = "Horario por funcionario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnHlpEmpleado
            // 
            btnHlpEmpleado.Location = new Point(99, 111);
            btnHlpEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnHlpEmpleado.Name = "btnHlpEmpleado";
            btnHlpEmpleado.Size = new Size(37, 23);
            btnHlpEmpleado.TabIndex = 9;
            btnHlpEmpleado.Text = "?";
            btnHlpEmpleado.UseVisualStyleBackColor = true;
            btnHlpEmpleado.Click += btnHlpEmpleado_Click;
            // 
            // btnTurno
            // 
            btnTurno.Image = (Image)resources.GetObject("btnTurno.Image");
            btnTurno.Location = new Point(537, 79);
            btnTurno.Margin = new Padding(3, 2, 3, 2);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(32, 28);
            btnTurno.TabIndex = 10;
            btnTurno.UseVisualStyleBackColor = true;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // ucCtrlHorario1
            // 
            ucCtrlHorario1.AutoSize = true;
            ucCtrlHorario1.Descripcion = null;
            ucCtrlHorario1.Horario = null;
            ucCtrlHorario1.Location = new Point(9, 151);
            ucCtrlHorario1.Name = "ucCtrlHorario1";
            ucCtrlHorario1.Size = new Size(672, 267);
            ucCtrlHorario1.TabIndex = 11;
            // 
            // lblHrsSemanales
            // 
            lblHrsSemanales.BorderStyle = BorderStyle.FixedSingle;
            lblHrsSemanales.FlatStyle = FlatStyle.Flat;
            lblHrsSemanales.Location = new Point(575, 111);
            lblHrsSemanales.Name = "lblHrsSemanales";
            lblHrsSemanales.Size = new Size(65, 23);
            lblHrsSemanales.TabIndex = 22;
            lblHrsSemanales.Text = "0";
            lblHrsSemanales.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(575, 77);
            label7.Name = "label7";
            label7.Size = new Size(65, 32);
            label7.TabIndex = 21;
            label7.Text = "Horas semanales";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(650, 112);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(24, 24);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmHorarioFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 460);
            Controls.Add(lblHrsSemanales);
            Controls.Add(label7);
            Controls.Add(btnLimpiar);
            Controls.Add(ucCtrlHorario1);
            Controls.Add(btnTurno);
            Controls.Add(btnHlpEmpleado);
            Controls.Add(panel3);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHorarioFuncionario";
            ShowIcon = false;
            Load += FrmHorario_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtRut;
        private TextBox textBox2;
        private Label label4;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnHlpEmpleado;
        private Button btnTurno;
        private TextBox txtNombre;
        private TextBox textBox3;
        private System.Diagnostics.Process process1;
        private Controls.ucCtrlHorario ucCtrlHorario1;
        private Label lblHrsSemanales;
        private Label label7;
        private Button btnLimpiar;
    }
}