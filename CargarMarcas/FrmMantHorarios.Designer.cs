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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantHorarios));
            dgHorario = new DataGridView();
            colDia = new DataGridViewTextBoxColumn();
            colHE = new DataGridViewTextBoxColumn();
            colHS = new DataGridViewTextBoxColumn();
            colTHE = new DataGridViewTextBoxColumn();
            colTHS = new DataGridViewTextBoxColumn();
            colHET = new DataGridViewTextBoxColumn();
            colHST = new DataGridViewTextBoxColumn();
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
            panel5 = new Panel();
            lblHorario = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgHorario).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dgHorario.Location = new Point(10, 168);
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
            dgHorario.TabIndex = 2;
            // 
            // colDia
            // 
            colDia.HeaderText = "Dia";
            colDia.Name = "colDia";
            colDia.Resizable = DataGridViewTriState.False;
            colDia.Width = 120;
            // 
            // colHE
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = "00:00";
            colHE.DefaultCellStyle = dataGridViewCellStyle7;
            colHE.HeaderText = "E.M.";
            colHE.MinimumWidth = 6;
            colHE.Name = "colHE";
            colHE.ToolTipText = "Hora entrada mañana";
            colHE.Width = 98;
            // 
            // colHS
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = "00:00";
            colHS.DefaultCellStyle = dataGridViewCellStyle8;
            colHS.HeaderText = "S.M.";
            colHS.MinimumWidth = 6;
            colHS.Name = "colHS";
            colHS.ToolTipText = "Hora salida mañana";
            colHS.Width = 98;
            // 
            // colTHE
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            colTHE.DefaultCellStyle = dataGridViewCellStyle9;
            colTHE.FillWeight = 90F;
            colTHE.HeaderText = "T.A.";
            colTHE.MinimumWidth = 6;
            colTHE.Name = "colTHE";
            colTHE.ToolTipText = "Tolerancia acceso mañana";
            colTHE.Width = 87;
            // 
            // colTHS
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = "00:00";
            colTHS.DefaultCellStyle = dataGridViewCellStyle10;
            colTHS.HeaderText = "E.T.";
            colTHS.MinimumWidth = 6;
            colTHS.Name = "colTHS";
            colTHS.ToolTipText = "Hora entrada tarde";
            colTHS.Width = 98;
            // 
            // colHET
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.Format = "t";
            dataGridViewCellStyle11.NullValue = "00:00";
            colHET.DefaultCellStyle = dataGridViewCellStyle11;
            colHET.HeaderText = "S.T.";
            colHET.MinimumWidth = 6;
            colHET.Name = "colHET";
            colHET.ToolTipText = "Hora salida tarde";
            colHET.Width = 98;
            // 
            // colHST
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            colHST.DefaultCellStyle = dataGridViewCellStyle12;
            colHST.HeaderText = "T.S.";
            colHST.MinimumWidth = 6;
            colHST.Name = "colHST";
            colHST.ToolTipText = "Tolerancia salida tarde";
            colHST.Width = 87;
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
            panel3.Size = new Size(714, 64);
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
            btnAceptar.Location = new Point(544, 440);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(625, 440);
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
            // panel5
            // 
            panel5.BackColor = Color.LightGreen;
            panel5.Controls.Add(lblHorario);
            panel5.Location = new Point(10, 130);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(690, 19);
            panel5.TabIndex = 17;
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
            // panel4
            // 
            panel4.BackColor = Color.LightGreen;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(10, 149);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(123, 19);
            panel4.TabIndex = 14;
            // 
            // label5
            // 
            label5.BackColor = Color.LemonChiffon;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Fill;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 19);
            label5.TabIndex = 0;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(415, 149);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 19);
            panel2.TabIndex = 15;
            // 
            // label3
            // 
            label3.BackColor = Color.CornflowerBlue;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(285, 19);
            label3.TabIndex = 0;
            label3.Text = "Tarde";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(132, 149);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 19);
            panel1.TabIndex = 16;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(283, 19);
            label4.TabIndex = 0;
            label4.Text = "Mañana";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMantHorarios
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 472);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtIdHorario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnHlpEmpleado);
            Controls.Add(panel3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgHorario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMantHorarios";
            ShowIcon = false;
            Load += FrmMantHorarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgHorario).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgHorario;
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
        private Panel panel5;
        private Label lblHorario;
        private Panel panel4;
        private Label label5;
        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private DataGridViewTextBoxColumn colDia;
        private DataGridViewTextBoxColumn colHE;
        private DataGridViewTextBoxColumn colHS;
        private DataGridViewTextBoxColumn colTHE;
        private DataGridViewTextBoxColumn colTHS;
        private DataGridViewTextBoxColumn colHET;
        private DataGridViewTextBoxColumn colHST;
    }
}