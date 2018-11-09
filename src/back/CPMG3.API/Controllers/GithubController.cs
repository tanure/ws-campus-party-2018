using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPMG3.API.Filter;
using CPMG3.API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPMG3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        private readonly IGithubAPIService _service;

        public GithubController(IGithubAPIService service)
        {
            _service = service;
        }

     
        [FeatureToggleFilter(ApplicationConstants.FeatureToggle.LISTAR_REPOSITORIOS)]
        [HttpGet]
        public async Task<ActionResult<object>> Get()
        {
            return await _service.GetRepositories();
        }
    }
}
