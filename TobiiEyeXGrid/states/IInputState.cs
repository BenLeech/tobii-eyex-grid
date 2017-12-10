using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    public interface IInputState
    {
        void handleMouseDownEvent(object sender, MouseEventArgs e, Controller controller);

        void handleMouseUpEvent(object sender, MouseEventArgs e, Controller controller);
    }
}
