using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureADAspNetCore21SPA.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureADAspNetCore21SPA.Controllers
{
    [Route("api/restrictedEntities")]
    [ApiController]
    public class RestrictedEntitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<RestrictedEntity> Get()
        {
            return Ok(
                new RestrictedEntity()
                {
                    Id = 1,
                    Property1 = "Only an administrator can get this entity"
                }
            );
        }

    }
}
