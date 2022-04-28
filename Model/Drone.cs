using System;
using System.Collections.Generic;
using DroneAPI.Enums;
namespace DroneAPI.Model
{
    public class Drone
    {
        public int NumSeries { get; set; }
        public ModelDroneEnum Model { get; set; }
        public int WeightLimit { get; set; }
        public int Capacity { get; set; }
        public String State { get; set; }

        public ICollection<Medicine> Medicines { get; set; }
    }
}