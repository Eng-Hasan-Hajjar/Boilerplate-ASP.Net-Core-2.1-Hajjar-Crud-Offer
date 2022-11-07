using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace boilerplateasp.Offers.Dto
{
   [AutoMapFrom(typeof(Offer))]
    public class OfferDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}
