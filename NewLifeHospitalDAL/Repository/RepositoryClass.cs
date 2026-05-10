using NewLifeHospitalDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLifeHospitalDAL.Repository
{
    public class RepositoryClass: IRepository
    {
        PatientInfoDbContext db = new PatientInfoDbContext();

        public bool RegisterForMembership(PatientInfoDetail pObj)
        {
            bool status = false;
            try
            {
                db.PatientInfoDetails.Add(pObj);
                db.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }

            return status;
        }

        public bool CancelMembership(int registrationId)
        {
            bool status = false;
            try
            {
                var patient = db.PatientInfoDetails.Find(registrationId);
                if (patient != null)
                {
                    db.PatientInfoDetails.Remove(patient);
                    db.SaveChanges();
                    status = true;
                }
            }
            catch(Exception)
            {
                status = false;
            }

            return status;
        }

        public bool UpdateEmail(int registrationId, string email)
        {
            bool status =false;
            try
            {
                var patient = db.PatientInfoDetails.Find(registrationId);

                if (patient != null)
                {
                    patient.EmailID = email;

                    db.PatientInfoDetails.Update(patient);

                    db.SaveChanges();

                    status = true;
                }
            }
            catch (Exception)
            {
                status = false;
            }

            return status;
        }

        public List<PatientInfoDetail> GetAllPatients()
        {
            return db.PatientInfoDetails.ToList();
        }
    }
}

