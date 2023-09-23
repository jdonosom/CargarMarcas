namespace CargarMarcas
{
    partial class FrmHorario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorario));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            dgHorario = new DataGridView();
            colDia = new DataGridViewTextBoxColumn();
            colHE = new DataGridViewTextBoxColumn();
            colHS = new DataGridViewTextBoxColumn();
            colTHE = new DataGridViewTextBoxColumn();
            colTHS = new DataGridViewTextBoxColumn();
            colHET = new DataGridViewTextBoxColumn();
            colHST = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            lblHorario = new Label();
            label3 = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnHlpEmpleado = new Button();
            btnTurno = new Button();
            panel4 = new Panel();
            label5 = new Label();
            process1 = new System.Diagnostics.Process();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHorario).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(109, 198);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 19);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 19);
            label1.TabIndex = 0;
            label1.Text = "Mañana";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(392, 198);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 19);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.CornflowerBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(308, 19);
            label2.TabIndex = 0;
            label2.Text = "Tarde";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgHorario
            // 
            dgHorario.AllowUserToAddRows = false;
            dgHorario.AllowUserToDeleteRows = false;
            dgHorario.AllowUserToResizeColumns = false;
            dgHorario.AllowUserToResizeRows = false;
            dgHorario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgHorario.Columns.AddRange(new DataGridViewColumn[] { colDia, colHE, colHS, colTHE, colTHS, colHET, colHST });
            dgHorario.Location = new Point(10, 216);
            dgHorario.Margin = new Padding(3, 2, 3, 2);
            dgHorario.MultiSelect = false;
            dgHorario.Name = "dgHorario";
            dgHorario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgHorario.RowHeadersVisible = false;
            dgHorario.RowHeadersWidth = 51;
            dgHorario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgHorario.RowTemplate.Height = 29;
            dgHorario.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgHorario.Size = new Size(690, 266);
            dgHorario.TabIndex = 1;
            dgHorario.CellBeginEdit += dgHorario_CellBeginEdit;
            dgHorario.CellEndEdit += dgHorario_CellEndEdit;
            dgHorario.CellValueChanged += dgHorario_CellValueChanged;
            dgHorario.EditingControlShowing += dgHorario_EditingControlShowing;
            // 
            // colDia
            // 
            colDia.HeaderText = "Dia";
            colDia.Name = "colDia";
            colDia.Resizable = DataGridViewTriState.False;
            colDia.Width = 98;
            // 
            // colHE
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = "00:00";
            colHE.DefaultCellStyle = dataGridViewCellStyle1;
            colHE.HeaderText = "E.M.";
            colHE.MinimumWidth = 6;
            colHE.Name = "colHE";
            colHE.ToolTipText = "Hora entrada mañana";
            colHE.Width = 98;
            // 
            // colHS
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = "00:00";
            colHS.DefaultCellStyle = dataGridViewCellStyle2;
            colHS.HeaderText = "S.M.";
            colHS.MinimumWidth = 6;
            colHS.Name = "colHS";
            colHS.ToolTipText = "Hora salida mañana";
            colHS.Width = 98;
            // 
            // colTHE
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            colTHE.DefaultCellStyle = dataGridViewCellStyle3;
            colTHE.FillWeight = 90F;
            colTHE.HeaderText = "T.A.";
            colTHE.MinimumWidth = 6;
            colTHE.Name = "colTHE";
            colTHE.ToolTipText = "Tolerancia acceso mañana";
            colTHE.Width = 87;
            // 
            // colTHS
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = "00:00";
            colTHS.DefaultCellStyle = dataGridViewCellStyle4;
            colTHS.HeaderText = "E.T.";
            colTHS.MinimumWidth = 6;
            colTHS.Name = "colTHS";
            colTHS.ToolTipText = "Hora entrada tarde";
            colTHS.Width = 98;
            // 
            // colHET
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = "00:00";
            colHET.DefaultCellStyle = dataGridViewCellStyle5;
            colHET.HeaderText = "S.T.";
            colHET.MinimumWidth = 6;
            colHET.Name = "colHET";
            colHET.ToolTipText = "Hora salida tarde";
            colHET.Width = 98;
            // 
            // colHST
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            colHST.DefaultCellStyle = dataGridViewCellStyle6;
            colHST.HeaderText = "T.S.";
            colHST.MinimumWidth = 6;
            colHST.Name = "colHST";
            colHST.ToolTipText = "Tolerancia salida tarde";
            colHST.Width = 87;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGreen;
            panel5.Controls.Add(lblHorario);
            panel5.Location = new Point(10, 179);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(690, 19);
            panel5.TabIndex = 4;
            // 
            // lblHorario
            // 
            lblHorario.BackColor = Color.Blue;
            lblHorario.BorderStyle = BorderStyle.FixedSingle;
            lblHorario.Dock = DockStyle.Fill;
            lblHorario.FlatStyle = FlatStyle.Flat;
            lblHorario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorario.ForeColor = Color.White;
            lblHorario.Location = new Point(0, 0);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(690, 19);
            lblHorario.TabIndex = 0;
            lblHorario.TextAlign = ContentAlignment.MiddleCenter;
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
            txtNombre.Size = new Size(558, 23);
            txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 94);
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
            panel3.Size = new Size(718, 64);
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
            btnTurno.Location = new Point(668, 72);
            btnTurno.Margin = new Padding(3, 2, 3, 2);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(32, 28);
            btnTurno.TabIndex = 10;
            btnTurno.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGreen;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(10, 198);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(101, 19);
            panel4.TabIndex = 0;
            // 
            // label5
            // 
            label5.BackColor = Color.LemonChiffon;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Fill;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 0;
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            // FrmHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 502);
            Controls.Add(btnTurno);
            Controls.Add(btnHlpEmpleado);
            Controls.Add(panel3);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel5);
            Controls.Add(dgHorario);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHorario";
            ShowIcon = false;
            Load += FrmHorario_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgHorario).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView dgHorario;
        private Panel panel5;
        private Label lblHorario;
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
        private Panel panel4;
        private Label label5;
        private TextBox textBox3;
        private System.Diagnostics.Process process1;
        private DataGridViewTextBoxColumn colDia;
        private DataGridViewTextBoxColumn colHE;
        private DataGridViewTextBoxColumn colHS;
        private DataGridViewTextBoxColumn colTHE;
        private DataGridViewTextBoxColumn colTHS;
        private DataGridViewTextBoxColumn colHET;
        private DataGridViewTextBoxColumn colHST;
    }
}