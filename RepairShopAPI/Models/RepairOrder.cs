using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

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
            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            var result = db.Get<RepairOrder>(id);
            db.Close();
            return result;
        }


        // Create (C)RUD
        public static RepairOrder Add(RepairOrder order)
        {
            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            db.Insert(order);
            db.Close();
            return order;
        }

        // Delete CRU(D)
        public static void Delete(int id)
        {
            //db.Delete(new RepairOrder { id = id }); // shorter

            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            RepairOrder order = new RepairOrder();
            order.id = id;
            db.Delete<RepairOrder>(order);
            db.Close();
        }

        // Update CR(U)D
        public static void Update(RepairOrder order)
        {
            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            db.Update(order);
            db.Close();
        }

    }
}
