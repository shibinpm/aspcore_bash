using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WITSMLStore.Common;
using WITSMLStore.New_Project;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WITSMLStore.Controllers
{ 

    public class TestController : Controller
    {


        private Product_Service_i _serviceofproduct = new Product_Service_i();

        [HttpPost]
        [Route("api/TestCtrl2")]
        //public async Task<IActionResult> Post([FromBody]TestCec testadd)
        public async Task<IActionResult> Post([FromBody]Tubular Tubular)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Tubular.NameWell))
                    return BadRequest("Please enter Well name");

                else if (string.IsNullOrWhiteSpace(Tubular.NameWellbore))
                    return BadRequest("Please enter NameWellbore");

                else if (string.IsNullOrWhiteSpace(Tubular.Name))
                    return BadRequest("Please enter name");


                else if (string.IsNullOrWhiteSpace(Tubular.TypeTubularAssy))
                    return BadRequest("Please enter TypeTubularAssy");


                else if (string.IsNullOrWhiteSpace(Tubular.ValveFloat))
                    return BadRequest("Please enter ValveFloat");

                await _serviceofproduct.Addproduct(Tubular);
                return Ok("Added successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        //[HttpGet]
        //[Route("api/GetAll")]
        //public Task<IEnumerable<Tubular>> Get()
        //{
        //    return _serviceofproduct.GetAllProducts();
        //}

        [Route("api/Get")]
        [HttpGet]
        public Task<IMongoCollection<Tubular>> Get()
        {
            return _serviceofproduct.GetAllProducts();

        }


        [HttpDelete]
        [Route("api/deleteAll")]
        public IActionResult DeleteAll()
        {
            try
            {
                _serviceofproduct.DeleteAll();
                return Ok("All products deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }





        [HttpDelete("{wellname}")]
        [Route("api/DeleteOne")]
        public async Task<IActionResult> Delete(string wellname)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(wellname))
                    return BadRequest("Product name missing");
                await _serviceofproduct.DeleteSelected(wellname);
                return Ok("Your product has been deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        //[HttpPut]
        //[Route("api/Update")]
        //public async Task<IActionResult> Updatepricr(Tubular Tubular)
        //{
        //    if (string.IsNullOrWhiteSpace(Tubular.Name))
        //        return BadRequest("Product name missing");
        //   // Tubular.NameWellbore = string.UtcNow;
        //    var result = await _serviceofproduct.Updatepricr(Tubular);
        //    if (result)
        //    {
        //        return Ok("Your product's price has been updated successfully");
        //    }
        //    return BadRequest("No product found to update");

        //}





        //xml



        //[HttpGet]
        //[Route("api/GetXml")]
        //public Task<XElement> GetXml()
        //{
        //    return _serviceofproduct.GetAllXml();
        //}



    }
}
