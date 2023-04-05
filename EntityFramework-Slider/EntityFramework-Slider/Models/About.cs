﻿namespace EntityFramework_Slider.Models
{
    public class About : BaseEntity
    {
        public string? Header { get; set; }
        public string? Description { get; set; }
        public ICollection<AboutImage> Images { get; set; }

    }
}
