using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafficChallanManagement.Models
{
    [Table("TbChallan")]
    public class Challan
    {
        public int ChallanId { get; set; }

        [DisplayName("Challan Date")]
        public DateTime? ChallanDate { get; set; }

        [DisplayName("Registration Number")]
        public string? RegNumber { get; set; }

        [DisplayName("Challan Amount")]
        public int? ChallanAmount { get; set; }

        [DisplayName("Challan Created By")]
        public string? CreatedBy { get; set; }

        [DisplayName("Is Paid")]
        public bool? IsPaid { get; set; }

        [DisplayName("Challan Paid By")]
        public string? PaidBy { get; set; }

        [DisplayName("Challan Paid Date")]
        public DateTime? ChallanPaidDate { get; set; }
    }
}
