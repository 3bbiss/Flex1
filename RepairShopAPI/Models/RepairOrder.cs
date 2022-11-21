using Dapper.Contrib.Extensions;

namespace RepairShopAPI
{
    [Table("repairorder")]
    public class RepairOrder
    {
        [Key]
        public int id { get; set; }
        public string customer { get; set; }
        public int instrument_id { get; set; }
        public int status { get; set; }
        public decimal price { get; set; }
        public string notes { get; set; }
        public bool bookmark { get; set; }


        // Static DAL members

        // GetOne C(R)UD
        public static RepairOrder GetOne(int id)
        {
            return DAL.DB.Get<RepairOrder>(id);
        }


        // Create (C)RUD
        public static RepairOrder Add(RepairOrder order)
        {
            DAL.DB.Insert(order);
            return order;
        }

        // Delete CRU(D)
        public static void Delete(int id)
        {
            //DAL.DB.Delete(new RepairOrder { id = id }); // shorter

            RepairOrder order = new RepairOrder();
            order.id = id;
            DAL.DB.Delete<RepairOrder>(order);
        }

        // Update CR(U)D
        public static void Update(RepairOrder order)
        {
            DAL.DB.Update(order);
        }

    }
}
