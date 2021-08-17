using System.Web.Mvc;
using WebApplication4.Repository;
using WebApplication4.Models;
using WebApplication4.Repository.WebApplication4.repository;

namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            common objRepo = new common();

            var appRefStatus = objRepo.GetAppRefData(1800);
            var apprefType = objRepo.GetAppRefData(1220);
            var workcompanies = objRepo.GetWorkingCompany();
            var workinglocation = objRepo.GetEmplists();
            var departments = objRepo.GetDepartment();
            var batchids = objRepo.GetAppRefId();
            var hrRep = objRepo.GetHr();
            var actrec = objRepo.GetRecr();

            var empVM = new EmployeeAddEditViewModel
            {
                StatusList = appRefStatus,
                EmployeeType = apprefType,
                WorkingCompanies = workcompanies,
                WorkingLocations = workinglocation,
                BatchId = batchids,
                Departments=departments,
                HrRep=hrRep,
                Recruiters=actrec
                
            };

            return View(empVM);
        }
    }
}

