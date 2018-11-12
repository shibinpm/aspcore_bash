using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WITSMLStore.Common;

namespace WITSMLStore.New_Project
{
    interface Interface_Produc_Servic
    {
        Task Addproduct(Tubular Tubular);

        //Task<IEnumerable<Tubular>> GetAllProducts();

        Task<DeleteResult> DeleteAll();

        Task<DeleteResult> DeleteSelected(string Name);

        Task<bool> UpdateDetails(Tubular Tubular);
    }
}
