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

            //Tobii setup
            Host host = new Host();

            //Form setup
            Form1 form = new Form1(model, view, controller);

            Application.Run(form);
        }
    }
}
