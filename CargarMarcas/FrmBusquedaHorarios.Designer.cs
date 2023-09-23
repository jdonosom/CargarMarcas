namespace CargarMarcas
{
    partial class FrmBusquedaHorarios
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
            lstHorario = new ListView();
            colId = new ColumnHeader();
            colDescripcion = new ColumnHeader();
            SuspendLayout();
            // 
            // lstHorario
            // 
            lstHorario.Columns.AddRange(new ColumnHeader[] { colId, colDescripcion });
            lstHorario.FullRowSelect = true;
            lstHorario.GridLines = true;
            lstHorario.Location = new Point(12, 12);
            lstHorario.Name = "lstHorario";
            lstHorario.Size = new Size(540, 285);
            lstHorario.TabIndex = 0;
            lstHorario.UseCompatibleStateImageBehavior = false;
            lstHorario.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "Id";
            // 
            // colDescripcion
            // 
            colDescripcion.Text = "Descripción";
            colDescripcion.Width = 450;
            // 
            // FrmBusquedaHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 309);
            Controls.Add(lstHorario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBusquedaHorarios";
            ShowIcon = false;
            Load += FrmBusquedaHorarios_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstHorario;
        private ColumnHeader colId;
        private ColumnHeader colDescripcion;
    }
}