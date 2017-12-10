using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    public class Controller
    {
        Model model;
        View view;

        Vertex selected;
        Edge currentEdge;

        public Controller()
        {

        }

        public void setModel(Model aModel)
        {
            model = aModel;
        }

        public void setView(View aView)
        {
            view = aView;
        }

        public void handleMouseDown(object sender, MouseEventArgs e)
        {
            if(model.contains(e.X, e.Y))
            {
                
            }
        }

    }
}
