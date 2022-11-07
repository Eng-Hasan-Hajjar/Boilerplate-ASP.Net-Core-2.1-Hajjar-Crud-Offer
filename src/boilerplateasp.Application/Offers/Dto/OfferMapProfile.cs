using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Abp.AutoMapper;

namespace boilerplateasp.Offers.Dto
{
    [AutoMapFrom(typeof(Offer))]
    public class OfferMapProfile : Profile
    {

        public OfferMapProfile()
        {
              CreateMap<CreateOfferDto, Offer>();
              CreateMap<OfferDto, Offer>();
              CreateMap<Offer, OfferEditDto>();
            
        }
    }
}
