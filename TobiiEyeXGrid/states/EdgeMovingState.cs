using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    class EdgeMovingState : IInputState
    {
        public void handleMouseEvent(object sender, MouseEventArgs e, Controller controller)
        {
            Edge edge = controller.currentEdge;
            controller.getModel().moveEdge(edge, e.X, e.Y);
        }
    }
}
