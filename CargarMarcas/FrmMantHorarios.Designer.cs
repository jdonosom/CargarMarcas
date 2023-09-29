namespace CargarMarcas
{
    partial class FrmMantHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantHorarios));
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnHlpEmpleado = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtIdHorario = new CSUST.Data.TNumEditBox();
            btnLimpiar = new Button();
            ucCtrlHorario1 = new Controls.ucCtrlHorario();
            label3 = new Label();
            lblHrsSemanales = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 84);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 84);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(123, 102);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(508, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(688, 64);
            panel3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(64, 29);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 1;
            label6.Text = "Horarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnHlpEmpleado
            // 
            btnHlpEmpleado.Location = new Point(80, 101);
            btnHlpEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnHlpEmpleado.Name = "btnHlpEmpleado";
            btnHlpEmpleado.Size = new Size(37, 23);
            btnHlpEmpleado.TabIndex = 10;
            btnHlpEmpleado.Text = "?";
            btnHlpEmpleado.UseVisualStyleBackColor = true;
            btnHlpEmpleado.Click += btnHlpEmpleado_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(515, 403);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(596, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtIdHorario
            // 
            txtIdHorario.Location = new Point(10, 102);
            txtIdHorario.Name = "txtIdHorario";
            txtIdHorario.Size = new Size(64, 23);
            txtIdHorario.TabIndex = 13;
            txtIdHorario.KeyPress += txtIdHorario_KeyPress;
            txtIdHorario.Leave += txtIdHorario_Leave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(637, 101);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(24, 24);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ucCtrlHorario1
            // 
            ucCtrlHorario1.AutoSize = true;
            ucCtrlHorario1.Descripcion = null;
            ucCtrlHorario1.Horario = null;
            ucCtrlHorario1.Location = new Point(10, 130);
            ucCtrlHorario1.Name = "ucCtrlHorario1";
            ucCtrlHorario1.Size = new Size(672, 267);
            ucCtrlHorario1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 404);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 19;
            label3.Text = "Horas semanales: ";
            // 
            // lblHrsSemanales
            // 
            lblHrsSemanales.AutoSize = true;
            lblHrsSemanales.Location = new Point(123, 407);
            lblHrsSemanales.Name = "lblHrsSemanales";
            lblHrsSemanales.Size = new Size(13, 15);
            lblHrsSemanales.TabIndex = 19;
            lblHrsSemanales.Text = "0";
            // 
            // FrmMantHorarios
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 431);
            Controls.Add(lblHrsSemanales);
            Controls.Add(label3);
            Controls.Add(ucCtrlHorario1);
            Controls.Add(txtIdHorario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnHlpEmpleado);
            Controls.Add(panel3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMantHorarios";
            ShowIcon = false;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnHlpEmpleado;
        private Button btnAceptar;
        private Button btnCancelar;
        private CSUST.Data.TNumEditBox txtIdHorario;
        private Button btnLimpiar;
        private Controls.ucCtrlHorario ucCtrlHorario1;
        private Label label3;
        private Label lblHrsSemanales;
    }
}