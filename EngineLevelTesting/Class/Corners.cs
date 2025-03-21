using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineLevelTesting.Class
{
    class Corners
    {

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();

            path.StartFigure();

            // top left corner
            path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180f, 90f);
            path.AddLine(rect.Left + radius, rect.Top, rect.Right - radius, rect.Top);

            // top right corner
            path.AddArc(rect.Right - 2 * radius, rect.Top, radius * 2, radius * 2, 270f, 90f);
            path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius);

            // bottom right corner
            path.AddArc(rect.Right - 2 * radius, rect.Bottom - 2 * radius, radius * 2, radius * 2, 0f, 90f);
            path.AddLine(rect.Right - radius, rect.Bottom, rect.Left + radius, rect.Bottom);

            // bottom left corner
            path.AddArc(rect.Left, rect.Bottom - 2 * radius, radius * 2, radius * 2, 90f, 90f);
            path.CloseFigure();

            return path;
        }

        public void RoundedForms1(Form obj)
        {
            var path = GetRoundedRectangle(obj.ClientRectangle, 20);
            obj.Region = new Region(path);
        }

        public void RoundedFormsDocker(Form obj)
        {
            var path = GetRoundedRectangle(obj.ClientRectangle, 10);
            obj.Region = new Region(path);
        }


        public void RoundedPanel(Panel obj)
        {
            var path = GetRoundedRectangle(obj.ClientRectangle, 15);
            obj.Region = new Region(path);
        }

        public void RoundedPanelDocker(Panel obj)
        {
            var path = GetRoundedRectangle(obj.ClientRectangle, 10);
            obj.Region = new Region(path);
        }

        public void RoundDataGridView(DataGridView obj)
        {
            var path = GetRoundedRectangle(obj.ClientRectangle, 15);
            obj.Region = new Region(path);
        }

        public void RoundedPanelModuleName(Panel obj)
        {
            var path = GetRoundedRectangle(obj.ClientRectangle, 10);
            obj.Region = new Region(path);
        }
        public void CirclePanel(Panel obj)
        {
            var path = GetRoundedRectangle(obj.ClientRectangle, 100);
            obj.Region = new Region(path);
        }


        public void RoundedPaneltextbox(Panel obj)
        {
            var path = GetRoundedRectangle(obj.ClientRectangle, 20);
            obj.Region = new Region(path);
        }


    }
}
