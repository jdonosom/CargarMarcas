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
            dataGridView1 = new DataGridView();
            colHE = new DataGridViewTextBoxColumn();
            colHS = new DataGridViewTextBoxColumn();
            colTHE = new DataGridViewTextBoxColumn();
            colTHS = new DataGridViewTextBoxColumn();
            colHET = new DataGridViewTextBoxColumn();
            colHST = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            label5 = new Label();
            label3 = new Label();
            txtRut = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnHlpEmpleado = new Button();
            btnTurno = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 198);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 19);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(422, 19);
            label1.TabIndex = 0;
            label1.Text = "Mañana";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(431, 198);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 19);
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
            label2.Size = new Size(423, 19);
            label2.TabIndex = 0;
            label2.Text = "Tarde";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colHE, colHS, colTHE, colTHS, colHET, colHST });
            dataGridView1.Location = new Point(10, 216);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(873, 266);
            dataGridView1.TabIndex = 1;
            // 
            // colHE
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = "00:00";
            colHE.DefaultCellStyle = dataGridViewCellStyle1;
            colHE.HeaderText = "H.E.M.";
            colHE.MinimumWidth = 6;
            colHE.Name = "colHE";
            colHE.ToolTipText = "Hora Entrada";
            colHE.Width = 200;
            // 
            // colHS
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = "00:00";
            colHS.DefaultCellStyle = dataGridViewCellStyle2;
            colHS.HeaderText = "H.S.M.";
            colHS.MinimumWidth = 6;
            colHS.Name = "colHS";
            colHS.ToolTipText = "Hora Salida";
            colHS.Width = 200;
            // 
            // colTHE
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            colTHE.DefaultCellStyle = dataGridViewCellStyle3;
            colTHE.HeaderText = "T.H.E.";
            colTHE.MinimumWidth = 6;
            colTHE.Name = "colTHE";
            colTHE.Width = 80;
            // 
            // colTHS
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = "00:00";
            colTHS.DefaultCellStyle = dataGridViewCellStyle4;
            colTHS.HeaderText = "H.E.T.";
            colTHS.MinimumWidth = 6;
            colTHS.Name = "colTHS";
            colTHS.Width = 200;
            // 
            // colHET
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = "00:00";
            colHET.DefaultCellStyle = dataGridViewCellStyle5;
            colHET.HeaderText = "H.S.T.";
            colHET.MinimumWidth = 6;
            colHET.Name = "colHET";
            colHET.Width = 200;
            // 
            // colHST
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            colHST.DefaultCellStyle = dataGridViewCellStyle6;
            colHST.HeaderText = "T.H.S.";
            colHST.MinimumWidth = 6;
            colHST.Name = "colHST";
            colHST.Width = 80;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGreen;
            panel5.Controls.Add(label5);
            panel5.Location = new Point(10, 179);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(844, 19);
            panel5.TabIndex = 4;
            // 
            // label5
            // 
            label5.BackColor = Color.Blue;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Fill;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(844, 19);
            label5.TabIndex = 0;
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            txtRut.Size = new Size(127, 23);
            txtRut.TabIndex = 6;
            txtRut.KeyPress += txtRut_KeyPress;
            txtRut.KeyUp += txtRut_KeyUp;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Enabled = false;
            textBox2.Location = new Point(185, 111);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(670, 23);
            textBox2.TabIndex = 7;
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
            panel3.Size = new Size(897, 64);
            panel3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(63, 27);
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
            btnHlpEmpleado.Location = new Point(143, 111);
            btnHlpEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnHlpEmpleado.Name = "btnHlpEmpleado";
            btnHlpEmpleado.Size = new Size(37, 23);
            btnHlpEmpleado.TabIndex = 9;
            btnHlpEmpleado.Text = "?";
            btnHlpEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnTurno
            // 
            btnTurno.Image = (Image)resources.GetObject("btnTurno.Image");
            btnTurno.Location = new Point(822, 69);
            btnTurno.Margin = new Padding(3, 2, 3, 2);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(32, 28);
            btnTurno.TabIndex = 10;
            btnTurno.UseVisualStyleBackColor = true;
            // 
            // FrmHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 524);
            Controls.Add(btnTurno);
            Controls.Add(btnHlpEmpleado);
            Controls.Add(panel3);
            Controls.Add(textBox2);
            Controls.Add(txtRut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel5);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHorario";
            ShowIcon = false;
            Load += FrmHorario_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Label label5;
        private Label label3;
        private TextBox txtRut;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn colHE;
        private DataGridViewTextBoxColumn colHS;
        private DataGridViewTextBoxColumn colTHE;
        private DataGridViewTextBoxColumn colTHS;
        private DataGridViewTextBoxColumn colHET;
        private DataGridViewTextBoxColumn colHST;
        private Label label4;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnHlpEmpleado;
        private Button btnTurno;
    }
}