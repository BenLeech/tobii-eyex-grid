using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobiiEyeXGrid
{
    class Edge
    {
        float x1, x2;
        float y1, y2;

        public Edge(float newX1, float newY1, float newX2, float newY2)
        {
            x1 = newX1;
            y1 = newY1;
            x2 = newX2;
            y2 = newY2;
        }
    }
}
