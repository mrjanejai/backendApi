namespace WebApi.Models.HIS
{
    public class OpitemreceResponse
    {
        public string hos_guid { get; set; }
        public string vn { get; set; }
        public string hn { get; set; }
        public string an { get; set; }
        public string icode { get; set; }
        public int qty { get; set; }
        public string drugusage { get; set; }
        public string idr { get; set; }
        public int iperday { get; set; }
        public double iperdose { get; set; }
        public TimeSpan recetime { get; set; }
        public double unitprice { get; set; }
        public DateTime vstdate { get; set; }
        public TimeSpan vsttime { get; set; }
        public string doctor { get; set; }
        public DateTime rxdate { get; set; }
        public TimeSpan rxtime { get; set; }
        public string sp_use { get; set; }
        public string hcode { get; set; }
        public string print { get; set; }
        public string dep_code { get; set; }
        public string finance_number { get; set; }
        public double discount { get; set; }
        public string use_right { get; set; }
        public string node_id { get; set; }
        public int order_no { get; set; }
        public string sub_type { get; set; }
        public string pttype { get; set; }
        public string income { get; set; }
        public string remain { get; set; }
        public string item_type { get; set; }
        public string staff { get; set; }
        public string doctor_lock { get; set; }
        public string paidst { get; set; }
        public byte item_no { get; set; }
        public DateTime last_modified { get; set; }
        public double sum_price { get; set; }
        public double cost { get; set; }
        public int stock_department_id { get; set; }
        public string command_doctor { get; set; }
        public int opi_doctor_finance_type_id { get; set; }

        public OpitemreceResponse()
        {
        }

        public OpitemreceResponse(string hos_guid, string vn, string hn, string an, string icode, int qty, string drugusage, string idr, int iperday, double iperdose, TimeSpan recetime, double unitprice, DateTime vstdate, TimeSpan vsttime, string doctor, DateTime rxdate, TimeSpan rxtime, string sp_use, string hcode, string print, string dep_code, string finance_number, double discount, string use_right, string node_id, int order_no, string sub_type, string pttype, string income, string remain, string item_type, string staff, string doctor_lock, string paidst, byte item_no, DateTime last_modified, double sum_price, double cost, int stock_department_id, string command_doctor, int opi_doctor_finance_type_id)
        {
            this.hos_guid = hos_guid;
            this.vn = vn;
            this.hn = hn;
            this.an = an;
            this.icode = icode;
            this.qty = qty;
            this.drugusage = drugusage;
            this.idr = idr;
            this.iperday = iperday;
            this.iperdose = iperdose;
            this.recetime = recetime;
            this.unitprice = unitprice;
            this.vstdate = vstdate;
            this.vsttime = vsttime;
            this.doctor = doctor;
            this.rxdate = rxdate;
            this.rxtime = rxtime;
            this.sp_use = sp_use;
            this.hcode = hcode;
            this.print = print;
            this.dep_code = dep_code;
            this.finance_number = finance_number;
            this.discount = discount;
            this.use_right = use_right;
            this.node_id = node_id;
            this.order_no = order_no;
            this.sub_type = sub_type;
            this.pttype = pttype;
            this.income = income;
            this.remain = remain;
            this.item_type = item_type;
            this.staff = staff;
            this.doctor_lock = doctor_lock;
            this.paidst = paidst;
            this.item_no = item_no;
            this.last_modified = last_modified;
            this.sum_price = sum_price;
            this.cost = cost;
            this.stock_department_id = stock_department_id;
            this.command_doctor = command_doctor;
            this.opi_doctor_finance_type_id = opi_doctor_finance_type_id;
        }
    }
}
