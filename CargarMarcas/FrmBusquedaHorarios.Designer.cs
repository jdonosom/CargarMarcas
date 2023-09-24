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
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lstHorario
            // 
            lstHorario.Columns.AddRange(new ColumnHeader[] { colId, colDescripcion });
            lstHorario.FullRowSelect = true;
            lstHorario.GridLines = true;
            lstHorario.Location = new Point(12, 12);
            lstHorario.MultiSelect = false;
            lstHorario.Name = "lstHorario";
            lstHorario.ShowItemToolTips = true;
            lstHorario.Size = new Size(540, 285);
            lstHorario.TabIndex = 0;
            lstHorario.UseCompatibleStateImageBehavior = false;
            lstHorario.View = View.Details;
            lstHorario.DoubleClick += lstHorario_DoubleClick;
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
            // btnAceptar
            // 
            btnAceptar.Location = new Point(396, 307);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(477, 307);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmBusquedaHorarios
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(564, 339);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
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
        private Button btnAceptar;
        private Button btnCancelar;
    }
}