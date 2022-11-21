using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RepairShopAPI.Controllers
{
    [Route("instrument")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        [HttpGet]
        public List<Instrument> GetAll()
        {
            return Instrument.GetAll();
        }

        [HttpGet("{id}")]
        public Instrument GetOne(int id)
        {
            return Instrument.GetOne(id);
        }

        [HttpPost]
        public Instrument Add(Instrument inst)
        {
            return Instrument.Add(inst);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Instrument.Delete(id);
        }

        [HttpPut]
        public void Update(Instrument inst)
        {
            Instrument.Update(inst);
        }
    }
}
