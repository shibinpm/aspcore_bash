using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WITSMLStore.Common;

namespace WITSMLstore.NewTest
{
    class Product_Service_Setup :Interface_Prod_Service
    {
        private readonly Mongo_Repositery_New repositery = null;



        public Product_Service_Setup()
        {
            repositery = new Mongo_Repositery_New();
        }


        public async Task Addproduct(Tubular Tubular)
        {
            await repositery.Product.InsertOneAsync(Tubular);
        }



        public async Task<IEnumerable<Tubular>> GetAllProducts()
        {
            return await repositery.Product.Find(x => true).ToListAsync();
        }










        //public async Task<XElement> GetAllXml()
        //{

        //    List<TestCec> e = repositery.Product.Find(x => true).ToList();

        //    var xml = new XElement("Attachment", e.Select(x => new XElement("Attachments",
        //                                        new XAttribute("Version", x.Uom)

        //                                       )));

        //    return (xml);




        //}





    }
}
