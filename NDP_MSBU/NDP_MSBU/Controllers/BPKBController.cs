using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NDP_MSBU.Models;
using NDP_MSBU.Repositories;
using Microsoft.Extensions.Configuration;

namespace NDP_MSBU.Controllers
{
    public class BPKBController : Controller
    {
        IConfiguration _configuration;
        string _apiUrl;
        IStorageLocationRepository storageLocationRepository;

        public BPKBController(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiUrl = _configuration["APIURL"];
        }

        // GET: BPKBController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BPKBController/Create
        public ActionResult Create()
        {
            BKPBViewModel model = new BKPBViewModel();

            storageLocationRepository = new StorageLocationRepository(_apiUrl);
            var storageLocList = storageLocationRepository.List();
            model.storageLocations =  (from c in storageLocList.AsEnumerable() 
                                      select new DropDownViewModel() { text = c.locationName, value = c.locationId }).ToList();
            return View(model);
        }

        // POST: BPKBController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] BPKBModel param)
        {
            try
            {
                
                BPKBRepository bPKBRepository = new BPKBRepository(_apiUrl);
                bPKBRepository.Save(param);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

    }
}
