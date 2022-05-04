using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicManagement.Controllers
{
    public class DoctorTypeController : Controller
    {
        // GET: DoctorType
        public ActionResult List()
        {
            List<Models.DoctorType> DoctorTypeList = new List<Models.DoctorType>()
            {
                new Models.DoctorType(){pk_doctor_type_Id=1,Doctor_Description="Cardiologist"},
                 new Models.DoctorType(){pk_doctor_type_Id=2,Doctor_Description="Physician"},
                  new Models.DoctorType(){pk_doctor_type_Id=3,Doctor_Description="Dermatologist"},
                  new Models.DoctorType(){pk_doctor_type_Id=4,Doctor_Description="Pediatrician"},
                  new Models.DoctorType(){pk_doctor_type_Id=5,Doctor_Description="Ophthlamologist"},
                  new Models.DoctorType(){pk_doctor_type_Id=6,Doctor_Description="Physician"},
                  new Models.DoctorType(){pk_doctor_type_Id=7,Doctor_Description="Gynecologists"}
            };
            return View(DoctorTypeList);
        }
        //for viewiwing routing in MVC
       // public ActionResult Doctor (int minid, int maxid)
        //{
            //return View();
        //}
    }
}