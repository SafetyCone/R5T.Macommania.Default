using System;


namespace R5T.Macommania.Default
{
    public class ExecutableFilePathProvider : IExecutableFilePathProvider
    {
        public string GetExecutableFilePath()
        {
            var output = Utilities.GetExecutableFilePathValue();
            return output;
        }
    }
}
