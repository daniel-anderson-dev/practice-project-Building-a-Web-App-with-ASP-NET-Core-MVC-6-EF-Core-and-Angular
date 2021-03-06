﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TheWorld.Models
{
    public class TripViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Name { get; set; }
        public DateTime DateCreate { get; set; } = DateTime.UtcNow;
    }
}