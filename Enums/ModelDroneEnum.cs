using System;
using System.ComponentModel;

namespace DroneAPI.Enums
{
    public enum ModelDroneEnum
    {
        [Description("peso ligero")]
        Ligth,
        [Description("peso medio")]
        Medium,
        [Description("peso crucero")]
        Cruice,
        [Description("peso pesado")]
        Heavy
    }
}