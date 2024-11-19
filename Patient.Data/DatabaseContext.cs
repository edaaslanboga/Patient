using Microsoft.EntityFrameworkCore;
using Patient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patient.Data
{
    public class DatabaseContext :DbContext
    {   public DbSet <Allergy> Allergies { get; set; } //Db set crud işlemleri çin 
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<ChronicCondition> ChronicConditions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public DbSet<FamilyHistory> FamilyHistorys { get; set; }
        public DbSet<HealthGoals >HealthGoalss { get; set; }
        public DbSet<HealthAlert> HealthAlerts { get; set; }
        public DbSet<ImmunizationRecord> ImmunizationRecords { get; set; }
        public DbSet<LabTest> LabTests { get; set; }
        public DbSet<LifestyleData> LifestyleDatas { get; set;}
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MyFeedback> MyFeedbacks { get; set; }
        public DbSet<PPatient> Patients { get; set; }
        public DbSet<PatientCommunity> PatientCommunitys { get; set; }
        public  DbSet<PatientPreferences> PatientPreferencess { get; set; }
        public DbSet<PatientRemember> PatientRemembers { get;}
        public DbSet<Prescripton> Prescriptons { get; set;}
        public DbSet<SymptomTracker> SymptomTrackers { get; set;}
        public DbSet<Visit> Visits { get; set; }
        public DbSet<WellnessPlan> WellnessPlans { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EDA_LAPTOP\MSSQLSERVER01;Database=Patient.WebUI;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }



    }
}
