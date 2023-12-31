﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GymSystemEntities : DbContext
    {
        public GymSystemEntities()
            : base("name=GymSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<TraineesClassesEnrollment> TraineesClassesEnrollments { get; set; }
    
        public virtual int AddStaff(string name, string gender, Nullable<int> age, string phone, string jobTitle, Nullable<int> salary)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var jobTitleParameter = jobTitle != null ?
                new ObjectParameter("jobTitle", jobTitle) :
                new ObjectParameter("jobTitle", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddStaff", nameParameter, genderParameter, ageParameter, phoneParameter, jobTitleParameter, salaryParameter);
        }
    
        public virtual int AddTrainee(string name, string gender, Nullable<int> age, string phone, string @class, Nullable<int> duration)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var classParameter = @class != null ?
                new ObjectParameter("class", @class) :
                new ObjectParameter("class", typeof(string));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("duration", duration) :
                new ObjectParameter("duration", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTrainee", nameParameter, genderParameter, ageParameter, phoneParameter, classParameter, durationParameter);
        }
    
        public virtual int AddTrainer(string name, string gender, Nullable<int> age, string phone, string @class, Nullable<int> salary)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var classParameter = @class != null ?
                new ObjectParameter("class", @class) :
                new ObjectParameter("class", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTrainer", nameParameter, genderParameter, ageParameter, phoneParameter, classParameter, salaryParameter);
        }
    
        public virtual int DeleteClass(Nullable<int> classId)
        {
            var classIdParameter = classId.HasValue ?
                new ObjectParameter("ClassId", classId) :
                new ObjectParameter("ClassId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteClass", classIdParameter);
        }
    
        public virtual int DeleteStaff(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStaff", idParameter);
        }
    
        public virtual int DeleteTrainee(Nullable<int> traineeId)
        {
            var traineeIdParameter = traineeId.HasValue ?
                new ObjectParameter("TraineeId", traineeId) :
                new ObjectParameter("TraineeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTrainee", traineeIdParameter);
        }
    
        public virtual int DeleteTrainer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTrainer", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> MoneyGraphList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("MoneyGraphList");
        }
    
        public virtual ObjectResult<TraineePerEachClass_Result> TraineePerEachClass()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraineePerEachClass_Result>("TraineePerEachClass");
        }
    
        public virtual ObjectResult<TraineesPerClassMonths_Result> TraineesPerClassMonths()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraineesPerClassMonths_Result>("TraineesPerClassMonths");
        }
    }
}
