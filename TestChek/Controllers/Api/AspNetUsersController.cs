﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestChek.Models;

namespace TestChek.Controllers.Api
{
    public class AspNetUsersController : ApiController
    {
        private ModelDBContext _context;

        public AspNetUsersController()
        {
            _context = new ModelDBContext();
        }
        //GET /api/aspnetusers (Patients)
        public IEnumerable<AspNetUser> GetAspNetUsers()
        {
            return _context.AspNetUsers.ToList();
        }

        //GET /api/aspnetusers/1 (specific patient)
        public AspNetUser GetAspNetUser(string id)
        {
            var aspNetUser = _context.AspNetUsers.SingleOrDefault(c => c.Id == id);

            if (aspNetUser == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return aspNetUser;
        }

        //POST /api/aspnetusers
        [HttpPost]
        public AspNetUser CreateAspNetUser(AspNetUser aspNetUser)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.AspNetUsers.Add(aspNetUser);
            _context.SaveChanges();

            return aspNetUser;
        }

        //PUT /api/aspnetusers/1
        [HttpPut]
        public void UpdateAspNetUser(string id, AspNetUser aspNetUser)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var aspNetUserInDB = _context.AspNetUsers.SingleOrDefault(c => c.Id == id);

            if (aspNetUserInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            aspNetUserInDB.FirstName = aspNetUser.FirstName;
            aspNetUserInDB.LastName = aspNetUser.LastName;
            aspNetUserInDB.Id = aspNetUser.Id;
            aspNetUserInDB.UserName = aspNetUser.UserName;

            _context.SaveChanges();
        }

        //DELETE /api/aspnetusers/1
        [HttpDelete]
        public void DeleteAspNetUser(string id)
        {
            var aspNetUserInDB = _context.AspNetUsers.SingleOrDefault(c => c.Id == id);

            if (aspNetUserInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.AspNetUsers.Remove(aspNetUserInDB);
            _context.SaveChanges();
        }
    }
}