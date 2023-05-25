namespace WebApi.Models.Pttypes
{
    public class SyncRequest
    {
        public string Pttype { get; set; }
        public string Name { get; set; }
        public string Editmask { get; set; }
        public string Isuse { get; set; }
        public string Pcode { get; set; }
        public string HipdataCode { get; set; }
        public string NhsoCode { get; set; }
    }
}
