using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    class Model
    {
        public List<Vertex> vertices;
        public List<Edge> edges;

        public Model()
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();
        }

        public void createVertex(float x, float y, float r)
        {
            vertices.Add(new Vertex(x, y, r));
        }

        public Edge createEdge(float x1, float y1, float x2, float y2)
        {
            Edge edge = new Edge(x1, y1, x2, y2);
            edges.Add(edge);
            return edge;
        }

        public Boolean contains(float x, float y)
        {
            Boolean found = false;
            foreach(Vertex vertex in vertices)
            {
                if (vertex.contains(x, y))
                {
                    found = true;
                }
            }
            return found;
        }

        public void generateGrid(Panel panel)
        {
            for(int i=0; i<10; i++)
            {
                createVertex(0 + (i * 50), 50, 5);
            }
        }

    }
}
