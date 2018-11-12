using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using WITSMLStore.Common;

namespace WITSMLStore.New_Project
{
    class Mongo_Repository_File
    {

        //declare mongodb
        private readonly IMongoDatabase mongoDatabase;
        public Mongo_Repository_File()
        {
            try
            {

                ConnectionStrin Setting = new ConnectionStrin();
                var connection = Setting.ConnectionString;
                var client = new MongoClient(connection);
                var database = Setting.DataBase;


                if (client != null)
                {
                    mongoDatabase = client.GetDatabase(database);
                }

            }
            catch (Exception Ex)
            {

                throw new Exception("Can not Acess mongo", Ex);
            }
        }

        public IMongoCollection<Tubular> Product => mongoDatabase.GetCollection<Tubular>("Tubular");


    }
}
