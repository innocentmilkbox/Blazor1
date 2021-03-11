﻿using BlazorDemo2.Shared;
using BlazorDemo2.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Web.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorDemo2.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComplaintController : Controller

    {
        private readonly MyDbContext db;

        public ComplaintController(MyDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IEnumerable<CaseType>> Get()
        {
            return await Task.Factory.StartNew<IEnumerable<CaseType>>(() =>
            {
                return db.CaseTypes.ToList();
            });

        }
        [HttpPost]
        public async Task<Case> Post([FromBody] Case newCase)
        {
            
            //newCase.refNumber = DateTime.Now.Ticks.ToString();
            //newCase.CompanyId = 1;
            EntityEntry<Case> z = await db.AddAsync(newCase);
            await db.SaveChangesAsync();
            return z.Entity;
        }
        public async Task<string> GetRefNum()
        {
            return await Task.Factory.StartNew<string>(() =>
            {
                return db.Cases.LastOrDefault().refNumber;
            });
        }
        
    

    }

}
