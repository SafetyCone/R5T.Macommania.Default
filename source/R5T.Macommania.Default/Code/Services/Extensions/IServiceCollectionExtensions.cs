using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia.Extensions;
using R5T.Lombardy;


namespace R5T.Macommania.Default
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection UseDefaultExecutableFileDirectoryPathProvider<TStringlyTypedPathOperator, TExecutableFilePathProvider>(this IServiceCollection services)
            where TStringlyTypedPathOperator : class, IStringlyTypedPathOperator
            where TExecutableFilePathProvider: class, IExecutableFilePathProvider
        {
            services
                .TryAddSingletonFluent<IStringlyTypedPathOperator, TStringlyTypedPathOperator>()
                .TryAddSingletonFluent<IExecutableFilePathProvider, TExecutableFilePathProvider>()
                .AddSingleton<IExecutableFileDirectoryPathProvider, DefaultExecutableFileDirectoryPathProvider>()
                ;

            return services;
        }

        public static IServiceCollection UseDefaultExecutableFileDirectoryPathProvider<TStringlyTypedPathOperator>(this IServiceCollection services)
            where TStringlyTypedPathOperator: class, IStringlyTypedPathOperator
        {
            services.UseDefaultExecutableFileDirectoryPathProvider<TStringlyTypedPathOperator, DefaultExecutableFilePathProvider>();

            return services;
        }
    }
}
