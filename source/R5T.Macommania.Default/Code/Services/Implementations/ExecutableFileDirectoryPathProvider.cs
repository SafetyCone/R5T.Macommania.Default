using System;

using R5T.Lombardy;

using R5T.T0064;


namespace R5T.Macommania.Default
{
    [ServiceImplementationMarker]
    public class ExecutableFileDirectoryPathProvider : IExecutableFileDirectoryPathProvider, IServiceImplementation
    {
        private IExecutableFilePathProvider ExecutableFilePathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public ExecutableFileDirectoryPathProvider(IExecutableFilePathProvider executableFilePathProvider, IStringlyTypedPathOperator stringlyTypedPathOperator)
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
