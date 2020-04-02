using System;
using System.Collections.Generic;
using PlantTinder.Models;

namespace PlantTinder.Services
{
    public class PlantService
    {
        private static PlantService _instance;

        public static PlantService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PlantService();
                }

                return _instance;
            }
        }

        public List<Plant> GetPlants()
        {
            return new List<Plant>
            {
                new Plant
                {
                    Name = "Opuntia",
                    Image = "opuntia.png",
                    Description = "This strange and weird opuntia is so weird the species name is unknown to us and the nursery we purchased it from.",
                    Height = "25cm",
                    Width = "10.50cm",
                    RoomTemperature = "25",
                    Ambience = "60",
                    IsFavorite = false,
                    PlantType = "Home Plant"
                },
                new Plant
                {
                    Name = "Gymnocalycium",
                    Image = "gymno.png",
                    Description = "This strange and weird gymnnocalycium is so weird the species name is unknown to us and the nursery we purchased it from.",
                    Height = "25cm",
                    Width = "10.50cm",
                    RoomTemperature = "25",
                    Ambience = "60",
                    IsFavorite = false,
                    PlantType = "Home Plant"
                }
            };
        }
    }
}
