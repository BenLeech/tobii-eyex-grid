﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobiiEyeXGrid
{
    class Vertex
    {
        float x, y;
        float radius;
        int num;
        List<Edge> connectedStartEdges;
        List<Edge> connectedEndEdges;

        public Vertex(float newX, float newY, float newR, int newNum)
        {
            x = newX;
            y = newY;
            radius = newR;
            num = newNum;
            connectedStartEdges = new List<Edge>();
            connectedEndEdges = new List<Edge>();

        }

        public Boolean contains(float tX, float tY)
        {
            return tX >= x - radius && tX <= x + radius && tY >= y - radius && tY <= y - radius;
        }
    }
}
