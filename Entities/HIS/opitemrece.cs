using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.HIS
{
    public class opitemrece
    {
        [Key]
        public string hos_guid { get; set; }
        public string? vn { get; set; }
        public string? hn { get; set; }
        public string? an { get; set; }
        public string? icode { get; set; }
        public int? qty { get; set; }
        public string? drugusage { get; set; }
        public string? idr { get; set; }
        public int? iperday { get; set; }
        public double? iperdose { get; set; }
        public TimeSpan? recetime { get; set; }
        public double? unitprice { get; set; }
        public DateTime? vstdate { get; set; }
        public TimeSpan? vsttime { get; set; }
        public string? doctor { get; set; }
        public DateTime? rxdate { get; set; }
        public TimeSpan? rxtime { get; set; }
        public string? sp_use { get; set; }
        public string? hcode { get; set; }
        public string? print { get; set; }
        public string? dep_code { get; set; }
        public string? finance_number { get; set; }
        public double? discount { get; set; }
        public string? use_right { get; set; }
        public string? node_id { get; set; }
        public int? order_no { get; set; }
        public string? sub_type { get; set; }
        public string? pttype { get; set; }
        public string? income { get; set; }
        public string? remain { get; set; }
        public string? item_type { get; set; }
        public string? staff { get; set; }
        public string? doctor_lock { get; set; }
        public string? paidst { get; set; }
        public byte? item_no { get; set; }
        public DateTime? last_modified { get; set; }
        public double? sum_price { get; set; }
        public double? cost { get; set; }
        public int? stock_department_id { get; set; }
        public string? command_doctor { get; set; }
        public int? opi_doctor_finance_type_id { get; set; }
    }
}
