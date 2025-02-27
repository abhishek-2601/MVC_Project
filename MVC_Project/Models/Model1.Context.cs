﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MVC_ProjectEntities : DbContext
    {
        public MVC_ProjectEntities()
            : base("name=MVC_ProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AddJob> AddJobs { get; set; }
        public virtual DbSet<ApplyJob> ApplyJobs { get; set; }
        public virtual DbSet<CompanyReg> CompanyRegs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<UserReg> UserRegs { get; set; }
    
        public virtual int sp_addJobs(Nullable<int> cid, string jobname, Nullable<int> vacancy, string reqSkill, string exp, string qual, Nullable<int> salary, string location, Nullable<System.DateTime> startdate, Nullable<System.DateTime> enddate, string cstatus)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var jobnameParameter = jobname != null ?
                new ObjectParameter("jobname", jobname) :
                new ObjectParameter("jobname", typeof(string));
    
            var vacancyParameter = vacancy.HasValue ?
                new ObjectParameter("vacancy", vacancy) :
                new ObjectParameter("vacancy", typeof(int));
    
            var reqSkillParameter = reqSkill != null ?
                new ObjectParameter("reqSkill", reqSkill) :
                new ObjectParameter("reqSkill", typeof(string));
    
            var expParameter = exp != null ?
                new ObjectParameter("exp", exp) :
                new ObjectParameter("exp", typeof(string));
    
            var qualParameter = qual != null ?
                new ObjectParameter("Qual", qual) :
                new ObjectParameter("Qual", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var enddateParameter = enddate.HasValue ?
                new ObjectParameter("enddate", enddate) :
                new ObjectParameter("enddate", typeof(System.DateTime));
    
            var cstatusParameter = cstatus != null ?
                new ObjectParameter("cstatus", cstatus) :
                new ObjectParameter("cstatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_addJobs", cidParameter, jobnameParameter, vacancyParameter, reqSkillParameter, expParameter, qualParameter, salaryParameter, locationParameter, startdateParameter, enddateParameter, cstatusParameter);
        }
    
        public virtual int sp_applyJob(Nullable<int> jobId, Nullable<int> cId, Nullable<int> uId, Nullable<System.DateTime> date, string resume, string status)
        {
            var jobIdParameter = jobId.HasValue ?
                new ObjectParameter("jobId", jobId) :
                new ObjectParameter("jobId", typeof(int));
    
            var cIdParameter = cId.HasValue ?
                new ObjectParameter("CId", cId) :
                new ObjectParameter("CId", typeof(int));
    
            var uIdParameter = uId.HasValue ?
                new ObjectParameter("UId", uId) :
                new ObjectParameter("UId", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var resumeParameter = resume != null ?
                new ObjectParameter("resume", resume) :
                new ObjectParameter("resume", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_applyJob", jobIdParameter, cIdParameter, uIdParameter, dateParameter, resumeParameter, statusParameter);
        }
    
        public virtual ObjectResult<sp_check_Result> sp_check(string qry)
        {
            var qryParameter = qry != null ?
                new ObjectParameter("qry", qry) :
                new ObjectParameter("qry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_check_Result>("sp_check", qryParameter);
        }
    
        public virtual ObjectResult<sp_checkappliedUsers_Result> sp_checkappliedUsers(Nullable<int> cid)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_checkappliedUsers_Result>("sp_checkappliedUsers", cidParameter);
        }
    
        public virtual int sp_checkApplyExist(Nullable<int> jid, Nullable<int> uid, ObjectParameter status)
        {
            var jidParameter = jid.HasValue ?
                new ObjectParameter("jid", jid) :
                new ObjectParameter("jid", typeof(int));
    
            var uidParameter = uid.HasValue ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_checkApplyExist", jidParameter, uidParameter, status);
        }
    
        public virtual ObjectResult<sp_checkpostedjobs_Result> sp_checkpostedjobs(Nullable<int> uid)
        {
            var uidParameter = uid.HasValue ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_checkpostedjobs_Result>("sp_checkpostedjobs", uidParameter);
        }
    
        public virtual ObjectResult<sp_company_profile_Result> sp_company_profile(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_company_profile_Result>("sp_company_profile", idParameter);
        }
    
        public virtual int sp_CompanyReg(Nullable<int> cid, string name, string addr, string email, Nullable<long> phone, string cstatus)
        {
            var cidParameter = cid.HasValue ?
                new ObjectParameter("cid", cid) :
                new ObjectParameter("cid", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var phoneParameter = phone.HasValue ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(long));
    
            var cstatusParameter = cstatus != null ?
                new ObjectParameter("cstatus", cstatus) :
                new ObjectParameter("cstatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CompanyReg", cidParameter, nameParameter, addrParameter, emailParameter, phoneParameter, cstatusParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_Logid(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_Logid", unaParameter, pwdParameter);
        }
    
        public virtual int sp_Login(Nullable<int> regid, string uname, string pwd, string utype)
        {
            var regidParameter = regid.HasValue ?
                new ObjectParameter("regid", regid) :
                new ObjectParameter("regid", typeof(int));
    
            var unameParameter = uname != null ?
                new ObjectParameter("uname", uname) :
                new ObjectParameter("uname", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            var utypeParameter = utype != null ?
                new ObjectParameter("utype", utype) :
                new ObjectParameter("utype", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Login", regidParameter, unameParameter, pwdParameter, utypeParameter);
        }
    
        public virtual int sp_LoginCheck(string una, string pwd, ObjectParameter status)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_LoginCheck", unaParameter, pwdParameter, status);
        }
    
        public virtual ObjectResult<string> sp_LogType(string una, string pwd)
        {
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_LogType", unaParameter, pwdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_MaxIdLogin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_MaxIdLogin");
        }
    
        public virtual int sp_profile_update(Nullable<int> uid, string name, string addr, Nullable<int> age, string gender, Nullable<long> phone, string email, string district, Nullable<int> pincode, Nullable<decimal> cgpa, string skills)
        {
            var uidParameter = uid.HasValue ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var phoneParameter = phone.HasValue ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(long));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var districtParameter = district != null ?
                new ObjectParameter("district", district) :
                new ObjectParameter("district", typeof(string));
    
            var pincodeParameter = pincode.HasValue ?
                new ObjectParameter("pincode", pincode) :
                new ObjectParameter("pincode", typeof(int));
    
            var cgpaParameter = cgpa.HasValue ?
                new ObjectParameter("cgpa", cgpa) :
                new ObjectParameter("cgpa", typeof(decimal));
    
            var skillsParameter = skills != null ?
                new ObjectParameter("skills", skills) :
                new ObjectParameter("skills", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_profile_update", uidParameter, nameParameter, addrParameter, ageParameter, genderParameter, phoneParameter, emailParameter, districtParameter, pincodeParameter, cgpaParameter, skillsParameter);
        }
    
        public virtual ObjectResult<sp_userProfile_Result> sp_userProfile(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_userProfile_Result>("sp_userProfile", idParameter);
        }
    
        public virtual int sp_UserReg(Nullable<int> uid, string name, string addr, Nullable<int> age, string gender, Nullable<long> phone, string email, string state, string district, Nullable<int> pincode, string qual, Nullable<decimal> cgpa, string skills, string ustatus)
        {
            var uidParameter = uid.HasValue ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var phoneParameter = phone.HasValue ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(long));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var districtParameter = district != null ?
                new ObjectParameter("district", district) :
                new ObjectParameter("district", typeof(string));
    
            var pincodeParameter = pincode.HasValue ?
                new ObjectParameter("pincode", pincode) :
                new ObjectParameter("pincode", typeof(int));
    
            var qualParameter = qual != null ?
                new ObjectParameter("qual", qual) :
                new ObjectParameter("qual", typeof(string));
    
            var cgpaParameter = cgpa.HasValue ?
                new ObjectParameter("cgpa", cgpa) :
                new ObjectParameter("cgpa", typeof(decimal));
    
            var skillsParameter = skills != null ?
                new ObjectParameter("skills", skills) :
                new ObjectParameter("skills", typeof(string));
    
            var ustatusParameter = ustatus != null ?
                new ObjectParameter("ustatus", ustatus) :
                new ObjectParameter("ustatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UserReg", uidParameter, nameParameter, addrParameter, ageParameter, genderParameter, phoneParameter, emailParameter, stateParameter, districtParameter, pincodeParameter, qualParameter, cgpaParameter, skillsParameter, ustatusParameter);
        }
    
        public virtual ObjectResult<sp_viewAppliedJobs_Result> sp_viewAppliedJobs(Nullable<int> uid)
        {
            var uidParameter = uid.HasValue ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_viewAppliedJobs_Result>("sp_viewAppliedJobs", uidParameter);
        }
    }
}
