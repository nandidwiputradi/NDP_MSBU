using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NDP_MSBU_API.Entities;
using NDP_MSBU_API.Models;
using System.Security.Cryptography.X509Certificates;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NDP_MSBU_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageLocationController : ControllerBase
    {       

        public StorageLocationController()
        {
           
        }

        // GET: api/<StorageLocationController>
        [HttpGet]
        public IEnumerable<StorageLocationEntities> Get()
        {
            List<StorageLocationEntities> storageLocationEntities = new List<StorageLocationEntities>();
            using (var db = new BPKBContext())
            {
                storageLocationEntities = db.storageLocationEntities.ToList();               
            }
            return storageLocationEntities;
        }

        // GET api/<StorageLocationController>/5
        [HttpGet("{id}")]
        public StorageLocationEntities Get(string id)
        {
            StorageLocationEntities storageLocationEntity = new StorageLocationEntities();
            using (var db = new BPKBContext())
            {
                var res = db.storageLocationEntities.SingleOrDefault(c => c.locationId == id);
                if(res != null)
                {
                    storageLocationEntity = res;
                }
            }
            return storageLocationEntity;
        }

        // POST api/<StorageLocationController>
        [HttpPost]
        public void Post([FromBody] StorageLocationParameter param)
        {
            StorageLocationEntities storageLocation = new StorageLocationEntities();
            storageLocation.locationId = param.locationId;
            storageLocation.locationName = param.locationName;
                       
            using(var db = new BPKBContext())
            {
                db.storageLocationEntities.Add(storageLocation);
                db.SaveChanges();
            }
        }

        // PUT api/<StorageLocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StorageLocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
