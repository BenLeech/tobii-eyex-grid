using System;

namespace TobiiEyeXGrid
{
    public class Vertex
    {
        public float x, y;
        public float radius;

        public Vertex(float newX, float newY, float newR)
        {
            x = newX;
            y = newY;
            radius = newR;
        }

        public Boolean contains(float tX, float tY)
        {
            return (tX >= x - radius) && (tX <= x + radius) && (tY >= y - radius) && (tY <= y + radius);
        }
    }
}
