// ***********************************************************************
// Assembly         : DA_Contoso.Backend
// Author           : Mustafizur Rohman
// Created          : 08-23-2020
//
// Last Modified By : Mustafizur Rohman
// Last Modified On : 08-23-2020
// ***********************************************************************
// <copyright file="Program.cs" company="DA_Contoso.Backend">
//     Copyright (c) Personal. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DA_Contoso.Backend
{
    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the host builder.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>IHostBuilder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
