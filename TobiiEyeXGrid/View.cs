using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    public class View
    {
        Model model;
        Controller controller;

        Pen bluePen;
        Pen greyPen;

        public View()
        {
            //instanstiate pens
            bluePen = new Pen(Brushes.Blue, 3);
            greyPen = new Pen(ColorTranslator.FromHtml("#b3b3b3"), 1);
        }

        public void setModel(Model aModel)
        {
            model = aModel;
        }

        public void setController(Controller aController)
        {
            controller = aController;
        }

        public void onDraw( object sender, PaintEventArgs e)
        {
            //create Graphics with AntiAlias
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //draw each grid line
            foreach (GridLine gridLine in model.gridLines)
            {
                g.DrawLine(greyPen, gridLine.x1, gridLine.y1, gridLine.x2, gridLine.y2);
            }

            //draw each vertex in the model
            foreach (Vertex vertex in model.vertices)
            {
                float x = vertex.x - vertex.radius;
                float y = vertex.y - vertex.radius;
                float height = vertex.radius + vertex.radius;
                float width = vertex.radius + vertex.radius;
                g.FillEllipse(Brushes.Gray, x, y, height, width);
            }

            //draw each edge
            foreach (Edge edge in model.edges)
            {
                g.DrawLine(bluePen, edge.x1, edge.y1, edge.x2, edge.y2);
            }
        }
    }
}
