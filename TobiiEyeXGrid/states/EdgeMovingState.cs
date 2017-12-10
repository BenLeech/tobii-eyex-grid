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
    public class EdgeMovingState : IInputState
    {

        Edge edge = null;

        public EdgeMovingState(object sender, MouseEventArgs e, Controller controller)
        {
            edge = controller.currentEdge;
        }

        public void handleMouseDownEvent(object sender, MouseEventArgs e, Controller controller)
        {
        }

        public void handleMouseMoveEvent(object sender, MouseEventArgs e, Controller controller)
        {
            controller.getModel().moveEdge(edge, e.X, e.Y);
        }

        public void handleMouseUpEvent(object sender, MouseEventArgs e, Controller controller)
        {
            //check to see if edge is over another vertex
            if (controller.getModel().contains(e.X, e.Y))
            {
                Vertex endVertex = controller.getModel().findVertexAtPosition(e.X, e.Y);

                if (endVertex.Equals(controller.selectedVertex))
                {
                    removeCurrentEdge(controller);
                }
                else
                {
                    controller.getModel().moveEdge(controller.currentEdge, endVertex.x, endVertex.y);
                }

            }
            else
            {
                removeCurrentEdge(controller);
            }

            controller.selectedVertex = null;
            controller.currentEdge = null;
            controller.state = new InputReadyState();
        }

        private void removeCurrentEdge(Controller controller)
        {
            controller.getModel().edges.Remove(controller.currentEdge);
        }
    }
}
