namespace NDP_MSBU.Models
{
    public class BKPBViewModel
    {
        public  List<DropDownViewModel> storageLocations { get; set; }
        
        public string locationId { get; set; }
        public string agreementNumber { get; set; }
        public string branchId { get; set; }
        public string bpkbNumber { get; set; }
        public DateTime bpkbDateIn { get; set; }
        public DateTime bpkbDate { get; set; }
        public string fakturNumber { get; set; }
        public DateTime fakturDate { get; set; }
        public string policeNumber { get; set; }
    }
    public class BPKBModel
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


}
