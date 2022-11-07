using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace boilerplateasp.Offers.Dto
{
    public class OfferEditDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
