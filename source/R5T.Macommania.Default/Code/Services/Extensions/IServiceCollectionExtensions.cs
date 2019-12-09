using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia.Extensions;
using R5T.Lombardy;


namespace R5T.Macommania.Default
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDefaultExecutableFileDirectoryPathProvider<TStringlyTypedPathOperator>(this IServiceCollection services)
            where TStringlyTypedPathOperator: class, IStringlyTypedPathOperator
        {
            services
                .TryAddSingletonFluent<IStringlyTypedPathOperator, TStringlyTypedPathOperator>()
                .TryAddSingletonFluent<IExecutableFilePathProvider, DefaultExecutableFilePathProvider>()
                .AddSingleton<IExecutableFileDirectoryPathProvider, DefaultExecutableFileDirectoryPathProvider>()
                ;

            return services;
        }
    }
}
