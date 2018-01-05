using System.Windows.Forms;
using TobiiEyeXGrid.states;

namespace TobiiEyeXGrid
{
    public class EdgeMovingState : IInputState
    {

        Edge edge = null;

        public EdgeMovingState(object sender, MouseEventArgs e, Controller controller)
        {
            //set edge to controller's current edge
            edge = controller.currentEdge;
        }

        public void handleMouseDownEvent(object sender, MouseEventArgs e, Controller controller){}

        public void handleMouseMoveEvent(object sender, MouseEventArgs e, Controller controller)
        {
            //move the end point of the edge to mouse's position and invalidate form's grid panel
            controller.getModel().moveEdge(edge, e.X, e.Y);
            (sender as Panel).Invalidate();
        }

        public void handleMouseUpEvent(object sender, MouseEventArgs e, Controller controller)
        {
            //check to see if edge is over another vertex
            if (controller.getModel().contains(e.X, e.Y))
            {
                //find the vertex that the mouse up event fired on
                Vertex endVertex = controller.getModel().findVertexAtPosition(e.X, e.Y);

                //if the end vertex is the same as the start vertex, remove the current edge;
                if (endVertex.Equals(controller.selectedVertex))
                {
                    removeCurrentEdge(controller);
                }
                else //otherwise, reposition the edge to the centre of the endVertex
                {
                    controller.getModel().moveEdge(controller.currentEdge, endVertex.x, endVertex.y);
                }
            }
            else if (controller.getModel().gridSnap.Equals(true))
            {
                Vertex endVertex = controller.getModel().findClosestVertexAtPosition(e.X, e.Y);

                //if the end vertex is the same as the start vertex, remove the current edge;
                if (endVertex.Equals(controller.selectedVertex))
                {
                    removeCurrentEdge(controller);
                }
                else //otherwise, reposition the edge to the centre of the endVertex
                {
                    controller.getModel().moveEdge(controller.currentEdge, endVertex.x, endVertex.y);
                }
            }
            else //remove the current edge if it doesn't end over another vertex;
            {
                removeCurrentEdge(controller);
            }

            //reset current edge/vertex, invalidate, and set state back to InputReady
            controller.selectedVertex = null;
            controller.currentEdge = null;
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
