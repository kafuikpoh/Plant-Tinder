using System;
namespace PlantTinder.Models
{
    public class Plant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string RoomTemperature { get; set; }
        public string Ambience { get; set; }
        public string Image { get; set; }
        public bool IsFavorite { get; set; }
        public string PlantType { get; set; }
        public decimal Price { get; set; }
        public bool IsNew { get; set; }
    }
}
