using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Macommania.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ExecutableFilePathProvider"/> implementation of <see cref="IExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultExecutableFilePathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IExecutableFilePathProvider, ExecutableFilePathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ExecutableFilePathProvider"/> implementation of <see cref="IExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IExecutableFilePathProvider> AddDefaultExecutableFilePathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IExecutableFilePathProvider>(() => services.AddDefaultExecutableFilePathProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ExecutableFileDirectoryPathProvider"/> implementation of <see cref="IExecutableFileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultExecutableFileDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IExecutableFilePathProvider> executableFilePathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IExecutableFileDirectoryPathProvider, ExecutableFileDirectoryPathProvider>()
                .RunServiceAction(executableFilePathProviderAction)
                .RunServiceAction(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ExecutableFileDirectoryPathProvider"/> implementation of <see cref="IExecutableFileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IExecutableFileDirectoryPathProvider> AddDefaultExecutableFileDirectoryPathProviderAction(this IServiceCollection services,
            IServiceAction<IExecutableFilePathProvider> executableFilePathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = new ServiceAction<IExecutableFileDirectoryPathProvider>(() => services.AddDefaultExecutableFileDirectoryPathProvider(
                executableFilePathProviderAction,
                stringlyTypedPathOperatorAction));
            return serviceAction;
        }
    }
}
