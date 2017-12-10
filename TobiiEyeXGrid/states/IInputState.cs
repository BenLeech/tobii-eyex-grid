using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    interface IInputState
    {
        void handleMouseEvent(object sender, MouseEventArgs e, Controller controller);
    }
}
