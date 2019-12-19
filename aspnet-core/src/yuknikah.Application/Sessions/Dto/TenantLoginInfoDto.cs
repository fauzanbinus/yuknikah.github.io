﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using yuknikah.MultiTenancy;

namespace yuknikah.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
