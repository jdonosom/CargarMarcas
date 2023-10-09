namespace CargarMarcas
{
    partial class FrmCargaMarca
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargaMarca));
            lstArchivos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLimpiar = new Button();
            btnCargar = new Button();
            txtBuffer = new TextBox();
            button1 = new Button();
            MenuReports = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            adignaciónHorariosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            mantenciónDeHorariosToolStripMenuItem = new ToolStripMenuItem();
            mantenciónDeFuncionariosToolStripMenuItem = new ToolStripMenuItem();
            mantenciónDeDispositivosToolStripMenuItem = new ToolStripMenuItem();
            asignaciónDispositivosToolStripMenuItem = new ToolStripMenuItem();
            progressBar1 = new ProgressBar();
            lblPorc = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MenuReports.SuspendLayout();
            SuspendLayout();
            // 
            // lstArchivos
            // 
            lstArchivos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstArchivos.FullRowSelect = true;
            lstArchivos.Location = new Point(10, 147);
            lstArchivos.Margin = new Padding(3, 4, 3, 4);
            lstArchivos.Name = "lstArchivos";
            lstArchivos.Size = new Size(306, 583);
            lstArchivos.TabIndex = 4;
            lstArchivos.UseCompatibleStateImageBehavior = false;
            lstArchivos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Archivo";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Reg.";
            columnHeader2.Width = 80;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 88);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 43);
            label1.Name = "label1";
            label1.Size = new Size(265, 32);
            label1.TabIndex = 1;
            label1.Text = "Carga de marcaciones";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(10, 96);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(37, 43);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Image = (Image)resources.GetObject("btnCargar.Image");
            btnCargar.Location = new Point(280, 96);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(37, 43);
            btnCargar.TabIndex = 7;
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtBuffer
            // 
            txtBuffer.Location = new Point(328, 152);
            txtBuffer.Margin = new Padding(3, 4, 3, 4);
            txtBuffer.Multiline = true;
            txtBuffer.Name = "txtBuffer";
            txtBuffer.ScrollBars = ScrollBars.Vertical;
            txtBuffer.Size = new Size(572, 577);
            txtBuffer.TabIndex = 8;
            // 
            // button1
            // 
            button1.ContextMenuStrip = MenuReports;
            button1.Location = new Point(738, 111);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 31);
            button1.TabIndex = 9;
            button1.Text = "Reportes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuReports
            // 
            MenuReports.ImageScalingSize = new Size(20, 20);
            MenuReports.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, adignaciónHorariosToolStripMenuItem, toolStripMenuItem4, mantenciónDeHorariosToolStripMenuItem, mantenciónDeFuncionariosToolStripMenuItem, mantenciónDeDispositivosToolStripMenuItem, asignaciónDispositivosToolStripMenuItem });
            MenuReports.Name = "contextMenuStrip1";
            MenuReports.Size = new Size(287, 184);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(286, 24);
            toolStripMenuItem1.Text = "Funcionario sin marca entrada";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(286, 24);
            toolStripMenuItem2.Text = "Funcionario sin marca de salida";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(283, 6);
            // 
            // adignaciónHorariosToolStripMenuItem
            // 
            adignaciónHorariosToolStripMenuItem.Name = "adignaciónHorariosToolStripMenuItem";
            adignaciónHorariosToolStripMenuItem.Size = new Size(286, 24);
            adignaciónHorariosToolStripMenuItem.Text = "Asignación horarios";
            adignaciónHorariosToolStripMenuItem.Click += adignaciónHorariosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(283, 6);
            // 
            // mantenciónDeHorariosToolStripMenuItem
            // 
            mantenciónDeHorariosToolStripMenuItem.Name = "mantenciónDeHorariosToolStripMenuItem";
            mantenciónDeHorariosToolStripMenuItem.Size = new Size(286, 24);
            mantenciónDeHorariosToolStripMenuItem.Text = "Mantención de horarios";
            mantenciónDeHorariosToolStripMenuItem.Click += mantenciónDeHorariosToolStripMenuItem_Click;
            // 
            // mantenciónDeFuncionariosToolStripMenuItem
            // 
            mantenciónDeFuncionariosToolStripMenuItem.Name = "mantenciónDeFuncionariosToolStripMenuItem";
            mantenciónDeFuncionariosToolStripMenuItem.Size = new Size(286, 24);
            mantenciónDeFuncionariosToolStripMenuItem.Text = "Mantención de Funcionarios";
            mantenciónDeFuncionariosToolStripMenuItem.Click += mantenciónDeFuncionariosToolStripMenuItem_Click;
            // 
            // mantenciónDeDispositivosToolStripMenuItem
            // 
            mantenciónDeDispositivosToolStripMenuItem.Name = "mantenciónDeDispositivosToolStripMenuItem";
            mantenciónDeDispositivosToolStripMenuItem.Size = new Size(286, 24);
            mantenciónDeDispositivosToolStripMenuItem.Text = "Mantención de dispositivos";
            // 
            // asignaciónDispositivosToolStripMenuItem
            // 
            asignaciónDispositivosToolStripMenuItem.Name = "asignaciónDispositivosToolStripMenuItem";
            asignaciónDispositivosToolStripMenuItem.Size = new Size(286, 24);
            asignaciónDispositivosToolStripMenuItem.Text = "Asignación Dispositivos";
            asignaciónDispositivosToolStripMenuItem.Click += asignaciónDispositivosToolStripMenuItem_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(54, 116);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(219, 20);
            progressBar1.TabIndex = 10;
            // 
            // lblPorc
            // 
            lblPorc.AutoSize = true;
            lblPorc.BackColor = Color.Transparent;
            lblPorc.Location = new Point(158, 92);
            lblPorc.Name = "lblPorc";
            lblPorc.Size = new Size(29, 20);
            lblPorc.TabIndex = 11;
            lblPorc.Text = "0%";
            lblPorc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmCargaMarca
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 747);
            Controls.Add(lblPorc);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(txtBuffer);
            Controls.Add(btnCargar);
            Controls.Add(btnLimpiar);
            Controls.Add(lstArchivos);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCargaMarca";
            ShowIcon = false;
            Load += FrmCargaMarca_Load;
            DragDrop += FrmCargaMarca_DragDrop;
            DragEnter += FrmCargaMarca_DragEnter;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MenuReports.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstArchivos;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private PictureBox pictureBox2;
        private Button btnLimpiar;
        private Button btnCargar;
        private TextBox txtBuffer;
        private Button button1;
        private ContextMenuStrip MenuReports;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem adignaciónHorariosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem mantenciónDeHorariosToolStripMenuItem;
        private ToolStripMenuItem mantenciónDeFuncionariosToolStripMenuItem;
        private ToolStripMenuItem asignaciónDispositivosToolStripMenuItem;
        private ToolStripMenuItem mantenciónDeDispositivosToolStripMenuItem;
        private ProgressBar progressBar1;
        private Label lblPorc;
    }
}