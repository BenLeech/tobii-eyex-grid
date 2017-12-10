﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    public class CreateEdgeState : IInputState
    {
        public void handleMouseDownEvent(object sender, MouseEventArgs e, Controller controller)
        {
            Vertex startingVertex = controller.getModel().findVertexAtPosition(e.X, e.Y);

            Edge edge = controller.getModel().createEdge(startingVertex.x, startingVertex.y, e.X, e.Y);
            controller.currentEdge = edge;
        }

        public void handleMouseUpEvent(object sender, MouseEventArgs e, Controller controller)
        {
            throw new NotImplementedException();
        }
    }
}
