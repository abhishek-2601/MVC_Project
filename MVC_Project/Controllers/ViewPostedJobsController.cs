using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;
using System.Data;
using System.Data.SqlClient;

namespace MVC_Project.Controllers
{
    public class ViewPostedJobsController : Controller
    {
        MVC_ProjectEntities dbobj = new MVC_ProjectEntities();
        // GET: ViewPostedJobs
        public ActionResult ViewPostedJobs_Load(ViewPostedJobs clsobj)
        {
            int uid = Convert.ToInt32(Session["uid"]);
            return View(GetPostedJobs(clsobj, uid));
        }
        private ViewPostedJobs GetPostedJobs(ViewPostedJobs clsobj, int uid)
        {
            using (var con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["test"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_checkpostedjobs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", uid);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                var joblist = new ViewPostedJobs();
                while (dr.Read())
                {
                    var jobcls = new PostedJobs();
                    jobcls.View_JId = Convert.ToInt32(dr["JobId"]);
                    jobcls.View_CId = Convert.ToInt32(dr["CId"]);
                    jobcls.View_JobName = dr["JobName"].ToString();
                    jobcls.View_Vacancy = Convert.ToInt32(dr["Vacancy"]);
                    jobcls.View_RequiredSkill = dr["RequiredSkill"].ToString();
                    jobcls.View_Experience = dr["Experience"].ToString();
                    jobcls.View_Qualification = dr["Qualification"].ToString();
                    jobcls.View_Salary = Convert.ToInt32(dr["Salary"]);
                    jobcls.View_Location = dr["Location"].ToString();
                    jobcls.View_StartDate = Convert.ToDateTime(dr["StartDate"].ToString());
                    jobcls.View_EndDate = Convert.ToDateTime(dr["EndDate"].ToString());
                    jobcls.View_Status = dr["JobStatus"].ToString();

                    joblist.ViewJob.Add(jobcls);

                }
                con.Close();
                return joblist;
            }
        }
    }
}