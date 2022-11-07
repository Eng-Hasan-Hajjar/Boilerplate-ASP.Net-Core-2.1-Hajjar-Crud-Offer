using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using boilerplateasp.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace boilerplateasp.Offers
{



    public class Offer : Entity<int> 
    {
        public string Name { get;  set; }
        public string Comment { get;  set; }

        public string Image { get; set; }
    }
}
