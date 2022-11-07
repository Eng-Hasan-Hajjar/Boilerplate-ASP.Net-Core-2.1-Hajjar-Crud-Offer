using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boilerplateasp.Offers.Dto;
using boilerplateasp.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace boilerplateasp.Offers
{
    public interface IOfferAppService : ICrudAppService<OfferDto,int, CreateOfferDto,OfferDto>
    {
        Task<GetOfferForEditOutput> GetOfferForEdit(EntityDto input);


        Task<ListResultDto<OffersListDto>> GetOffersAsync(GetOffersInput input);

    }
}
