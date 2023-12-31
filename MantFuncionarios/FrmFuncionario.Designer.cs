﻿namespace MantFuncionarios
{
    partial class FrmFuncionario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            label1 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombres = new TextBox();
            txtApePaterno = new TextBox();
            txtApeMaterno = new TextBox();
            txtRut = new TextBox();
            btnBuscaFuncionario = new Button();
            label5 = new Label();
            txtEmail = new TextBox();
            picFoto = new PictureBox();
            btnPhoto = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lsvTipoContratos = new ListView();
            lsvCargos = new ListView();
            btnCancelar = new Button();
            btnAceptar = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 143);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(678, 64);
            panel3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(64, 29);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 1;
            label6.Text = "Funcionario";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 91);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 0;
            label2.Text = "Rut";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 143);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 0;
            label3.Text = "Apellido paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 143);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 0;
            label4.Text = "Apellido materno";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(24, 161);
            txtNombres.MaxLength = 120;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(231, 23);
            txtNombres.TabIndex = 2;
            // 
            // txtApePaterno
            // 
            txtApePaterno.Location = new Point(261, 161);
            txtApePaterno.MaxLength = 60;
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(193, 23);
            txtApePaterno.TabIndex = 3;
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.Location = new Point(460, 161);
            txtApeMaterno.MaxLength = 60;
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(193, 23);
            txtApeMaterno.TabIndex = 4;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(24, 109);
            txtRut.MaxLength = 120;
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(99, 23);
            txtRut.TabIndex = 0;
            txtRut.KeyDown += txtRut_KeyDown;
            txtRut.KeyPress += txtRut_KeyPress;
            txtRut.KeyUp += txtRut_KeyUp;
            txtRut.Leave += txtRut_Leave;
            // 
            // btnBuscaFuncionario
            // 
            btnBuscaFuncionario.Location = new Point(129, 108);
            btnBuscaFuncionario.Name = "btnBuscaFuncionario";
            btnBuscaFuncionario.Size = new Size(28, 23);
            btnBuscaFuncionario.TabIndex = 1;
            btnBuscaFuncionario.Text = "?";
            btnBuscaFuncionario.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 199);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 0;
            label5.Text = "Correo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 217);
            txtEmail.MaxLength = 60;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 3;
            // 
            // picFoto
            // 
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(719, 12);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(154, 231);
            picFoto.TabIndex = 11;
            picFoto.TabStop = false;
            // 
            // btnPhoto
            // 
            btnPhoto.Image = (Image)resources.GetObject("btnPhoto.Image");
            btnPhoto.Location = new Point(223, 215);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(26, 26);
            btnPhoto.TabIndex = 12;
            btnPhoto.UseVisualStyleBackColor = true;
            btnPhoto.Click += btnPhoto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 199);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 0;
            label7.Text = "Fotografia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 199);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 0;
            label8.Text = "Tipo de contratos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(477, 197);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 0;
            label9.Text = "Cargos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(429, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(451, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // lsvTipoContratos
            // 
            lsvTipoContratos.CheckBoxes = true;
            lsvTipoContratos.Location = new Point(293, 217);
            lsvTipoContratos.Name = "lsvTipoContratos";
            lsvTipoContratos.Size = new Size(176, 64);
            lsvTipoContratos.TabIndex = 16;
            lsvTipoContratos.UseCompatibleStateImageBehavior = false;
            // 
            // lsvCargos
            // 
            lsvCargos.CheckBoxes = true;
            lsvCargos.Location = new Point(477, 215);
            lsvCargos.Name = "lsvCargos";
            lsvCargos.Size = new Size(176, 66);
            lsvCargos.TabIndex = 16;
            lsvCargos.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(579, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(498, 294);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FrmFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 329);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lsvCargos);
            Controls.Add(lsvTipoContratos);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(picFoto);
            Controls.Add(btnPhoto);
            Controls.Add(btnBuscaFuncionario);
            Controls.Add(txtApeMaterno);
            Controls.Add(txtEmail);
            Controls.Add(txtApePaterno);
            Controls.Add(txtRut);
            Controls.Add(txtNombres);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFuncionario";
            ShowIcon = false;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombres;
        private TextBox txtApePaterno;
        private TextBox txtApeMaterno;
        private TextBox txtRut;
        private Button btnBuscaFuncionario;
        private Label label5;
        private TextBox txtEmail;
        private PictureBox picFoto;
        private Button btnPhoto;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ListView lsvTipoContratos;
        private ListView lsvCargos;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}