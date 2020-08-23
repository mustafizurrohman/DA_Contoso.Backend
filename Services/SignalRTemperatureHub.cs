// ***********************************************************************
// Assembly         : DA_Contoso.Backend
// Author           : Mustafizur Rohman
// Created          : 08-23-2020
//
// Last Modified By : Mustafizur Rohman
// Last Modified On : 08-23-2020
// ***********************************************************************
// <copyright file="SignalRTemperatureHub.cs" company="DA_Contoso.Backend">
//     Copyright (c) Personal. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Microsoft.AspNetCore.SignalR;

namespace DA_Contoso.Backend.Services
{
    /// <summary>
    /// Class SignalRTemperatureHub.
    /// Implements the <see cref="Microsoft.AspNet.SignalR.Hub" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNet.SignalR.Hub" />
    public class SignalRTemperatureHub : Hub
    {
        public static Hub Instance { get; } = new SignalRTemperatureHub();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalRTemperatureHub"/> class.
        /// </summary>
        private SignalRTemperatureHub()
        {

        }

        //public void BroadcastUpdatedTemperature(TemperatureLocation temperatureLocation)
        //{
        //    await Clients.All.SendCoreAsync(temperatureLocation);
        //}


    }
}
