using Microsoft.AspNetCore.Mvc;
using NDP_MSBU_API.Entities;
using NDP_MSBU_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NDP_MSBU_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BPKBController : ControllerBase
    {
        // GET: api/<BPKBController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BPKBController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BPKBController>
        [HttpPost]
        public void Post([FromBody] BPKBParameter param)
        {
            using(var db = new BPKBContext())
            {
                BPKBEntities bpkbEntities = new BPKBEntities();
                bpkbEntities.agreementNumber = param.agreementNumber;
                bpkbEntities.bpkbNumber = param.bpkbNumber;
                bpkbEntities.branchId = param.branchId;
                bpkbEntities.bpkbDate = param.bpkbDate;
                bpkbEntities.fakturNumber = param.fakturNumber;
                bpkbEntities.fakturDate = param.fakturDate;

                var location = db.storageLocationEntities.SingleOrDefault(c => c.locationId == param.locationId);

                bpkbEntities.policeNumber = param.policeNumber;
                bpkbEntities.bpkbDateIn = param.bpkbDateIn;
                     
                if(location != null)
                {
                    bpkbEntities.locationId = param.locationId;                    
                    db.bpkbEntities.Add(bpkbEntities);
                    db.SaveChanges();
                }
            }
        }

        // PUT api/<BPKBController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BPKBController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
