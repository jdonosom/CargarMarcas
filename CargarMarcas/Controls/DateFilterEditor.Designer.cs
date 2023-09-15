namespace iFarmacia.Controls
{
    partial class DateFilterEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._chkCalendar = new System.Windows.Forms.CheckBox();
            this._calendar = new System.Windows.Forms.MonthCalendar();
            this._chkYesterday = new System.Windows.Forms.CheckBox();
            this._chkLastMonth = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _chkCalendar
            // 
            this._chkCalendar.AutoSize = true;
            this._chkCalendar.Location = new System.Drawing.Point(2, 0);
            this._chkCalendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chkCalendar.Name = "_chkCalendar";
            this._chkCalendar.Size = new System.Drawing.Size(99, 17);
            this._chkCalendar.TabIndex = 0;
            this._chkCalendar.Text = "Filtrar por fecha";
            this._chkCalendar.UseVisualStyleBackColor = true;
            this._chkCalendar.CheckedChanged += new System.EventHandler(this._chkCalendar_CheckedChanged);
            // 
            // _calendar
            // 
            this._calendar.Location = new System.Drawing.Point(16, 20);
            this._calendar.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this._calendar.MaxSelectionCount = 30;
            this._calendar.Name = "_calendar";
            this._calendar.ShowToday = false;
            this._calendar.TabIndex = 1;
            this._calendar.TitleBackColor = System.Drawing.SystemColors.ControlDark;
            this._calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this._calendar_DateSelected);
            // 
            // _chkYesterday
            // 
            this._chkYesterday.AutoSize = true;
            this._chkYesterday.Location = new System.Drawing.Point(2, 193);
            this._chkYesterday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chkYesterday.Name = "_chkYesterday";
            this._chkYesterday.Size = new System.Drawing.Size(47, 17);
            this._chkYesterday.TabIndex = 0;
            this._chkYesterday.Text = "Ayer";
            this._chkYesterday.UseVisualStyleBackColor = true;
            // 
            // _chkLastMonth
            // 
            this._chkLastMonth.AutoSize = true;
            this._chkLastMonth.Location = new System.Drawing.Point(2, 210);
            this._chkLastMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._chkLastMonth.Name = "_chkLastMonth";
            this._chkLastMonth.Size = new System.Drawing.Size(85, 17);
            this._chkLastMonth.TabIndex = 0;
            this._chkLastMonth.Text = "Mes Pasado";
            this._chkLastMonth.UseVisualStyleBackColor = true;
            // 
            // DateFilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._chkCalendar);
            this.Controls.Add(this._calendar);
            this.Controls.Add(this._chkYesterday);
            this.Controls.Add(this._chkLastMonth);
            this.Name = "DateFilterEditor";
            this.Size = new System.Drawing.Size(271, 242);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _chkCalendar;
        private System.Windows.Forms.MonthCalendar _calendar;
        private System.Windows.Forms.CheckBox _chkYesterday;
        private System.Windows.Forms.CheckBox _chkLastMonth;
    }
}
