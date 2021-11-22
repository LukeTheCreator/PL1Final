using System.ComponentModel.DataAnnotations;

namespace PL1Final.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }

        public Boolean WillAttend { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        public int GuestAge { get; set; }

        [Required(ErrorMessage = "Please enter your arrival time")]
        public int ArrivalTime { get; set; }

        [Required(ErrorMessage = "Please specify whether you require parking assistance")]
        public Boolean ReqParking { get; set; }

    }
}
