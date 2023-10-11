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
            envioDeTicketDeMarcaToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MenuReports.SuspendLayout();
            SuspendLayout();
            // 
            // lstArchivos
            // 
            lstArchivos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstArchivos.FullRowSelect = true;
            lstArchivos.Location = new Point(9, 110);
            lstArchivos.Name = "lstArchivos";
            lstArchivos.Size = new Size(268, 438);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 66);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 32);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 1;
            label1.Text = "Carga de marcaciones";
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
            // btnLimpiar
            // 
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(9, 72);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(32, 32);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Image = (Image)resources.GetObject("btnCargar.Image");
            btnCargar.Location = new Point(245, 72);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(32, 32);
            btnCargar.TabIndex = 7;
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtBuffer
            // 
            txtBuffer.Location = new Point(287, 114);
            txtBuffer.Multiline = true;
            txtBuffer.Name = "txtBuffer";
            txtBuffer.ScrollBars = ScrollBars.Vertical;
            txtBuffer.Size = new Size(501, 434);
            txtBuffer.TabIndex = 8;
            // 
            // button1
            // 
            button1.ContextMenuStrip = MenuReports;
            button1.Location = new Point(646, 83);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 9;
            button1.Text = "Reportes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuReports
            // 
            MenuReports.ImageScalingSize = new Size(20, 20);
            MenuReports.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, envioDeTicketDeMarcaToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, adignaciónHorariosToolStripMenuItem, toolStripMenuItem4, mantenciónDeHorariosToolStripMenuItem, mantenciónDeFuncionariosToolStripMenuItem, mantenciónDeDispositivosToolStripMenuItem, asignaciónDispositivosToolStripMenuItem });
            MenuReports.Name = "contextMenuStrip1";
            MenuReports.Size = new Size(241, 214);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(240, 22);
            toolStripMenuItem1.Text = "Funcionario sin marca entrada";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(240, 22);
            toolStripMenuItem2.Text = "Funcionario sin marca de salida";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(237, 6);
            // 
            // adignaciónHorariosToolStripMenuItem
            // 
            adignaciónHorariosToolStripMenuItem.Name = "adignaciónHorariosToolStripMenuItem";
            adignaciónHorariosToolStripMenuItem.Size = new Size(240, 22);
            adignaciónHorariosToolStripMenuItem.Text = "Asignación horarios";
            adignaciónHorariosToolStripMenuItem.Click += adignaciónHorariosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(237, 6);
            // 
            // mantenciónDeHorariosToolStripMenuItem
            // 
            mantenciónDeHorariosToolStripMenuItem.Name = "mantenciónDeHorariosToolStripMenuItem";
            mantenciónDeHorariosToolStripMenuItem.Size = new Size(240, 22);
            mantenciónDeHorariosToolStripMenuItem.Text = "Mantención de horarios";
            mantenciónDeHorariosToolStripMenuItem.Click += mantenciónDeHorariosToolStripMenuItem_Click;
            // 
            // mantenciónDeFuncionariosToolStripMenuItem
            // 
            mantenciónDeFuncionariosToolStripMenuItem.Name = "mantenciónDeFuncionariosToolStripMenuItem";
            mantenciónDeFuncionariosToolStripMenuItem.Size = new Size(240, 22);
            mantenciónDeFuncionariosToolStripMenuItem.Text = "Mantención de Funcionarios";
            mantenciónDeFuncionariosToolStripMenuItem.Click += mantenciónDeFuncionariosToolStripMenuItem_Click;
            // 
            // mantenciónDeDispositivosToolStripMenuItem
            // 
            mantenciónDeDispositivosToolStripMenuItem.Name = "mantenciónDeDispositivosToolStripMenuItem";
            mantenciónDeDispositivosToolStripMenuItem.Size = new Size(240, 22);
            mantenciónDeDispositivosToolStripMenuItem.Text = "Mantención de dispositivos";
            // 
            // asignaciónDispositivosToolStripMenuItem
            // 
            asignaciónDispositivosToolStripMenuItem.Name = "asignaciónDispositivosToolStripMenuItem";
            asignaciónDispositivosToolStripMenuItem.Size = new Size(240, 22);
            asignaciónDispositivosToolStripMenuItem.Text = "Asignación Dispositivos";
            asignaciónDispositivosToolStripMenuItem.Click += asignaciónDispositivosToolStripMenuItem_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(47, 87);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(192, 15);
            progressBar1.TabIndex = 10;
            // 
            // lblPorc
            // 
            lblPorc.AutoSize = true;
            lblPorc.BackColor = Color.Transparent;
            lblPorc.Location = new Point(138, 69);
            lblPorc.Name = "lblPorc";
            lblPorc.Size = new Size(23, 15);
            lblPorc.TabIndex = 11;
            lblPorc.Text = "0%";
            lblPorc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // envioDeTicketDeMarcaToolStripMenuItem
            // 
            envioDeTicketDeMarcaToolStripMenuItem.Name = "envioDeTicketDeMarcaToolStripMenuItem";
            envioDeTicketDeMarcaToolStripMenuItem.Size = new Size(240, 22);
            envioDeTicketDeMarcaToolStripMenuItem.Text = "Envio de ticket de marca";
            envioDeTicketDeMarcaToolStripMenuItem.Click += envioDeTicketDeMarcaToolStripMenuItem_Click;
            // 
            // FrmCargaMarca
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(lblPorc);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(txtBuffer);
            Controls.Add(btnCargar);
            Controls.Add(btnLimpiar);
            Controls.Add(lstArchivos);
            Controls.Add(panel1);
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
        private ToolStripMenuItem envioDeTicketDeMarcaToolStripMenuItem;
    }
}