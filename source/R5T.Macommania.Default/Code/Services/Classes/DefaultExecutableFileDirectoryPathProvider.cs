using System;

using R5T.Lombardy;


namespace R5T.Macommania.Default
{
    public class DefaultExecutableFileDirectoryPathProvider : IExecutableFileDirectoryPathProvider
    {
        private IExecutableFilePathProvider ExecutableFilePathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public DefaultExecutableFileDirectoryPathProvider(IExecutableFilePathProvider executableFilePathProvider, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.ExecutableFilePathProvider = executableFilePathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetExecutableFileDirectoryPath()
        {
            var executableFilePath = this.ExecutableFilePathProvider.GetExecutableFilePath();

            var executableFileDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPathForFilePath(executableFilePath);
            return executableFileDirectoryPath;
        }
    }
}
