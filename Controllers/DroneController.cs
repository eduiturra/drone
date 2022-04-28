using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DroneAPI.Dtos;
using DroneAPI.Enums;
using DroneAPI.Helpers;
using DroneAPI.Services;
using DroneAPI.Model;

namespace DroneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DroneController : ControllerBase
    {
        private readonly IDroneServices _droneServices;
        private readonly ILogger<DroneController> _logger;

        public DroneController(ILogger<DroneController> logger, IDroneServices droneServices)
        {
            _logger = logger;
            _droneServices = droneServices;
        }

        [HttpPost]
        public async Task<ActionResult<Drone>> Post([FromBody] RegisterDroneDTO registerDTO)
        {
            return await _droneServices.SaveDrone(registerDTO);
        }

        [HttpGet("")]
        public GetDroneDTO GetDronesLoad([FromBody] GetDroneDTO droneDTO)
        {
            return new GetDroneDTO();
        }

        [HttpGet("battery")]
        public DroneBatteryDTO GetDroneBattery(String serie)
        {
            return new DroneBatteryDTO();
        }

        [HttpGet("medicine")]
        public DroneWeightMedicineDTO GetDroneWeightMedicine(String serie)
        {
            return new DroneWeightMedicineDTO();
        }
    }
}
