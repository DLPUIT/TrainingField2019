﻿using SquirrelFramework.Domain.Model;

namespace DlpuManager.Service
{
    [Collection("User")]
    public class User : DomainModel
    {
        public string ClassId { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string Gender { get; set; }
        public int Credits { get; set; }
        public string GitHub { get; set; }
    }
}
