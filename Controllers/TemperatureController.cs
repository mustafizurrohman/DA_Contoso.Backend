// ***********************************************************************
// Assembly         : DA_Contoso.Backend
// Author           : Mustafizur Rohman
// Created          : 08-23-2020
//
// Last Modified By : Mustafizur Rohman
// Last Modified On : 08-23-2020
// ***********************************************************************
// <copyright file="TemperatureController.cs" company="DA_Contoso.Backend">
//     Copyright (c) Personal. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using DA_Contoso.Models.DbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DA_Contoso.Backend.Controllers
{
    /// <summary>
    /// Class TemperatureController.
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class TemperatureController : ControllerBase
    {
        /// <summary>
        /// Gets the database context.
        /// </summary>
        /// <value>The database context.</value>
        private TemperatureDbContext DbContext { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureController"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public TemperatureController(TemperatureDbContext dbContext)
        {
            DbContext = dbContext;
        }


        /// <summary>
        /// read temperatures as an asynchronous operation.
        /// </summary>
        /// <returns>IActionResult.</returns>
        [HttpGet]
        public async Task<IActionResult> ReadTemperaturesAsync()
        {
            var temp = await DbContext.TemperatureLocations.ToListAsync();

            return Ok(temp);
        }

        /// <summary>
        /// read temperatures by identifier as an asynchronous operation.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IActionResult.</returns>
        [HttpGet("{id]")]
        public async Task<IActionResult> ReadTemperaturesByIdAsync(int id)
        {
            var temp = await DbContext.TemperatureLocations.FindAsync(id);

            return Ok(temp);
        }


        /// <summary>
        /// Updates the temperature.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="temp">The temporary.</param>
        /// <returns>IActionResult.</returns>
        [HttpPut("{id}/{temp}")]
        public async Task<IActionResult> UpdateTemperature(int id, float temp)
        {
            var tlocation = await DbContext.TemperatureLocations.FindAsync(id);

            if (tlocation == null)
            {
                return BadRequest("Invalid location ID");
            }

            tlocation.TemperatureC = temp;

            await DbContext.SaveChangesAsync();

            return Ok(tlocation);

        }


    }
}
