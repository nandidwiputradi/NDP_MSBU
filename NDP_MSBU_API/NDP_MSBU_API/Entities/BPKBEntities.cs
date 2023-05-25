using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NDP_MSBU_API.Entities
{
    [Table("tr_bpkb")]
    public class BPKBEntities
    {
        [Key]
        [Column("agreement_number")]
        public string agreementNumber { get; set; }
        [Column("bpkb_no")]
        public string bpkbNumber { get; set; }
        [Column("branch_id")]
        public string branchId { get; set; }
        [Column("bpkb_date")]
        public DateTime bpkbDate { get; set; }
        [Column("faktur_no")]
        public string fakturNumber { get; set; }
        [Column("faktur_date")]
        public DateTime fakturDate { get; set; }

        [Column("location_id")]
        public string locationId { get; set; }
                
        //public virtual StorageLocationEntities StorageLocation { get; set; }
        [Column("police_no")]
        public string policeNumber { get; set; }
        [Column("bpkb_date_in")]
        public DateTime bpkbDateIn { get; set; }
    }
}
