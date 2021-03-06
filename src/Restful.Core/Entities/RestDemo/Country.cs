﻿using System.Collections.Generic;
using Restful.Core.Entities.RestDemo;

namespace Restful.Core.Entities
{
    public class Country : Entity
    {
        public string EnglishName { get; set; }
        public string ChineseName { get; set; }
        public string Abbreviation { get; set; }

        public string Continent { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
