using System.ComponentModel.DataAnnotations;

namespace IpManager.Models
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public string Hostname { get; set; }
        public bool IsEnabled { get; set; }
    }
}
