using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DroneAPI.Helpers;
using DroneAPI.Enums;

namespace DroneAPI.Dtos
{
    public class RegisterDroneDTO : IValidatableObject
    {
        [Required]
        public int NumSeries { get; set; }
        [Required]
        public String Model { get; set; }
        [Required]
        public int WeightLimit { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public String State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(NumSeries >= 100 ){
                yield return new ValidationResult(
                    $"Classic movies must have a release year no later than.");
            }
            
            ModelDroneEnum? model = EnumHelper.GetValueFromDescription<ModelDroneEnum>(Model);
            if(model == null){
                yield return new ValidationResult(
                    $"Classic movies must have a release year no later than.");
            }
        }
    }
}