using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularButton
{
    public class MyButton : Control
    {
        //設定Button 形狀屬性 
        public enum Fillstyle
        {
            Ellipse,
            Rectangle
        }
        private Fillstyle _mystyle;
        private Color _color;
        private Color _顏色;
        [Category("我的自訂選項"), Description("........")]
        public Color 顏色
        {
            get
            { return _顏色; }
            set
            {
                _顏色 = value;
                this.Invalidate();
            }
        }

        [Category("我的自訂選項"), Description("........")]
        public Fillstyle 形狀
        {
            get
            { return _mystyle; }
            set
            { _mystyle = value; }
        }
        [Category("我的自訂選項"), Description("........")]
        public Color 點擊顏色 { get; set; }

        public MyButton()
        {
            this.Width = 200;
            this.Height = 200;
            this.形狀 = Fillstyle.Ellipse;
            base.Font = new Font("微軟正黑體", 9, FontStyle.Bold);
            this.MouseDown += delegate { myPen = new Pen(Color.Black, 3); };
            //this.Paint += delegate { this.dracir(); };
        }
        Pen myPen = new Pen(Color.Black, 2);
        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush = new SolidBrush(this._顏色);
            switch (形狀)
            {
                case Fillstyle.Ellipse:
                    e.Graphics.ScaleTransform(0.99f, 0.99f);
                    e.Graphics.FillEllipse(brush, 2, 2, this.Width , this.Height);
                    e.Graphics.DrawEllipse(myPen, new Rectangle(2, 2, this.Width - 3, this.Height - 3));
                    break;
                case Fillstyle.Rectangle:
                    e.Graphics.FillRectangle(brush, 2, 2, this.Width, this.Height);
                    e.Graphics.DrawRectangle(myPen, new Rectangle(2, 2, this.Width - 3, this.Height - 3));
                    break;
            }
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point(this.Width + 3, this.Height / 2), this.ForeColor, flags);
            base.OnPaint(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this._color = this._顏色;
            base.OnMouseDown(e);
            this.顏色 = 點擊顏色;
            this.Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.顏色 = this._color;
            myPen = new Pen(Color.Black, 2);
            this.Invalidate();
        }
    }
}
