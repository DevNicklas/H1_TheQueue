using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheQueue.Model
{
    /// <summary>
    /// Class <see cref="UserInput"/> is used to get input from user
    /// </summary>
    internal class UserInput
    {
        /// <summary>
        /// Fetches the key the user has pressed
        /// </summary>
        /// <returns>The key the user has pressed as ConsoleKey</returns>
        public ConsoleKey GetPressedKey()
        {
            return Console.ReadKey(true).Key;
        }

        /// <summary>
        /// Fetches text input which the user has given
        /// </summary>
        /// <returns>The text input which the user has given as a string</returns>
        public string GetInputText()
        {
            return Console.ReadLine();
        }
    }
}
