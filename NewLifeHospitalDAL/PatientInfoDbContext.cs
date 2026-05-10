using Microsoft.EntityFrameworkCore;
using NewLifeHospitalDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLifeHospitalDAL
{
    public class PatientInfoDbContext : DbContext
    {
            public DbSet<PatientInfoDetail> PatientInfoDetails { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    "Server=ADARSH\\SQLEXPRESS;Initial Catalog=NewLifeHospitalDB;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
    }

