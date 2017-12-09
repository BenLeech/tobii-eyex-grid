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
    class View
    {
        Model model;
        Controller controller;
        Pen orangePen;
        Pen bluePen;

        public View()
        {
            orangePen = new Pen(Brushes.Orange);
            bluePen = new Pen(Brushes.Blue);
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

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (Edge edge in model.edges)
            {
                g.DrawLine(bluePen, edge.x1, edge.y1, edge.x2, edge.y2);
            }

            foreach(Vertex vertex in model.vertices)
            {
                float x = vertex.x - vertex.radius;
                float y = vertex.y - vertex.radius;
                float height = vertex.radius + vertex.radius;
                float width = vertex.radius + vertex.radius;
                g.FillEllipse(Brushes.Blue, x, y, height, width);
            }

            //g.Dispose();
        }
    }
}
