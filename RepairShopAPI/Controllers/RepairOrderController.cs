using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RepairShopAPI.Controllers
{
    [Route("repairorder")]
    [ApiController]
    public class RepairOrderController : ControllerBase
    {
        [HttpGet("{id}")]
        public RepairOrder GetOne(int id)
        {
            return RepairOrder.GetOne(id);
        }

        [HttpPost]
        public RepairOrder Add(RepairOrder order)
        {
            return RepairOrder.Add(order);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            RepairOrder.Delete(id);
        }

        [HttpPut]
        public void Update(RepairOrder order)
        {
            RepairOrder.Update(order);
        }

        // GET /repairorder/short - get the short version of all the orders
        [HttpGet("short")]
        public List<ShortRepairList> GetAll()
        {
            return ShortRepairList.getAll();
        }

        // GET /repairorder/bookmarks
        [HttpGet("bookmarks")]
        public List<ShortRepairList> GetBookmarks()
        {
            return ShortRepairList.GetBookmarks();
        }

    }
}


/*
 * RepairOrder
The short list will be included here
DO NOT NEED THIS ONE: GET /repairorder
GET /repairorder/{id} - get one
POST /repairorder - create one
DELETE /repairorder/{id} - delete one
PUT /repairorder - update one
GET /repairorder/short – get the short version of all the orders
*/
