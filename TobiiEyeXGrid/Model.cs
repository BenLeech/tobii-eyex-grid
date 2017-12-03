using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobiiEyeXGrid
{
    class Model
    {
        List<Vertex> vertices;
        List<Edge> edges;

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
            foreach(var vertex in vertices)
            {
                if (vertex.contains(x, y))
                {
                    found = true;
                }
            }
            return found;
        }
    }
}
