using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitForRent.BL;
using UnitForRent.DTO;

namespace UnitForRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblAnswersForRentController : ControllerBase
    {
        ITblAnswersForRentBL _TblAnswersForRentBl;
        public TblAnswersForRentController(ITblAnswersForRentBL productBl)
        {
            this._TblAnswersForRentBl = productBl;
        }
        // Get api/Products/GetAllProduct
        [Route("[action]")]
        [HttpGet]
        public ActionResult<List<TblAnswersForRentDTO>> GetAllProduct()
        {
            //ProductBL productBl = new ProductBL();

            List<TblAnswersForRentDTO> TblAnswersForRent1 = _TblAnswersForRentBl.GetAllProduct();
            if (TblAnswersForRent1 == null)
            {
                return NoContent();
            }
            return Ok(TblAnswersForRent1);

        }
    }
}
