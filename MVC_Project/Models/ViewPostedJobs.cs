using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class ViewPostedJobs
    {
        public ViewPostedJobs()
        {
            ViewJob = new List<PostedJobs>();
        }
        public List<PostedJobs> ViewJob { get; set; }
    }
    public class PostedJobs
    {
        public int View_JId { get; set; }
        public int View_CId { get; set; }
        public string View_JobName { get; set; }
        public int View_Vacancy { get; set; }
        public string View_RequiredSkill { get; set; }
        public string View_Experience { get; set; }
        public string View_Qualification { get; set; }
        public int View_Salary { get; set; }
        public string View_Location { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime View_StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime View_EndDate { get; set; }
        public string View_Status { get; set; }

    }
}