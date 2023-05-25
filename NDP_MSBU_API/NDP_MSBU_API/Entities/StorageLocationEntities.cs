using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NDP_MSBU_API.Entities
{
    [Table("ms_storage_location")]
    public class StorageLocationEntities
    {
        [Key]
        [Column("location_id")]
        public string locationId { get; set; }
        [Column("location_name")]
        public string locationName { get; set; }
    }
}
