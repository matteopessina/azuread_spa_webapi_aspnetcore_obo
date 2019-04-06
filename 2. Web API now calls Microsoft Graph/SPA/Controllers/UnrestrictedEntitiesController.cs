using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureADAspNetCore21SPA.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AzureADAspNetCore21SPA.Controllers
{
    [Route("api/unrestrictedEntities")]
    [ApiController]
    public class UnrestrictedEntitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<UnrestrictedEntity> Get()
        {
            return Ok(
                new UnrestrictedEntity()
                {
                    Id = 1,
                    Property1 = "Only a logged in user can see this entity"
                }    
            );
        }

    }
}
