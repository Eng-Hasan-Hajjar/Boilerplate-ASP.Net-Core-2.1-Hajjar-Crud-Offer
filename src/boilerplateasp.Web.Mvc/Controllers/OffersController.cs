using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using boilerplateasp.Authorization;
using boilerplateasp.Controllers;
using boilerplateasp.Offers;
using boilerplateasp.Offers.Dto;
using boilerplateasp.Web.Models.Offers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace boilerplateasp.Web.Controllers
{
        [AbpMvcAuthorize(PermissionNames.Pages_Offers)]

    public class OffersController : boilerplateaspControllerBase
    {
        private readonly IOfferAppService _offerAppService;


        public OffersController(IOfferAppService offerAppService)
        {
            _offerAppService = offerAppService;
        }


        public async Task<IActionResult> Index()
        {
            var offers = (await _offerAppService.GetOffersAsync(new GetOffersInput())).Items;
          
            var model = new OfferListViewModel
            {
                Offers = (System.Collections.Generic.IReadOnlyList<OfferListDto>)offers,
               
            };

            return View(model);
        }

        public async Task<ActionResult> EditOfferModal(int offerId)
        {
            var output = await _offerAppService.GetOfferForEdit(new EntityDto(offerId));
            var model = ObjectMapper.Map<EditOfferModalViewModel>(output);

            return View("_EditOfferModal", model);
        }
    }
}

