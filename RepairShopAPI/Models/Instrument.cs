using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace RepairShopAPI
{
    [Table("instrument")]
    public class Instrument
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }


        public static List<Instrument> GetAll()
        {
            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            var result = db.GetAll<Instrument>().ToList();
            db.Close();
            return result;
        }

        public static Instrument GetOne(int id)
        {
            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            var result = db.Get<Instrument>(id);
            db.Close();
            return result;
        }

        // (C)RUD Create

        public static Instrument Add(Instrument inst)
        {
            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            db.Insert(inst);
            db.Close();
            return inst;
        }

        // CRU(D) Delete
        public static void Delete(int id)
        {
            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            Instrument inst = new Instrument();
            inst.id = id;
            db.Delete<Instrument>(inst);
            db.Close();
        }

        // CR(U)D Update

        public static void Update(Instrument inst)
        {
            MySqlConnection db = new MySqlConnection(DAL.CS);
            db.Open();
            db.Update(inst);
            db.Close();
        }

    }
}
