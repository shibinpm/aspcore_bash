using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WITSMLStore.Common;

namespace WITSMLStore.New_Project
{
    public class Product_Service_i : Interface_Produc_Servic
    {

        private readonly Mongo_Repository_File repositery = null;



        public Product_Service_i()
        {
            repositery = new Mongo_Repository_File();
        }


        public async Task Addproduct(Tubular Tubular)
        {
            await repositery.Product.InsertOneAsync(Tubular);
        }



        public async Task<IMongoCollection<Tubular>> GetAllProducts()
        {
            return repositery.Product;
        }


        public async Task<DeleteResult> DeleteAll()
        {
            return await repositery.Product.DeleteManyAsync(new BsonDocument());

        }

        public async Task<DeleteResult> DeleteSelected(string Name)
        {
            var filter = Builders<Tubular>.Filter.Eq("NameWell", Name);
            return await repositery.Product.DeleteOneAsync(filter);

        }

        public async Task<bool> UpdateDetails(Tubular Tubular)
        {
            var filter = Builders<Tubular>.Filter.Eq("Name", Tubular.Name);
            var pro = repositery.Product.Find(filter).FirstOrDefaultAsync();
            if (pro.Result == null)
                return false;
            var update = Builders<Tubular>.Update
                                          .Set(x => x.NameWell, Tubular.NameWell)
                                          .Set(x => x.NameWellbore, Tubular.NameWellbore);

            await repositery.Product.UpdateOneAsync(filter, update);
            return true;
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
