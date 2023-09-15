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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargaMarca));
            lstArchivos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLimpiar = new Button();
            btnCargar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstArchivos
            // 
            lstArchivos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
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
            // FrmCargaMarca
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(btnCargar);
            Controls.Add(btnLimpiar);
            Controls.Add(lstArchivos);
            Controls.Add(panel1);
            Name = "FrmCargaMarca";
            Text = "FrmCargaMarca";
            DragDrop += FrmCargaMarca_DragDrop;
            DragEnter += FrmCargaMarca_DragEnter;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
    }
}