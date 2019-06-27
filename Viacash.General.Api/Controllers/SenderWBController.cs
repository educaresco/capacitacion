using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Viacash.General.Api.Data;
using Viacash.General.Api.Models;
namespace Viacash.General.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SenderWBController:Controller
    {
       private readonly DataContext _context;

       public SenderWBController(DataContext context)
       {
           _context = context;
       }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var Result= _context.SendersWB.ToList(); 
            return Ok(Result);
        }

        // GET api/values/5
        [HttpGet("{ID_BRANCH}")]
        public ActionResult Get(string Id_branch)
        {
            //var Result = _context.SendersWB.FirstOrDefault(x=>x.ID_BRANCH==Id_branch && x.ID_SENDER==Id_sender) ;   
            var Result = _context.SendersWB.Where(x=>x.ID_BRANCH==Id_branch) ;   
            return Ok(Result);
            
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
