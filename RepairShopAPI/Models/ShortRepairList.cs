using Dapper;
using Dapper.Contrib.Extensions;

namespace RepairShopAPI
{
    [Table("shortrepairlist")]
    public class ShortRepairList
    {
        public int id { get; set; }
        public string instrument { get; set; }
        public string customer { get; set; }

        // static DAL methods
        public static List<ShortRepairList> getAll()
        {
            // Here's how we do it with just a query and not a view
            //return DAL.DB.Query<ShortRepairOrder>("select ro.id, ro.customer, ins.name as Instrument from repairorder ro join instrument ins on ro.instrument_id = ins.id;").ToList();
            // But some argue that putting queries in C# code is not the best idea.
            return DAL.DB.GetAll<ShortRepairList>().ToList();
            

        }
    }
}
