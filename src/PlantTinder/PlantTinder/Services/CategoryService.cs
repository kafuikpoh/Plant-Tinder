using System;
using System.Collections.Generic;
using PlantTinder.Models;

namespace PlantTinder.Services
{
    public class CategoryService
    {
        private static CategoryService _instance;

        public static CategoryService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CategoryService();
                }

                return _instance;
            }
        }

        public List<PlantCategory> GetCategories()
        {
            return new List<PlantCategory>
            {
                new PlantCategory
                {
                    CategoryName = "Home Plants",
                    IconImageSource = "potted-black.png",
                    IsSelected = false
                },
                new PlantCategory
                {
                    CategoryName = "Cactus",
                    IconImageSource = "cactus-black.png",
                    IsSelected = false
                },
                new PlantCategory
                {
                    CategoryName = "Flowers",
                    IconImageSource = "orchid-black.png",
                    IsSelected = false
                }
            };
        }
    }
}
