using NewLifeHospitalDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLifeHospitalDAL.Repository
{
    public interface IRepository
    {
        bool RegisterForMembership(PatientInfoDetail pObj);

        bool CancelMembership(int registrationId);

        bool UpdateEmail(int registrationId, string email);

        List<PatientInfoDetail> GetAllPatients();
    }
}
