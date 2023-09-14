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
    /// Class <see cref="AssignmentController"/> controls assigments
    /// </summary>
    internal class AssignmentController
    {
        private Queue<Car> _ferryQueue = new Queue<Car>();

        /// <summary>
        /// Adds car to queue
        /// </summary>
        public void AddCar()
        {
            Draw draw = new Draw();

            UserInput userInput = new UserInput();

            // First Name of Owner
            draw.AskFirstName();
            string firstName = userInput.GetInputText();

            // Last Name of Owner
            draw.AskLastName();
            string lastName = userInput.GetInputText();

            // Phone Number of Owner
            draw.AskPhoneNumber();
            string phoneNumber = userInput.GetInputText();

            // Email of Owner
            draw.AskEmail();
            string email = userInput.GetInputText();

            // License Plate of Car
            draw.AskLicensePlate();
            string licensePlate = userInput.GetInputText();

            Person person = new Person(firstName, lastName, phoneNumber, email);
            Car car = new Car(licensePlate, person);

            // Adds car to queue
            _ferryQueue.Enqueue(car);
        }

        /// <summary>
        /// Removes car from queue
        /// </summary>
        public void RemoveCar()
        {
            Draw draw = new Draw();
            draw.DeleteCar();

            UserInput userInput = new UserInput();
            ConsoleKey key = userInput.GetPressedKey();

            // Removes car from queue if Y is pressed
            if(key == ConsoleKey.Y)
            {
                _ferryQueue.Dequeue();
            }
        }

        /// <summary>
        /// Show the length of the queue to the user
        /// </summary>
        public void QueueLength()
        {
            byte carAmount = (byte)_ferryQueue.Count;

            Draw draw = new Draw();
            draw.ShowNumberOfCars(carAmount);

            UserInput userInput = new UserInput();
            userInput.GetPressedKey();
        }

        /// <summary>
        /// Show the last and first car in the queue to the user
        /// </summary>
        public void LastAndFirstCar()
        {
            Car firstCar = _ferryQueue.Peek();
            Car lastCar = _ferryQueue.ToArray()[_ferryQueue.Count - 1];

            // First and Last car
            Draw draw = new Draw();
            draw.ShowFirstAndLastCar(firstCar, lastCar);

            // Wait for user input
            UserInput userInput = new UserInput();
            userInput.GetPressedKey();
        }

        /// <summary>
        /// Finds a car by license plate
        /// </summary>
        public void FindCar()
        {
            UserInput userInput = new UserInput();
            Draw draw = new Draw();

            // License Plate of Car
            draw.FindCar();
            string licensePlate = userInput.GetInputText();

            // Finds the car by license plate
            bool queueHasCar = false;
            foreach(Car car in _ferryQueue)
            {
                if(car.LicensePlate == licensePlate)
                {
                    queueHasCar = true;
                }
            }

            draw.CarFound(queueHasCar);
            userInput.GetPressedKey();
        }
    }
}
