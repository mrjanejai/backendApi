namespace WebApi.Models.IptOperCode;

    public class SyncRequest
    {
    public int ipt_oper_code { get; set; }
    public string icode { get; set; }
    public string name { get; set; }
    public double price { get; set; }
    public string use_right { get; set; }
    public string must_paid { get; set; }
    public double price2 { get; set; }
    public double price3 { get; set; }
    public string billcode { get; set; }
    public string icd9cm { get; set; }
    public string active_status { get; set; }
    public string hos_guid { get; set; }
    public string ipt_oper_code_guid { get; set; }
    public TimeSpan duration_minute { get; set; }
    public string use_opi_price { get; set; }
    public string is_investigation { get; set; }
    public int icd9_priority { get; set; }
    public string plot_graph { get; set; }
    public string search_keyword { get; set; }
}

