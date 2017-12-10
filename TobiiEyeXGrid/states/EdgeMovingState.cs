using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    public class EdgeMovingState : IInputState
    {
        public void handleMouseDownEvent(object sender, MouseEventArgs e, Controller controller)
        {
            Edge edge = controller.currentEdge;
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
        }

        private void removeCurrentEdge(Controller controller)
        {
            controller.getModel().edges.Remove(controller.currentEdge);
        }
    }
}
