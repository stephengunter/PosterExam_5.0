using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Views;
using ApplicationCore.Helpers;
using AutoMapper;
using ApplicationCore.ViewServices;
using Web.Models;
using Microsoft.Extensions.Options;
using ApplicationCore.Settings;
using ApplicationCore.Specifications;
using Web.Controllers;
using Web.Models.Admin;

namespace Web.Controllers.Admin
{
	public class PaysController : BaseAdminController
	{
		private readonly IPaysService _paysService;
		private readonly IPlansService _plansService;
		private readonly IMapper _mapper;

		public PaysController(IPaysService paysService, IPlansService plansService, IMapper mapper)
		{
			_paysService = paysService;
			_plansService = plansService;
			_mapper = mapper;
		}

		[HttpGet("")]
		public async Task<ActionResult> Index(int plan = 0, int page = 1, int pageSize = 10)
		{
			//var model = new PaysAdminModel();
			//if (page < 0) //首次載入
			//{
			//	page = 1;

			//	var plans = await _plansService.FetchAllAsync();
			//	plans = plans.GetOrdered();

				
			//	model.LoadPlansOptions(plans.MapViewModelList(_mapper));

			//	if (plan < 1 && model.PlansOptions.HasItems()) plan = model.PlansOptions.FirstOrDefault().Value;
			//}

			//var pays = await _paysService.FetchByPlanAsync(plan);
			//pays = pays.GetOrdered();

			//model.PagedList = pays.GetPagedList(_mapper, page, pageSize);
			return Ok();
		}

	}
}
