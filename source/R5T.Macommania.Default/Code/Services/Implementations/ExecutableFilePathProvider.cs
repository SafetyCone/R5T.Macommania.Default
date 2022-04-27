using System;

using R5T.T0064;


namespace R5T.Macommania.Default
{
    [ServiceImplementationMarker]
    public class ExecutableFilePathProvider : IExecutableFilePathProvider, IServiceImplementation
    {
        public string GetExecutableFilePath()
        {
            var output = Utilities.GetExecutableFilePathValue();
            return output;
        }
    }
}
