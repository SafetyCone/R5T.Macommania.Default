using System;
using System.Reflection;


namespace R5T.Macommania.Default
{
    public static class Utilities
    {
        /// <summary>
        /// Get the current executable's path location from the first argument of the command-line incantation used to start the current process.
        /// </summary>
        public static string GetExecutableFilePathCommandLineArgumentValue()
        {
            var commandLineArgs = Environment.GetCommandLineArgs();

            var executableFilePath = commandLineArgs[0]; // First argument of any command-line incantation is the path of the executable.
            return executableFilePath;
        }

        /// <summary>
        /// Gets the current executable's path location from the entry assembly's location.
        /// </summary>
        public static string GetExecutableFilePathEntryAssemblyValue()
        {
            var entryAssembly = Assembly.GetEntryAssembly();

            var executableFilePath = entryAssembly.Location; // The entry assembly will be the executable path.
            return executableFilePath;
        }

        /// <summary>
        /// Gets the path location of the executable via the default method, <see cref="Utilities.GetExecutableFilePathCommandLineArgumentValue()"/>.
        /// </summary>
        /// <remarks>
        /// There are multiple ways to get the location of the executable, and depending on context (unit test, debugging in Visual Studio, or production) different locations are returned.
        /// The command line argument is chosen as the default since this is the way the program is actually run by the operating system.
        /// </remarks>
        public static string GetExecutableFilePathValue()
        {
            var output = Utilities.GetExecutableFilePathCommandLineArgumentValue();
            return output;
        }
    }
}
