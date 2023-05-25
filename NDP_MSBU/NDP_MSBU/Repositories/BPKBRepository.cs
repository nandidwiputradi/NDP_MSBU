using NDP_MSBU.Models;
using System.Net.Http.Json;

namespace NDP_MSBU.Repositories
{
    public class BPKBRepository
    {
        string _requestURI;
        public BPKBRepository(string requestURI)
        {
            _requestURI = string.Format("{0}bpkb/", requestURI);
        }

        public void Save(BPKBModel param)
        {
            string res = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                var result = Task.Run(() => client.PostAsJsonAsync<BPKBModel>(_requestURI, param));
                using (HttpResponseMessage msg = result.Result)
                {
                    using (HttpContent content = msg.Content)
                    {
                        var contentread = Task.Run(() => content.ReadAsStringAsync());
                        if (contentread.Result != null)
                        {
                            res = contentread.Result;
                        }
                    }
                }
            }
        }
    }
}
