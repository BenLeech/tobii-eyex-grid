using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid.states
{
    class EdgeUpState : IInputState
    {
        public void handleMouseEvent(object sender, MouseEventArgs e, Controller controller)
        {
            //check to see if edge is over another vertex
            if(controller.getModel().contains(e.X, e.Y))
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
        }

        private void removeCurrentEdge(Controller controller)
        {
            controller.getModel().edges.Remove(controller.currentEdge);
        }
    }
}
