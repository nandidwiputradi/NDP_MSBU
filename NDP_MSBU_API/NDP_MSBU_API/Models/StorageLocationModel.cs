using System.ComponentModel.DataAnnotations.Schema;

namespace NDP_MSBU_API.Models
{
    public class StorageLocationParameter
    {
        public string locationId { get; set; }       
        public string locationName { get; set; }
    }
    public class StorageLocationModel
    {
        public string locationId { get; set; }
        public string locationName { get; set; }
    }
}
