using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    class CreateEdgeState : IInputState
    {
        public void handleMouseEvent(object sender, MouseEventArgs e, Controller controller)
        {
            Vertex startingVertex = controller.getModel().findVertexAtPosition(e.X, e.Y);

            Edge edge = controller.getModel().createEdge(startingVertex.x, startingVertex.y, e.X, e.Y);
            controller.currentEdge = edge;
            
        }
    }
}
