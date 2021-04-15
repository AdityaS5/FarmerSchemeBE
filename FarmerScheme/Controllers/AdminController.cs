using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FarmerScheme.Models;

namespace FarmerScheme.Controllers
{
    public class AdminController : ApiController
    {
        FarmerSchemeEntities db = new FarmerSchemeEntities();

        public IHttpActionResult GetAdmin()
        {
            return Ok(db.admins.ToList());
        }
        
        //[HttpPost]
        //public IHttpActionResult Register(admin admin)
        //{
        //    db.admins.Add(admin);
        //    db.SaveChanges();
        //    return Ok(db.admins);
        //}

        //public IHttpActionResult PutUser(string email_id, admin admin)
        //{
        //    db.Entry(admin).State = EntityState.Modified;
        //    db.SaveChanges();
        //    return Ok(admin);
        //}

        //public IHttpActionResult DeleteUser(string email_id)
        //{
        //    admin admin = db.admins.Find(email_id);
        //    db.admins.Remove(admin);
        //    db.SaveChanges();
        //    return Ok(admin);
        //}


    }
}
