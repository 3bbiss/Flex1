using Dapper.Contrib.Extensions;

namespace RepairShopAPI
{
    [Table("instrument")]
    public class Instrument
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
