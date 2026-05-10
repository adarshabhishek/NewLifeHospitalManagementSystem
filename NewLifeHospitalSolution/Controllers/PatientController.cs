using Microsoft.AspNetCore.Mvc;
using NewLifeHospitalDAL.Models;
using NewLifeHospitalDAL.Repository;
using NewLifeHospitalSolution.Models;

namespace NewLifeHospitalSolution.Controllers
{
    public class PatientController : Controller
    {
        RepositoryClass repo = new RepositoryClass();

        // VIEW ALL PATIENTS
        public ActionResult ViewPatients()
        {
            var patients = repo.GetAllPatients();

            List<Patient> patientList = new List<Patient>();

            foreach (var item in patients)
            {
                patientList.Add(new Patient()
                {
                    ID = item.ID,
                    PatientName = item.PatientName,
                    Age = item.Age,
                    Gender = item.Gender,
                    BloodGroup = item.BloodGroup,
                    ContactNumber = item.ContactNumber,
                    EmailID = item.EmailID
                });
            }

            return View(patientList);
        }

        // GET
        public ActionResult RegisterForMembership()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult RegisterForMembership(Patient pObj)
        {
            if (ModelState.IsValid)
            {
                PatientInfoDetail patient = new PatientInfoDetail()
                {
                    PatientName = pObj.PatientName,
                    Age = pObj.Age,
                    Gender = pObj.Gender,
                    BloodGroup = pObj.BloodGroup,
                    ContactNumber = pObj.ContactNumber,
                    EmailID = pObj.EmailID
                };

                bool result = repo.RegisterForMembership(patient);

                if (result)
                {
                    return RedirectToAction("ViewPatients");
                }
            }

            return View(pObj);
        }

        // GET
        public ActionResult CancelMembership()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult CancelMembership(int registrationId)
        {
            bool result = repo.CancelMembership(registrationId);

            if (result)
            {
                return RedirectToAction("ViewPatients");
            }

            return View();
        }

        // GET
        public ActionResult UpdateEmail()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult UpdateEmail(int registrationId, string email)
        {
            bool result = repo.UpdateEmail(registrationId, email);

            if (result)
            {
                return RedirectToAction("ViewPatients");
            }

            return View();
        }
    }
}