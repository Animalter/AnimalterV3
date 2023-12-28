﻿using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Dto
{
    public class AnimalDto
    {
        public int AnimalId { get; set; }
        public int GenusId { get; set; }
        public int TypeeId { get; set; }
        public string AnimalName { get; set; }

        public int AnimalAgeYear { get; set; }

        public int AnimalAgeMouth { get; set; }

        public string AnimalAbout { get; set; }

   
        public string AnimaiImageUrl { get; set; }

        public int AdoptionStatusId { get; set; }
        public string AnimalGender { get; set; }
    }
}
