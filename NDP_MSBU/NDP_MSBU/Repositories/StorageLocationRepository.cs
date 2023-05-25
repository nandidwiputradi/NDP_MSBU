using NDP_MSBU.Models;
using System.Net.Http.Json;

namespace NDP_MSBU.Repositories
{
    public interface IStorageLocationRepository
    {
        List<StorageLocationViewModel> List();
    }

    public class StorageLocationRepository : IStorageLocationRepository
    {
        string _requestURI;
        public StorageLocationRepository(string requestURI) 
        {
            _requestURI = string.Format("{0}storagelocation/", requestURI);
        }
        public List<StorageLocationViewModel> List()
        {
            List<StorageLocationViewModel> res = new List<StorageLocationViewModel>();


            using(HttpClient client = new HttpClient())
            {
                var result = Task.Run(()=> client.GetAsync(_requestURI));
                using(HttpResponseMessage msg = result.Result)
                {
                    using(HttpContent  content = msg.Content)
                    {
                        var contentread = Task.Run(() => content.ReadFromJsonAsync<List<StorageLocationViewModel>>());
                        if(contentread.Result != null)
                        {
                            res = contentread.Result;
                        }
                    }
                }
            }

            return res;
        }
    }
}
