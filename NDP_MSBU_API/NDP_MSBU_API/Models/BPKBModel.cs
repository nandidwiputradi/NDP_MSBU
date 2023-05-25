using NDP_MSBU_API.Entities;

namespace NDP_MSBU_API.Models
{
    public class BPKBParameter
    {
        public string agreementNumber { get; set; }
        public string bpkbNumber { get; set; }
        public string branchId { get; set; }
        public DateTime bpkbDate { get; set; }
        public string fakturNumber { get; set; }
        public DateTime fakturDate { get; set; }
        public string locationId { get; set; }       
        public string policeNumber { get; set; }
        public DateTime bpkbDateIn { get; set; }
    }

    public class BPKBModel
    {
        public string agreementNumber { get; set; }
        public string bpkbNumber { get; set; }
        public string branchId { get; set; }
        public DateTime bpkbDate { get; set; }
        public string fakturNumber { get; set; }
        public DateTime fakturDate { get; set; }        
        public StorageLocationEntities StorageLocation { get; set; }
        public string policeNumber { get; set; }
        public DateTime bpkbDateIn { get; set; }
    }
}
