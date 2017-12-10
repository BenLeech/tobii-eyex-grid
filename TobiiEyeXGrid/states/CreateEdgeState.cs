using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TobiiEyeXGrid.states;

namespace TobiiEyeXGrid
{
    public class CreateEdgeState : IInputState
    {
        public CreateEdgeState(object sender, MouseEventArgs e, Controller controller)
        {
            //find the vertex that the mouseDown event fired on
            Vertex startingVertex = controller.getModel().findVertexAtPosition(e.X, e.Y);

            //create an edge anchored to the starting vertex
            Edge edge = controller.getModel().createEdge(startingVertex.x, startingVertex.y, e.X, e.Y);
            controller.currentEdge = edge;

            //invalidate form's panel
            (sender as Panel).Invalidate();
        }

        public void handleMouseDownEvent(object sender, MouseEventArgs e, Controller controller){ }

        public void handleMouseMoveEvent(object sender, MouseEventArgs e, Controller controller)
        {
            //set state to EdgeMovingState
            controller.state = new EdgeMovingState(sender, e, controller);
        }

        public void handleMouseUpEvent(object sender, MouseEventArgs e, Controller controller)
        {
            controller.state = new InputReadyState();
        }
    }
}
