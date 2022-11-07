using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.ObjectMapping;
using AutoMapper;
using boilerplateasp.Authorization;
using boilerplateasp.Authorization.Roles;
using boilerplateasp.Authorization.Users;
using boilerplateasp.Offers.Dto;
using boilerplateasp.Roles.Dto;
using boilerplateasp.Users.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boilerplateasp.Offers
{
    [AbpAuthorize(PermissionNames.Pages_Offers)]
    public class OfferAppService : CrudAppService<Offer, OfferDto, int, PagedOfferResultRequestDto, CreateOfferDto, OfferDto>, IOfferAppService
    {
        private readonly IRepository<Offer> _offerRepository;

        public OfferAppService(IRepository<Offer> offerRepository):base (offerRepository)
        {
            _offerRepository = offerRepository;
        }












      /*  public Task<GetOfferForEditOutput> GetOfferForEdit(EntityDto input)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<OfferDto>> GetAll(CreateOfferDto input)
          {
              throw new System.NotImplementedException();
          }


        //Delete
          Task IAsyncCrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.Delete(EntityDto<int> input)
          {
            var offer =  _offerRepository.Get(input.Id);
             _offerRepository.DeleteAsync(offer);
           throw new System.NotImplementedException();
          }
        //get
          Task<OfferDto> IAsyncCrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.Get(EntityDto<int> input)
          {
            var offers =  _offerRepository.GetAllListAsync();
           // return new ListResultDto<OfferDto>(ObjectMapper.Map<List<OfferDto>>(offers));
            throw new System.NotImplementedException();
          }
        //update
          Task<OfferDto> IAsyncCrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.Update(OfferDto input)
          {
            var offer =  _offerRepository.Get(input.Id);

            MapToEntity(input, offer);

           // return Get(input);
            throw new System.NotImplementedException();
          }
      
        //Create
        Task<OfferDto> IAsyncCrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.Create(OfferDto input)
        {
            var offer = ObjectMapper.Map<Offer>(input);

            _offerRepository.Insert(offer);

            CurrentUnitOfWork.SaveChanges();
           //  return MapToEntityDto(offer);
            throw new System.NotImplementedException();

        }

        /*   Task<OfferDto> Create(OfferDto input)
          {
              var offer = ObjectMapper.Map<Offer>(input);

              _offerRepository.Insert(offer);

              CurrentUnitOfWork.SaveChanges();

              return MapToEntityDto(offer);
          }*/



        
        protected override Offer MapToEntity(CreateOfferDto createInput)
        {
            var offer = ObjectMapper.Map<Offer>(createInput);
            return offer;
        }

        protected override void MapToEntity(OfferDto input, Offer offer)
        {
            ObjectMapper.Map(input, offer);
        }
        protected override OfferDto MapToEntityDto(Offer offer)
        {
            var offerDto = base.MapToEntityDto(offer);
            return offerDto;
        }

        protected  Task<Offer> GetEntityByIdAsync(int id)
        {
            return  Repository.FirstOrDefaultAsync(x => x.Id == id);
        }












        

        Task<GetOfferForEditOutput> IOfferAppService.GetOfferForEdit(EntityDto input)
        {
            var offer =  _offerRepository.Get(input.Id);
            var offerEditDto = ObjectMapper.Map<OfferEditDto>(offer);
            var offer2 = new GetOfferForEditOutput { Offer = offerEditDto, };
            return Task.FromResult(offer2);
        }

       OfferDto ICrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.Get(EntityDto<int> input)
        {
            var offer = _offerRepository.Get(input.Id);
            return  ObjectMapper.Map<OfferDto>(offer);
        }

      //*******
        PagedResultDto<OfferDto> ICrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.GetAll(CreateOfferDto input)
        {
            var offers = _offerRepository.GetAllListAsync();
            var offers2= ObjectMapper.Map<List<OfferDto>>(offers);
           // return ListResultDto<OfferDto>();
            throw new NotImplementedException();
        }


        public async Task<ListResultDto<OfferDto>> GetOffers()
        {
            var offers = await _offerRepository.GetAllListAsync();
            return new ListResultDto<OfferDto>(ObjectMapper.Map<List<OfferDto>>(offers));
        }


        //create
        OfferDto ICrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.Create(OfferDto input)
        {
            var offer = ObjectMapper.Map<Offer>(input);

            _offerRepository.Insert(offer);

            CurrentUnitOfWork.SaveChanges();

            return MapToEntityDto(offer);

        }
        // update
        OfferDto ICrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.Update(OfferDto input)
        {
            var offer = _offerRepository.Get(input.Id);

            MapToEntity(input, offer);

             return Get(input);
        }
        // delete
        void ICrudAppService<OfferDto, int, CreateOfferDto, OfferDto, OfferDto, EntityDto<int>, EntityDto<int>>.Delete(EntityDto<int> input)
        {
            var offer = _offerRepository.Get(input.Id);
            _offerRepository.DeleteAsync(offer);
        }








        public async Task<ListResultDto<OffersListDto>> GetOffersAsync(GetOffersInput input)
        {

            var offers = await _offerRepository.GetAllListAsync();
                   

           return new ListResultDto<OffersListDto>(ObjectMapper.Map<List<OffersListDto>>(offers));
            
        }
    }
}
