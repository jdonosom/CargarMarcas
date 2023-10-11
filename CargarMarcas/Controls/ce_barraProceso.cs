using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace CargarMarcas.Controls
{
    public class Ce_ProgressBar : Control
    {
        private Rectangle BGShape;
        private int _Value = 30;
        private Pen P = new Pen(Color.FromArgb(20, 60, 71));
        private Color color1 = Color.FromArgb(133, 62, 254);

        [Category("Behavior")]
        public int Value
        {
            get => this._Value;
            set
            {
                this._Value = value;
                this.Invalidate();
            }
        }

        public Color PrcentageColor
        {
            get => this.color1;
            set
            {
                this.color1 = value;
                this.Invalidate();
            }
        }

        public Ce_ProgressBar()
        {
            this.Width = 300;
            this.Height = 13;
            this.Font = new Font("Consolas", 10f, FontStyle.Bold);
            this.DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.BGShape = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.WideUpwardDiagonal, this.color1, this.color1);
            if (this._Value <= 100 && this._Value >= 0)
            {
                graphics.DrawRectangle(this.P, this.BGShape);
                graphics.FillRectangle((Brush)hatchBrush, 2, 2, this.Width * this._Value / 100 - 4, this.Height - 4);
            }
            else
            {
                this._Value = 10;
                int num = (int)MessageBox.Show("Wrong value...!", "Blue Theme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                graphics.DrawRectangle(this.P, this.BGShape);
                graphics.FillRectangle((Brush)hatchBrush, 2, 2, this.Width * this._Value / 100 - 4, this.Height - 4);
            }
        }
    }
}
