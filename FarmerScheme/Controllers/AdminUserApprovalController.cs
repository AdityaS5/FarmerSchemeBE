using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FarmerScheme.Models;
namespace FarmerScheme.Controllers
{
    public class AdminUserApprovalController : ApiController
    {
        FarmerSchemeEntities db = new FarmerSchemeEntities();
        public IHttpActionResult Getuser_information()
        {
            return Ok(db.user_information.ToList());
        }
    }
}
