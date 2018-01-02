using System;
using System.Windows.Forms;
using Tobii.Interaction;

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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MVC instantization
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller();

            //MVC connections
            view.setModel(model);
            controller.setModel(model);
            controller.setView(view);

            //Form setup
            Form1 form = new Form1(model, view, controller);

            Application.Run(form);
        }
    }
}
