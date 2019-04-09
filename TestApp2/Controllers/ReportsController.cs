using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp2.Models;
using TestApp2.ViewModels;

namespace TestApp2.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetTimesheetCounts(string onlyComplete)
        {
            ReportChartDataViewModel model = new ReportChartDataViewModel();

            TimesheetEntities entities = new TimesheetEntities();

            try
            {
                model.Labels = (from wa in entities.WorkAssignments
                                orderby wa.Id_WorkAssignment
                                select wa.Title).ToArray();

                if (onlyComplete == "1")
                {
                    model.Counts = (from ts in entities.Timesheets
                                    where (ts.WorkCompleted == true)
                                    orderby ts.id_WorkAssignment
                                    group ts by ts.id_WorkAssignment into grp
                                    select grp.Count()).ToArray();
                }
                else
                {
                    model.Counts = (from ts in entities.Timesheets
                                    orderby ts.id_WorkAssignment
                                    group ts by ts.id_WorkAssignment into grp
                                    select grp.Count()).ToArray();


                }

            }

            finally
            {
                entities.Dispose();
            }
            return Json(model, JsonRequestBehavior.AllowGet);

        }

    }
}