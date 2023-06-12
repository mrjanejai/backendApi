using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities.eclaim
{
    [Keyless]
    public class eclaimKey
    {
        public string eclaimno { get; set; }
        public string cid { get; set; }
    }

    public class eclaim
    {
        [Key]
        public eclaimKey key { get; set; }
        public string? pttype { get; set; }
        public string? fname { get; set; }
        public string? hn { get; set; }
        public string? an { get; set; }
        public DateTime? vstdate { get; set; }
        public DateTime? dcdate { get; set; }
        public string? estatus { get; set; }
        public string? staffname { get; set; }
        public string? tranid { get; set; }
        public string? rep { get; set; }
        public string? details { get; set; }
        public string? chanel { get; set; }
    }
}
