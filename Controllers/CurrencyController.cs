using Pharmacy2uTechTest.Models;
using Pharmacy2uTechTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pharmacy2uTechTest.Controllers
{
    public class CurrencyController : Controller
    {
        private const decimal USDValue = 1.36m;
        private const decimal AUDValue = 1.91m;
        private const decimal EURValue = 1.16m;

        private Pharmacy2udbEntities db = new Pharmacy2udbEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(CurrencyAuditModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.CurrencyType == Convert.ToString(Currency.USD))
                {
                    model.ConvertedAmount = Decimal.Multiply(model.ActualAmount, USDValue);
                }
                else if (model.CurrencyType == Convert.ToString(Currency.AUD))
                {
                    model.ConvertedAmount = Decimal.Multiply(model.ActualAmount, AUDValue);
                }
                else
                {
                    model.ConvertedAmount = Decimal.Multiply(model.ActualAmount, EURValue);
                }
                Save(model);
            }

            TempData["ConvertedAmount"] = model.ConvertedAmount + " " + model.CurrencyType;
            return RedirectToAction("Index");
        }

        public void Save(CurrencyAuditModel model)
        {
            CurrencyAudit entityModel = new CurrencyAudit();

            entityModel.ActualAmount = model.ActualAmount;
            entityModel.ConvertedAmount = model.ConvertedAmount;
            entityModel.CurrencyType = model.CurrencyType;
            entityModel.DateAdded = DateTime.Now;

            db.CurrencyAudits.Add(entityModel);
            db.SaveChanges();
        }

        [HttpPost]
        public ActionResult Report(ReportModel model)
        {
            IList<CurrencyAuditModel> currencyAuditLst = new List<CurrencyAuditModel>();

            var data = db.CurrencyAudits.Where(x=> x.DateAdded >= model.FromDate && x.DateAdded <= model.ToDate).ToList();

            foreach (var item in data)
            {
                var obj= new CurrencyAuditModel();
                obj.ActualAmount = item.ActualAmount;
                obj.ConvertedAmount = item.ConvertedAmount ?? 0;
                obj.CurrencyType = item.CurrencyType;
                obj.DateAdded = item.DateAdded ?? DateTime.MinValue;
                currencyAuditLst.Add(obj);
            }
            return View(currencyAuditLst);
        }

        public ActionResult GetReport()
        {
            return View();
        }
    }

}