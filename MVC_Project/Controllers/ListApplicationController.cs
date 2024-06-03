using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class ListApplicationController : Controller
    {
        MVC_ProjectEntities dbobj = new MVC_ProjectEntities();
        // GET: ListApplication
        public ActionResult Applications_Load(ListApplicn clsobj)
        {
            int cid = Convert.ToInt32(Session["uid"]);
            return View(GetApplications(clsobj, cid));
        }
        private ListApplicn GetApplications(ListApplicn clsobj, int cid)
        {
            using (var con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["test"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_checkappliedUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cid", cid);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var userlist = new ListApplicn();
                while (dr.Read())
                {
                    var usercls = new UserList();
                    usercls.ViewApplyId = Convert.ToInt32(dr["ApplyId"]);
                    usercls.ViewJobId = Convert.ToInt32(dr["JobId"]);
                    usercls.ViewCId = Convert.ToInt32(dr["CId"]);
                    usercls.ViewUId = Convert.ToInt32(dr["UId"]);
                    usercls.ViewDate = Convert.ToDateTime(dr["Date"]);
                    usercls.ViewResume = dr["Resume"].ToString();
                    usercls.ViewStatus = dr["ApplyStatus"].ToString();

                    var name = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Name).FirstOrDefault();
                    usercls.name = name;
                    var jobname = dbobj.AddJobs.Where(c => c.JobId == usercls.ViewJobId).Select(c => c.JobName).FirstOrDefault();
                    usercls.ViewJobName = jobname;
                    var age = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Age).FirstOrDefault();
                    usercls.age = age;
                    var address = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Address).FirstOrDefault();
                    usercls.address = address;
                    var gender = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Gender).FirstOrDefault();
                    usercls.gender = gender;
                    var phone = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Phone).FirstOrDefault();
                    usercls.phone = phone;
                    var email = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Email).FirstOrDefault();
                    usercls.email = email;
                    var state = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.State).FirstOrDefault();
                    usercls.state = state;
                    var district = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.District).FirstOrDefault();
                    usercls.district = district;
                    var pincode = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Pincode).FirstOrDefault();
                    usercls.pincode = pincode;
                    var qualification = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Qualification).FirstOrDefault();
                    usercls.qualification = qualification;
                    var CGPA = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.CGPA).FirstOrDefault();
                    usercls.cgpa = CGPA;
                    var skills = dbobj.UserRegs.Where(c => c.UId == usercls.ViewUId).Select(c => c.Skills).FirstOrDefault();
                    usercls.skills = skills;
                    var location = dbobj.AddJobs.Where(c => c.CId == usercls.ViewCId).Select(c => c.Location).FirstOrDefault();
                    usercls.ViewJobLocation = location;
                    userlist.ViewUser.Add(usercls);

                }
                con.Close();
                return userlist;
            }
        }
    }
}