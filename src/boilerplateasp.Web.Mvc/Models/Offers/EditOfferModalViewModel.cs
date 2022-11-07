using Abp.AutoMapper;
using boilerplateasp.Offers.Dto;
using boilerplateasp.Roles.Dto;

namespace boilerplateasp.Web.Models.Offers
{
    [AutoMapFrom(typeof(GetOfferForEditOutput))]
    public class EditOfferModalViewModel : GetOfferForEditOutput
    {

    }
}
