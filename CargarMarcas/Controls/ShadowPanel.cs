namespace ShadowPanel
{
    using iFarmacia.Properties;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class ShadowPanel : Panel
    {
        private static Image shadowDownRight = (Image)new Bitmap(Resources.tshadowdownright);
        private static Image shadowDownLeft = (Image)new Bitmap( Resources.tshadowdownleft);
        private static Image shadowDown = (Image)new Bitmap( Resources.tshadowdown);
        private static Image shadowRight = (Image)new Bitmap( Resources.tshadowright);
        private static Image shadowTopRight = (Image)new Bitmap(Resources.tshadowtopright);

        private int shadowSize = 5;
        private int shadowMargin = 2;
        private Color _panelColor;
        private Color _borderColor;

        public Color PanelColor
        {
            get { return this._panelColor; }
            set { this._panelColor = value; }
        }

        public Color BorderColor
        {
            get { return this._borderColor; }
            set { this._borderColor = value; }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            TextureBrush textureBrush1 = new TextureBrush(ShadowPanel.shadowRight, WrapMode.Tile);
            TextureBrush textureBrush2 = new TextureBrush(ShadowPanel.shadowDown, WrapMode.Tile);
            textureBrush2.TranslateTransform(0.0f, (float)(this.Height - this.shadowSize));
            textureBrush1.TranslateTransform((float)(this.Width - this.shadowSize), 0.0f);
            Rectangle rect1 = new Rectangle(this.shadowSize + this.shadowMargin, this.Height - this.shadowSize, this.Width - (this.shadowSize * 2 + this.shadowMargin), this.shadowSize);
            Rectangle rect2 = new Rectangle(this.Width - this.shadowSize, this.shadowSize + this.shadowMargin, this.shadowSize, this.Height - (this.shadowSize * 2 + this.shadowMargin));
            graphics.FillRectangle((Brush)textureBrush2, rect1);
            graphics.FillRectangle((Brush)textureBrush1, rect2);
            graphics.DrawImage(ShadowPanel.shadowTopRight, new Rectangle(this.Width - this.shadowSize, this.shadowMargin, this.shadowSize, this.shadowSize));
            graphics.DrawImage(ShadowPanel.shadowDownRight, new Rectangle(this.Width - this.shadowSize, this.Height - this.shadowSize, this.shadowSize, this.shadowSize));
            graphics.DrawImage(ShadowPanel.shadowDownLeft, new Rectangle(this.shadowMargin, this.Height - this.shadowSize, this.shadowSize, this.shadowSize));
            Rectangle rect3 = new Rectangle(1, 1, this.Width - (this.shadowSize + 2), this.Height - (this.shadowSize + 2));
            Color panelColor = this.PanelColor;
            SolidBrush solidBrush = new SolidBrush(this._panelColor);
            graphics.FillRectangle((Brush)solidBrush, rect3);
            Pen pen = new Pen(this.BorderColor);
            graphics.DrawRectangle(pen, rect3);
            textureBrush2.Dispose();
            textureBrush1.Dispose();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
