using boilerplateasp.Offers.Dto;
using System.Collections.Generic;

namespace boilerplateasp.Web.Models.Offers
{
    public class OfferListViewModel
    {

        public IReadOnlyList<OfferListDto> Offers { get; set; }

       
    }
}
