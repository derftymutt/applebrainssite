using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace AppleBrainsSite.Models.Requests
{
    public class FruitCreateRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Url]
        [MaxLength(500)]
        public string Image { get; set; }

        [Required]
        [MaxLength(128)]
        public string UserId { get; set; }
    }
}