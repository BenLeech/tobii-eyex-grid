using System;
using System.Windows.Forms;
using TobiiEyeXGrid.states;

namespace TobiiEyeXGrid
{
    public class Controller
    {
        Model model;
        View view;

        public Vertex selectedVertex;
        public Edge currentEdge;

        public IInputState state = new InputReadyState();

        public Controller(){}

        public void setModel(Model aModel)
        {
            model = aModel;
        }

        public void setView(View aView)
        {
            view = aView;
        }

        public Model getModel()
        {
            return model;
        }

        public void handleMouseDown(object sender, MouseEventArgs e)
        {
            state.handleMouseDownEvent(sender, e, this);
        }

        public void handleMouseUp(object sender, MouseEventArgs e)
        {
            state.handleMouseUpEvent(sender, e, this);
        }

        public void handleMouseMove(object sender, MouseEventArgs e)
        {
            state.handleMouseMoveEvent(sender, e, this);
        }

        public void handleToggleGazeButtonClick(object sender, EventArgs e)
        {
            model.toggleGazeControl();
        }

    }
}
