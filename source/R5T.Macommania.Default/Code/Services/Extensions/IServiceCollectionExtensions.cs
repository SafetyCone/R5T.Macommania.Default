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
        public static ServiceAction<IExecutableFilePathProvider> AddDefaultExecutableFilePathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IExecutableFilePathProvider>(() => services.AddDefaultExecutableFilePathProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ExecutableFileDirectoryPathProvider"/> implementation of <see cref="IExecutableFileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultExecutableFileDirectoryPathProvider(this IServiceCollection services,
            ServiceAction<IExecutableFilePathProvider> addExecutableFilePathProvider,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IExecutableFileDirectoryPathProvider, ExecutableFileDirectoryPathProvider>()
                .RunServiceAction(addExecutableFilePathProvider)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ExecutableFileDirectoryPathProvider"/> implementation of <see cref="IExecutableFileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IExecutableFileDirectoryPathProvider> AddDefaultExecutableFileDirectoryPathProviderAction(this IServiceCollection services,
            ServiceAction<IExecutableFilePathProvider> addExecutableFilePathProvider,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IExecutableFileDirectoryPathProvider>(() => services.AddDefaultExecutableFileDirectoryPathProvider(
                addExecutableFilePathProvider,
                addStringlyTypedPathOperator));
            return serviceAction;
        }
    }
}
