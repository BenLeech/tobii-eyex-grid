using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Tobii.Interaction;

namespace TobiiEyeXGrid
{
    public class Model
    {
        public Boolean gazeEnabled;

        public List<Vertex> vertices;
        public List<Edge> edges;
        public List<GridLine> gridLines;

        const int GRID_SPACING = 40;
        const int VERTEX_RADIUS = 5;

        public Model()
        {
            //instantiate lists
            vertices = new List<Vertex>();
            edges = new List<Edge>();
            gridLines = new List<GridLine>();

            //create data stream
            createGazeDataStream();
        }

        //create a new vertex and add it to the list of vertices
        public void createVertex(float x, float y, float r)
        {
            vertices.Add(new Vertex(x, y, r));
        }

        //create a new edge and add it to the list of edges
        public Edge createEdge(float x1, float y1, float x2, float y2)
        {
            Edge edge = new Edge(x1, y1, x2, y2);
            edges.Add(edge);
            return edge;
        }

        //create a new grid line and add it to the list of grid lines
        public void createGridLine(float x1, float y1, float x2, float y2)
        {
            gridLines.Add(new GridLine(x1, y1, x2, y2));
        }

        //move the end points of the edge passed in to parameters
        public void moveEdge(Edge edge, float newX, float newY)
        {
            edge.x2 = newX;
            edge.y2 = newY;
        }

        //check if parameter position is over any vertices
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

        //find the vertex at the given position
        public Vertex findVertexAtPosition(float x, float y)
        {
            Vertex foundVertex = null;

            foreach(Vertex vertex in vertices){
                if(vertex.contains(x, y))
                {
                    foundVertex = vertex;
                }
            }

            return foundVertex;
        }

        //creates new vertices and grid lines
        public void generateGrid(Panel panel)
        {
            for(int i=0; i<32; i++)
            {
                for(int k=0; k<16; k++)
                {
                    createVertex((i* GRID_SPACING), (k * GRID_SPACING), VERTEX_RADIUS);
                    createGridLine((i * GRID_SPACING), (k * GRID_SPACING), (i * GRID_SPACING) + GRID_SPACING, (k * GRID_SPACING));
                    createGridLine((i * GRID_SPACING), (k * GRID_SPACING), (i * GRID_SPACING), (k * GRID_SPACING) + GRID_SPACING);
                }
            }

        }

        public void toggleGazeControl()
        {
            gazeEnabled = !gazeEnabled;
        }

        private void createGazeDataStream()
        {
            Host host = new Host();
            var gazePointDataStream = host.Streams.CreateGazePointDataStream();
            gazePointDataStream.GazePoint((x, y, _) => {
                if (gazeEnabled)
                {
                    Cursor.Position = new Point((int)x, (int)y);
                }
            });
        }

    }
}
