using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicem
{
    class drag
    {
        Bunifu.Framework.UI.Drag dragable = new Bunifu.Framework.UI.Drag();

        public void MouseDown(object sender, MouseEventArgs e)
        {
            Panel p = sender as Panel;
            dragable.Grab(p.FindForm());
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            dragable.Release();
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            dragable.MoveObject();
        }

        public void setDragable(Panel p)
        {
            p.MouseDown += MouseDown;
            p.MouseUp += MouseUp;
            p.MouseMove += MouseMove;
        }
    }
}
