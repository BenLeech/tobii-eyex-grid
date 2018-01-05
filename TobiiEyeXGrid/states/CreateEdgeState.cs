using System.Windows.Forms;
using TobiiEyeXGrid.states;

namespace TobiiEyeXGrid
{
    public class CreateEdgeState : IInputState
    {
        public CreateEdgeState(object sender, MouseEventArgs e, Controller controller)
        {
            Vertex startingVertex = controller.selectedVertex;

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
            removeCurrentEdge(controller);
            controller.currentEdge = null;
            controller.selectedVertex = null;
            (sender as Panel).Invalidate();
            controller.state = new InputReadyState();
        }

        //removes the current edge from the model
        private void removeCurrentEdge(Controller controller)
        {
            controller.getModel().edges.Remove(controller.currentEdge);
        }
    }
}
