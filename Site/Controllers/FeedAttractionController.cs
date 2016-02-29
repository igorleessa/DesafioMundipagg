using DAL.Entity;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Site.Controllers
{
    public class FeedAttractionController : ApiController
    {
        public List<Attraction> GetAttraction()
        {
            try
            {
                AttractionDal a = new AttractionDal();

                return a.FindAll();
            }
            catch
            {
                throw;
            }
        }
    }
}
