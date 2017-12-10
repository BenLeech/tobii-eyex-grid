using System;
using System.Windows.Forms;

namespace TobiiEyeXGrid
{
    static class TobiiEyexGridApplication
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //MVC instantization
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller();

            //MVC connections
            view.setModel(model);
            controller.setModel(model);
            controller.setView(view);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(model, view, controller));
        }
    }
}
