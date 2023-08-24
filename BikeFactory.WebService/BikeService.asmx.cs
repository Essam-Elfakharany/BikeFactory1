using BikeFactory1.Data;
using BikeFactory1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BikeFactory.WebService
{
    /// <summary>
    /// Summary description for BikeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BikeService : System.Web.Services.WebService
    {

        [WebMethod]
        public void Insert(Bike bike)
        {
            BikeData.Insert(bike, StaticMethods.GetConnectionString(this));
        }

        [WebMethod]
        public void Update(Bike bike)
        {
            BikeData.Update(bike, StaticMethods.GetConnectionString(this));
        }

        [WebMethod]
        public void Delete(int bikeId)
        {
            BikeData.Delete(bikeId, StaticMethods.GetConnectionString(this));
        }

        [WebMethod]
        public List<Bike> GetList()
        {
            var result = BikeData.GetList(StaticMethods.GetConnectionString(this));
            return result;
        }
    }

}

