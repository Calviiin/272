using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNDonationApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace UNDonationApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;

                if (isAdminUser())
                {
                    return View("Admin");
                }

                if (isDonorUser())
                {
                    return View("Index");
                }

            }
            else
            {
                ViewBag.Name = " You Are Currently Not Logged IN";
            }
            return View();
        }
        //private DonationDBEntities db = new DonationDBEntities();
        //  Admin Default View
        //[Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            try
            {
                //var Campaigns = db.Campaigns.Count();
                //ViewBag.Campaigns = Campaigns;
                //var Status = db.Campaign_Status.Count();
                //ViewBag.Status = Status;
                //var Citys = db.Cities.Count();
                //ViewBag.Citys = Citys;
                //var Donors = db.Doners.Count();
                //ViewBag.Donors = Donors;
                //var Organisations = db.Organiations.Count();
                //ViewBag.Organisations = Organisations;
                //var Payments = db.Payments.Count();
                //ViewBag.Payments = Payments;
                //var PaymentMethods = db.Payment_Method.Count();
                //ViewBag.PaymentMethods = PaymentMethods;
                //var Provinces = db.Provinces.Count();
                //ViewBag.Provinces = Provinces;
            }
            catch (Exception Ex)
            {
                return RedirectToAction("Error", Ex);
            }
            return View();
        }

        // Authorize Users
        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (User.IsInRole("Admin"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public Boolean isDonorUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (User.IsInRole("Donor"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}