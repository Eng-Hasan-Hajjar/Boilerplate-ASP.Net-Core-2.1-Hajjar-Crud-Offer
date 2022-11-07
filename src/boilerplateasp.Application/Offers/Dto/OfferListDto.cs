using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace boilerplateasp.Offers.Dto
{
    public class OfferListDto : EntityDto
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}
