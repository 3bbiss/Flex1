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


        public static List<Instrument> GetAll()
        {
            return DAL.DB.GetAll<Instrument>().ToList();
        }

        public static Instrument GetOne(int id)
        {
            return DAL.DB.Get<Instrument>(id);
        }

        // (C)RUD Create

        public static Instrument Add(Instrument inst)
        {
            DAL.DB.Insert(inst);
            return inst;
        }

        // CRU(D) Delete
        public static void Delete(int id)
        {
            Instrument inst = new Instrument();
            inst.id = id;
            DAL.DB.Delete<Instrument>(inst);

        }

        // CR(U)D Update

        public static void Update(Instrument inst)
        {
            DAL.DB.Update(inst);
        }

    }
}
