using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WITSLstore.TestPro;
 

namespace WITSLstore.TestPro
{
   public class Service_of_product : IProduct_Service
    {
        private readonly Mongo_Repositery repositery = null;
        public Service_of_product()
        {
            repositery = new Mongo_Repositery();
        }




        public async Task<XElement> GetAllXml()
        {

            List<TestCec> e = repositery.Product.Find(x => true).ToList();
           
            var xml = new XElement("Attachment", e.Select(x => new XElement("Attachments",
                                                new XAttribute("Version", x.Uom)
                                              
                                               )));

            return  (xml);


          

        }





        public async Task Addproduct(TestCec testadd)
        {
            // await repositery.Product.InsertOneAsync(testadd);
            await repositery.Product.InsertOneAsync(testadd);
        }






        public async Task<IEnumerable<TestCec>> GetAllProducts()
        {
            
            return await repositery.Product.Find(x => true).ToListAsync();
        }









    }



}
