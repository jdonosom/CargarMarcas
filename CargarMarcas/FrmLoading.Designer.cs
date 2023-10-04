namespace CargarMarcas
{
    partial class FrmLoading
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
            ce_ProgressBar1 = new Controls.Ce_ProgressBar();
            ce_Label1 = new Controls.Ce_Label();
            ce_Label2 = new Controls.Ce_Label();
            SuspendLayout();
            // 
            // ce_ProgressBar1
            // 
            ce_ProgressBar1.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ce_ProgressBar1.Location = new Point(15, 77);
            ce_ProgressBar1.Name = "ce_ProgressBar1";
            ce_ProgressBar1.PrcentageColor = Color.FromArgb(133, 62, 254);
            ce_ProgressBar1.Size = new Size(490, 23);
            ce_ProgressBar1.TabIndex = 1;
            ce_ProgressBar1.Text = "ce_ProgressBar1";
            ce_ProgressBar1.Value = 30;
            // 
            // ce_Label1
            // 
            ce_Label1.AutoSize = true;
            ce_Label1.BackColor = Color.Transparent;
            ce_Label1.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ce_Label1.ForeColor = Color.FromArgb(133, 62, 254);
            ce_Label1.Location = new Point(119, 29);
            ce_Label1.Name = "ce_Label1";
            ce_Label1.Size = new Size(224, 32);
            ce_Label1.TabIndex = 2;
            ce_Label1.Text = "Cargando datos";
            // 
            // ce_Label2
            // 
            ce_Label2.AutoSize = true;
            ce_Label2.BackColor = Color.Transparent;
            ce_Label2.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            ce_Label2.ForeColor = Color.FromArgb(133, 62, 254);
            ce_Label2.Location = new Point(349, 29);
            ce_Label2.Name = "ce_Label2";
            ce_Label2.Size = new Size(44, 32);
            ce_Label2.TabIndex = 2;
            ce_Label2.Text = "0%";
            // 
            // FrmLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 231, 250);
            ClientSize = new Size(517, 131);
            Controls.Add(ce_Label2);
            Controls.Add(ce_Label1);
            Controls.Add(ce_ProgressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoading";
            Shown += FrmLoading_Shown;
            Enter += FrmLoading_Enter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.Ce_ProgressBar ce_ProgressBar1;
        private Controls.Ce_Label ce_Label1;
        private Controls.Ce_Label ce_Label2;
    }
}