﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpe22ShopVaitmaa.Core.Domain
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; } //unique id
        public int Price { get; set; } //price of the car
        public string Type { get; set; } //car type [Rocket, Saucer, Cruise ship, Cargoship]
        public string Name { get; set; } //name of the ship not build make or model
        public string Description { get; set; } //description of the ship, containing any info not covered by any of the other fields
        public string FuelType { get; set; } //what type of fuel does the car use
        public int FuelCapacity { get; set; } //how much fuel it can hold
        public int FuelConsumption { get; set; } //how much fuel the ship consumes per day on average
        public int PassengerCount { get; set; } //how many passengers fit the ship
        public int EnginePower { get; set; } //how powerful the engine is in kWh
        public bool DoesHaveAutopilot { get; set; } //does the ship have automatic piloting feature
        public int CargoWeight { get; set; } //how much cargo can the ship transport
        public DateTime BuiltDate { get; set; } // when as the ship built at
        public DateTime LastMaintenance { get; set; } //when was the ship last maintained at
        public int MaintenanceCount { get; set; } //how many maintenance sessions has been performed on the ship
        public int km { get; set; } //how many voyages the ship has gone through
        public string Mark { get; set; } //who manufactured the car

        //database info only, do not display to user

        public DateTime CreatedAt { get; set; } //when was the entry created into the database
        public DateTime ModifiedAt { get; set; } //when the entry was last modified at

    }
}
