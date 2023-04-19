using AutoMapper;
using CelilCavus.ElementWebSite.Mapping;
using CelilCavus.ElementWebSite.Models.Database.Context;
using CelilCavus.ElementWebSite.Models.Database.Entity;
using CelilCavus.ElementWebSite.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CelilCavus.ElementWebSite.Controllers
{
    public class AboutController : Controller
    {
        private readonly AboutMapping mapping;

        public AboutController()
        {
            mapping = new AboutMapping();
        }

        public ActionResult Index()
        {
            var values = mapping.GetAboutListDtos().LastOrDefault();           
            return View(values);
        }
    }
}