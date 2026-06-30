using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace TextFilter.DataAccess.Repositories
{
    /// <summary>
    /// Reposiotory class that reads from a text file and writes to the console.
    /// </summary>
    internal class TextFileConsoleRepository : IRepository
    {
        /// <summary>
        /// Name of the text file to read from.
        /// </summary>
        private string filename;

        /// <summary>
        /// Reposiotory class that reads from a text file and writes to the console.
        /// </summary>
        /// <param name="filename"></param>
        internal TextFileConsoleRepository(string filename)
        {
            // Filename to read from set on initialization to make the repo immutable.
            this.filename = filename;
        }

        /// <summary>
        /// Reads the contents of the text file specified by the filename and returns it as a string.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string Read()
        {
            return File.ReadAllText(filename);
        }

        /// <summary>
        /// Writes the specified text to the console and returns a boolean indicating success or failure.
        /// </summary>
        /// <param name="text">Text to write to console.</param>
        /// <returns>Success/failure.</returns>
        public bool Update(string text)
        {
            Console.WriteLine(text);

            // return success/failure based on whether the text was successfully written to the console
            return true;
        }
    }
}
