namespace CargarMarcas.Controls
{
    partial class ucCtrlHorario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel5 = new Panel();
            lblHorario = new Label();
            dgHorario = new DataGridView();
            colDia = new DataGridViewTextBoxColumn();
            colHE = new DataGridViewTextBoxColumn();
            colHS = new DataGridViewTextBoxColumn();
            colTHE = new DataGridViewTextBoxColumn();
            colTHS = new DataGridViewTextBoxColumn();
            colHET = new DataGridViewTextBoxColumn();
            colHST = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHorario).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGreen;
            panel5.Controls.Add(lblHorario);
            panel5.Location = new Point(1, 1);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(668, 19);
            panel5.TabIndex = 9;
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
            lblHorario.Size = new Size(668, 19);
            lblHorario.TabIndex = 0;
            lblHorario.TextAlign = ContentAlignment.MiddleCenter;
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
            dgHorario.Location = new Point(1, 38);
            dgHorario.Margin = new Padding(3, 2, 3, 2);
            dgHorario.MultiSelect = false;
            dgHorario.Name = "dgHorario";
            dgHorario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgHorario.RowHeadersVisible = false;
            dgHorario.RowHeadersWidth = 51;
            dgHorario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgHorario.RowTemplate.Height = 29;
            dgHorario.ScrollBars = ScrollBars.None;
            dgHorario.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgHorario.Size = new Size(668, 227);
            dgHorario.TabIndex = 8;
            dgHorario.CellBeginEdit += dgHorario_CellBeginEdit;
            dgHorario.CellEndEdit += dgHorario_CellEndEdit;
            dgHorario.CellValueChanged += dgHorario_CellValueChanged;
            dgHorario.EditingControlShowing += dgHorario_EditingControlShowing;
            dgHorario.KeyDown += dgHorario_KeyDown;
            dgHorario.KeyPress += dgHorario_KeyPress;
            dgHorario.Leave += dgHorario_Leave;
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
            dataGridViewCellStyle1.NullValue = " ";
            colHE.DefaultCellStyle = dataGridViewCellStyle1;
            colHE.HeaderText = "E.M.";
            colHE.MaxInputLength = 4;
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
            dataGridViewCellStyle2.NullValue = " ";
            colHS.DefaultCellStyle = dataGridViewCellStyle2;
            colHS.HeaderText = "S.M.";
            colHS.MaxInputLength = 4;
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
            dataGridViewCellStyle3.NullValue = " ";
            colTHE.DefaultCellStyle = dataGridViewCellStyle3;
            colTHE.FillWeight = 90F;
            colTHE.HeaderText = "T.A.";
            colTHE.MaxInputLength = 2;
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
            dataGridViewCellStyle4.NullValue = " ";
            colTHS.DefaultCellStyle = dataGridViewCellStyle4;
            colTHS.HeaderText = "E.T.";
            colTHS.MaxInputLength = 4;
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
            dataGridViewCellStyle5.NullValue = " ";
            colHET.DefaultCellStyle = dataGridViewCellStyle5;
            colHET.HeaderText = "S.T.";
            colHET.MaxInputLength = 4;
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
            dataGridViewCellStyle6.NullValue = " ";
            colHST.DefaultCellStyle = dataGridViewCellStyle6;
            colHST.HeaderText = "T.S.";
            colHST.MaxInputLength = 2;
            colHST.MinimumWidth = 6;
            colHST.Name = "colHST";
            colHST.ToolTipText = "Tolerancia salida tarde";
            colHST.Width = 87;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGreen;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(1, 20);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(101, 19);
            panel4.TabIndex = 5;
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
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(383, 20);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 19);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = Color.CornflowerBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(286, 19);
            label2.TabIndex = 0;
            label2.Text = "Tarde";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(100, 20);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 19);
            panel1.TabIndex = 7;
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
            // ucCtrlHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel5);
            Controls.Add(dgHorario);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucCtrlHorario";
            Size = new Size(672, 267);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgHorario).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label lblHorario;
        private DataGridView dgHorario;
        private Panel panel4;
        private Label label5;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn colDia;
        private DataGridViewTextBoxColumn colHE;
        private DataGridViewTextBoxColumn colHS;
        private DataGridViewTextBoxColumn colTHE;
        private DataGridViewTextBoxColumn colTHS;
        private DataGridViewTextBoxColumn colHET;
        private DataGridViewTextBoxColumn colHST;
    }
}
