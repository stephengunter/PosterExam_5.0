using ApplicationCore.Helpers;
using ApplicationCore.Services;
using ApplicationCore.Settings;
using ApplicationCore.Views;
using ApplicationCore.ViewServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace Web.Controllers.Tests
{
    public class ATestsController : BaseTestController
    {
        private readonly IDataService _dataService;

        public ATestsController(IDataService dataService)
        {
            _dataService = dataService;

        }



        [HttpGet]
        public ActionResult Index()
        {
            

            return Ok();
        }
    }
}
