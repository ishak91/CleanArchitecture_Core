using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appplication.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleManager _sampleManager;

        public SampleController(ISampleManager sampleManager)
        {
            _sampleManager = sampleManager;
        }

        /// <summary>
        /// Get All Dtos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allDto1 = await _sampleManager.GetAllDto1Async();

            return new JsonResult(allDto1);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SampleAddViewModel model)
        {
            await _sampleManager.AddAsync(model.Dto1,model.Dto2);

            return Ok();
        }
    }
}