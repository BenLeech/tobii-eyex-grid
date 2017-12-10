using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    public interface IInputState
    {
        void handleMouseDownEvent(object sender, MouseEventArgs e, Controller controller);

        void handleMouseUpEvent(object sender, MouseEventArgs e, Controller controller);

        void handleMouseMoveEvent(object sender, MouseEventArgs e, Controller controller);
    }
}
