using H1_TheQueue.Model;
using H1_TheQueue.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheQueue.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> is the main controller of the program
    /// </summary>
    internal class MainController
    {
        public void Start()
        {
            Draw draw = new Draw();
            UserController userCtrl = new UserController();
            AssignmentController assignmentCtrl = new AssignmentController();

            // Runs the program forever
            while (true)
            {
                draw.FerryMenu();
                userCtrl.ChooseAssigment(assignmentCtrl);
            }
        }
    }
}
