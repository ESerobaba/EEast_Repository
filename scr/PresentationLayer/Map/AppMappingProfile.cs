using AutoMapper;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Map
{
	public class AppMappingProfile : Profile
	{
		public AppMappingProfile()
		{
			CreateMap<BusinessLogic.Entities.Customer, PLCustomer>().ReverseMap();
		}
	}
}
