using System;
using System.Diagnostics;
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

        public void handleClearDrawingButtonClick(object sender, EventArgs e)
        {
            model.clearDrawing();
            model.gridPanel.Invalidate();
        }

        public void handleGridSnapCheckChange(object sender, EventArgs e)
        {
            model.gridSnap = (sender as CheckBox).Checked;
        }

        public void handleShowGridCheckStateChange(object sender, EventArgs e)
        {
            model.showGrid = (sender as CheckBox).Checked;
            model.gridPanel.Invalidate();
        }

        public void handleKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 't')
            {
                model.toggleGazeControl();
            }
        }

        public void handleKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                model.doMouseDown();
            }
        }

        public void handleKeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                model.doMouseUp();
            }
        }

    }
}
