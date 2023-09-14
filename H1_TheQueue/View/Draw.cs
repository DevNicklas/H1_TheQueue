using H1_TheQueue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheQueue.View
{
    /// <summary>
    /// This class is responsible for anything GUI related
    /// </summary>
    internal class Draw
    {
        /// <summary>
        /// Draws a horizontal line within some criterias
        /// </summary>
        /// <param name="x">start position of x</param>
        /// <param name="y">start position of y</param>
        /// <param name="length">length of the line</param>
        /// <param name="horizontalChar">horizontal line character</param>
        /// <param name="leftCornerChar">left corner character</param>
        /// <param name="rightCornerChar">right corner character</param>
        private void DrawHorizontalLine(int x, int y, int length, char horizontalChar, char leftCornerChar, char rightCornerChar)
        {
            Console.SetCursorPosition(x, y);

            // Prints one left corner, a horizontal line with a certain length, and a right corner
            // Two is removed from the length for printing the right size, since the two corners adds two in length
            Console.Write(leftCornerChar + new string(horizontalChar, length - 2) + rightCornerChar);
        }

        /// <summary>
        /// Draws a vertical line within some criterias
        /// </summary>
        /// <param name="x">start position of x</param>
        /// <param name="y">start position of y</param>
        /// <param name="height">height of the line</param>
        /// <param name="verticalChar">vertical line character</param>
        private void DrawVerticalLine(int x, int y, int length, char verticalChar)
        {
            // Prints every single vertical char which needed, so it forms
            // the vertical line which is asked for
            for (int i = 0; i < length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(verticalChar);
            }
        }

        /// <summary>
        /// Draws a text within some criterias
        /// </summary>
        /// <param name="x">start position of x</param>
        /// <param name="y">start position of y</param>
        /// <param name="text">text to print</param>
        private void DrawText(int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }

        /// <summary>
        /// Uses the fields and draws an box within them
        /// </summary>
        public void DrawBox(int x, int y, int height, int width, ConsoleColor boxColor)
        {
            Console.Clear();
            // Color of foreground before changing it
            ConsoleColor previousColor = Console.ForegroundColor;

            Console.ForegroundColor = boxColor;
            // Top horizontal line
            DrawHorizontalLine(x, y, width, '═', '╔', '╗');

            // Lower horizontal line
            // The y value has been subtracted with one, since the top horizontal line is printed, and counts as one
            DrawHorizontalLine(x, y + height - 1, width, '═', '╚', '╝');

            // Both vertical lines
            // If i = 0 then its the vertical line to the left
            // If i = 1 then its the vertical line to the right
            //
            // The x value is calculated by using the index of the loop and
            // multiplying it with the width-1, since the first value of x is 0 and not 1.
            // Then it takes that result and adds to the x value
            //
            // The y value has been added by one, since the vertical line is printed just under the top horizontal line
            //
            // The height or length of the line, is subtracted with two, since the line has to be printed between
            // the top and bottom horizontal lines
            for (int i = 0; i < 2; i++)
            {
                DrawVerticalLine(x + i * (width - 1), y + 1, height - 2, '║');
            }

            // Change the color back to the previousColor
            Console.ForegroundColor = previousColor;
        }

        /// <summary>
        /// Creates the ferry menu
        /// </summary>
        public void FerryMenu()
        {
            DrawBox(0, 0, 13, 80, ConsoleColor.White);
            DrawText(2, 1, "1. Add car");
            DrawText(2, 3, "2. Delete car");
            DrawText(2, 5, "3. Show the number of cars");
            DrawText(2, 7, "4. Show first and last car");
            DrawText(2, 9, "5. Find a specific car");
            DrawText(2, 11, "6. Exit program");
        }

        /// <summary>
        /// This method asks the user for the first name of the costumer
        /// </summary>
        public void AskFirstName()
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, "Please enter First name of customer:");
            Console.SetCursorPosition(2, 2);
        }

        /// <summary>
        /// This method asks the user for the licenseplate
        /// </summary>
        public void AskLastName()
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, "Please enter last name of customer:");
            Console.SetCursorPosition(2, 2);
        }

        /// <summary>
        /// This method asks the user for the licenseplate
        /// </summary>
        public void AskLicensePlate()
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, "Please enter licenseplate:");
            Console.SetCursorPosition(2, 2);
        }

        /// <summary>
        /// This method asks the user for the email of the costumer
        /// </summary>
        public void AskEmail()
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, "Please enter customers email:");
            Console.SetCursorPosition(2, 2);
        }

        /// <summary>
        /// This method asks the user for the phone number of the costumer
        /// </summary>
        public void AskPhoneNumber()
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, "Please enter customers phonenumber:");
            Console.SetCursorPosition(2, 2);
        }

        /// <summary>
        /// This method asks the user if theyre sure they want to delete the next car in queue.
        /// </summary>
        public void DeleteCar()
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, "Press Y to delete first car in queue, or press any");
            DrawText(2, 2, "other key to go back to previous menu");
        }

        /// <summary>
        /// This method shows the total amount of cars in the queue.
        /// </summary>
        /// <param name="count">amount of cars</param>
        public void ShowNumberOfCars(byte count)
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, $"There is currently {count} cars in queue.");
            DrawText(2, 2, $"Press any key to proceed.");
        }

        /// <summary>
        /// This method prints prints the first car in queue and the last car in queue.
        /// </summary>
        /// <param name="firstCar"></param>
        /// <param name="secondCar"></param>
        public void ShowFirstAndLastCar(Car firstCar, Car lastCar)
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, $"This is the first car in the queue:");
            DrawText(2, 2, $"Owner: {firstCar.Owner.FirstName} {firstCar.Owner.LastName}");
            DrawText(2, 3, $"License plate: {firstCar.LicensePlate}");
            DrawText(2, 5, $"This is the last car in the queue:");
            DrawText(2, 6, $"Owner: {lastCar.Owner.FirstName} {lastCar.Owner.LastName}");
            DrawText(2, 7, $"License plate: {lastCar.LicensePlate}");
            Console.SetCursorPosition(2, 2);
        }

        /// <summary>
        /// This method asks what car the user want to find
        /// </summary>
        public void FindCar()
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            DrawText(2, 1, "Please enter the license plate of the car you want to find: ");
            Console.SetCursorPosition(2, 2);
        }

        /// <summary>
        /// This method says wheather the car is in the system or not.
        /// </summary>
        /// <param name="isCarThere"></param>
        public void CarFound(bool isCarThere)
        {
            DrawBox(0, 0, 15, 80, ConsoleColor.White);
            if (isCarThere)
            {
                DrawText(2, 1, "Car is in queue");
            }
            else
            {
                DrawText(2, 1, "Car is not in queue");
            }
        }
    }
}
