using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    class View
    {

        Graphics graphics;
        Form form;
        Model model;
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

        public void onDraw(PaintEventArgs e)
        {
            foreach(Edge edge in model.edges)
            {
                graphics.DrawLine(bluePen, edge.x1, edge.y1, edge.x2, edge.y2);
            }

            foreach(Vertex vertex in model.vertices)
            {
                float x = vertex.x - vertex.radius;
                float y = vertex.y - vertex.radius;
                float height = vertex.radius + vertex.radius;
                float width = vertex.radius + vertex.radius;
                graphics.DrawEllipse(bluePen, x, y, height, width);
            }
        }
    }
}
