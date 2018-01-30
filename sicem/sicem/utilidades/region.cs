using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sicem
{
    class region
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Region Circle(int width, int height)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, width - 3, height - 3);
            //using (var gp = new GraphicsPath())
            //{
            //    gp.AddEllipse(new Rectangle(0, 0, width - 1, height - 1));
                return new Region(gp);
            //}
        }

        public Region RoundBorder(int width, int height, int border)
        {
            return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, width, height, border, border));
        }

        //public GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
        //{
        //    Width -= 1;
        //    Height -= 1;
        //    Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
        //    GraphicsPath GP = new GraphicsPath();
        //    int EndArcWidth = Curve * 2;
        //    GP.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, EndArcWidth, EndArcWidth), -180, 90);
        //    GP.AddArc(new Rectangle(Rectangle.Width - EndArcWidth + Rectangle.X, Rectangle.Y, EndArcWidth, EndArcWidth), -90, 90);
        //    GP.AddArc(new Rectangle(Rectangle.Width - EndArcWidth + Rectangle.X, Rectangle.Height - EndArcWidth + Rectangle.Y, EndArcWidth, EndArcWidth), 0, 90);
        //    GP.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - EndArcWidth + Rectangle.Y, EndArcWidth, EndArcWidth), 90, 90);
        //    GP.AddLine(new Point(Rectangle.X, Rectangle.Height - EndArcWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
        //    return GP;
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    LinearGradientBrush LGB = default(LinearGradientBrush);
        //    GraphicsPath GP = default(GraphicsPath);

        //    e.Graphics.Clear(BackColor);
        //    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        //    // Create a curvy border
        //    GP = RoundRectangle.RoundRect(0, 0, Width - 1, Height - 1, 5);
        //    // Fills the body of the rectangle with a gradient
        //    LGB = new LinearGradientBrush(ClientRectangle, Color.FromArgb(241, 241, 241), Color.FromArgb(241, 241, 241), 90f);

        //    e.Graphics.SetClip(GP);
        //    e.Graphics.FillRectangle(LGB, ClientRectangle);
        //    e.Graphics.ResetClip();

        //    // Draw rectangle border
        //    e.Graphics.DrawPath(new Pen(Color.FromArgb(204, 204, 204)), GP);
        //    // Draw string
        //    e.Graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(142, 142, 142)), new Rectangle(3, 0, Width - 20, Height), new StringFormat
        //    {
        //        LineAlignment = StringAlignment.Center,
        //        Alignment = StringAlignment.Near
        //    });

        //    // Draw the dropdown arrow
        //    e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2), new Point(Width - 18, 10), new Point(Width - 14, 14));
        //    e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2), new Point(Width - 14, 14), new Point(Width - 10, 10));
        //    e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160)), new Point(Width - 14, 15), new Point(Width - 14, 14));

        //    GP.Dispose();
        //    LGB.Dispose();
        //}
    }
}
