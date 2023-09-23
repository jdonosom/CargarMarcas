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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantHorarios));
            dgHorario = new DataGridView();
            colDia = new DataGridViewTextBoxColumn();
            colHE = new DataGridViewTextBoxColumn();
            colHS = new DataGridViewTextBoxColumn();
            colTHE = new DataGridViewTextBoxColumn();
            colTHS = new DataGridViewTextBoxColumn();
            colHET = new DataGridViewTextBoxColumn();
            colHST = new DataGridViewTextBoxColumn();
            tTextBoxEx1 = new CSUST.Data.TTextBoxEx();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnHlpEmpleado = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgHorario).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            dgHorario.Location = new Point(10, 130);
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
            colDia.Width = 98;
            // 
            // colHE
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle13.Format = "t";
            dataGridViewCellStyle13.NullValue = "00:00";
            colHE.DefaultCellStyle = dataGridViewCellStyle13;
            colHE.HeaderText = "E.M.";
            colHE.MinimumWidth = 6;
            colHE.Name = "colHE";
            colHE.ToolTipText = "Hora entrada mañana";
            colHE.Width = 98;
            // 
            // colHS
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.Format = "t";
            dataGridViewCellStyle14.NullValue = "00:00";
            colHS.DefaultCellStyle = dataGridViewCellStyle14;
            colHS.HeaderText = "S.M.";
            colHS.MinimumWidth = 6;
            colHS.Name = "colHS";
            colHS.ToolTipText = "Hora salida mañana";
            colHS.Width = 98;
            // 
            // colTHE
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = "0";
            colTHE.DefaultCellStyle = dataGridViewCellStyle15;
            colTHE.FillWeight = 90F;
            colTHE.HeaderText = "T.A.";
            colTHE.MinimumWidth = 6;
            colTHE.Name = "colTHE";
            colTHE.ToolTipText = "Tolerancia acceso mañana";
            colTHE.Width = 87;
            // 
            // colTHS
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle16.Format = "t";
            dataGridViewCellStyle16.NullValue = "00:00";
            colTHS.DefaultCellStyle = dataGridViewCellStyle16;
            colTHS.HeaderText = "E.T.";
            colTHS.MinimumWidth = 6;
            colTHS.Name = "colTHS";
            colTHS.ToolTipText = "Hora entrada tarde";
            colTHS.Width = 98;
            // 
            // colHET
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.Format = "t";
            dataGridViewCellStyle17.NullValue = "00:00";
            colHET.DefaultCellStyle = dataGridViewCellStyle17;
            colHET.HeaderText = "S.T.";
            colHET.MinimumWidth = 6;
            colHET.Name = "colHET";
            colHET.ToolTipText = "Hora salida tarde";
            colHET.Width = 98;
            // 
            // colHST
            // 
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(192, 192, 0);
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = "0";
            colHST.DefaultCellStyle = dataGridViewCellStyle18;
            colHST.HeaderText = "T.S.";
            colHST.MinimumWidth = 6;
            colHST.Name = "colHST";
            colHST.ToolTipText = "Tolerancia salida tarde";
            colHST.Width = 87;
            // 
            // tTextBoxEx1
            // 
            tTextBoxEx1.Location = new Point(10, 102);
            tTextBoxEx1.Name = "tTextBoxEx1";
            tTextBoxEx1.Size = new Size(64, 23);
            tTextBoxEx1.TabIndex = 3;
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
            // textBox1
            // 
            textBox1.Location = new Point(123, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(556, 23);
            textBox1.TabIndex = 5;
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
            btnAceptar.Location = new Point(544, 402);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(625, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmMantHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 431);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnHlpEmpleado);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tTextBoxEx1);
            Controls.Add(dgHorario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMantHorarios";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)dgHorario).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgHorario;
        private DataGridViewTextBoxColumn colDia;
        private DataGridViewTextBoxColumn colHE;
        private DataGridViewTextBoxColumn colHS;
        private DataGridViewTextBoxColumn colTHE;
        private DataGridViewTextBoxColumn colTHS;
        private DataGridViewTextBoxColumn colHET;
        private DataGridViewTextBoxColumn colHST;
        private CSUST.Data.TTextBoxEx tTextBoxEx1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnHlpEmpleado;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}