using System;


namespace R5T.Macommania.Default
{
    public class DefaultExecutableFilePathProvider : IExecutableFilePathProvider
    {
        public string GetExecutableFilePath()
        {
            var output = Utilities.GetExecutableFilePathValue();
            return output;
        }
    }
}
