using H1_TheQueue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheQueue.Controller
{
    /// <summary>
    /// Class <see cref="UserController"/> controls program, but uses the user to do so
    /// </summary>
    internal class UserController
    {
        public void ChooseAssigment(AssignmentController assignmentCtrl)
        {
            UserInput userInput = new UserInput();

            ConsoleKey key = userInput.GetPressedKey();

            // Runs until the user presses a valid key
            switch (key)
            {
                case ConsoleKey.D1:
                    assignmentCtrl.AddCar();
                    break;
                case ConsoleKey.D2:
                    assignmentCtrl.RemoveCar();
                    break;
                case ConsoleKey.D3:
                    assignmentCtrl.QueueLength();
                    break;
                case ConsoleKey.D4:
                    assignmentCtrl.LastAndFirstCar();
                    break;
                case ConsoleKey.D5:
                    assignmentCtrl.FindCar();
                    break;
                case ConsoleKey.D6:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
