using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid.states
{
    class InputReadyState : IInputState
    {
        public void handleMouseDownEvent(object sender, MouseEventArgs e, Controller controller)
        {
            //if mouse is over a vertex, set as current vertex and go to CreateEdgeState
            if(controller.getModel().contains(e.X, e.Y))
            {
                controller.selectedVertex = controller.getModel().findVertexAtPosition(e.X, e.Y);
                controller.state = new CreateEdgeState(sender, e, controller);
            }
        }

        public void handleMouseMoveEvent(object sender, MouseEventArgs e, Controller controller)
        {
        }

        public void handleMouseUpEvent(object sender, MouseEventArgs e, Controller controller)
        {
            controller.selectedVertex = null;
            controller.currentEdge = null;
        }
    }
}
