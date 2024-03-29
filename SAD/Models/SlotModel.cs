﻿using System.ComponentModel.DataAnnotations;

namespace SAD.Models
{
    public class SlotModel
    {
        [Key]
        public int SlotId { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime SlotTime { get; set; }
        public string CardColour { get; set; }
        public string BookingId { get; set; }
    }
}
