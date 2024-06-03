using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class ListApplicn
    {
        public ListApplicn()
        {
            ViewUser = new List<UserList>();
        }
        public List<UserList> ViewUser { get; set; }
    }
    public class UserList
    {
        public int ViewApplyId { get; set; }
        public int ViewJobId { get; set; }
        public int ViewCId { get; set; }
        public int ViewUId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ViewDate { get; set; }
        public string ViewResume { get; set; }
        public string ViewStatus { get; set; }
        public string ViewCompanyName { get; set; }
        public string ViewJobName { get; set; }
        public string ViewJobLocation { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public long phone { get; set; }
        public string email { get; set; }
        public string state { get; set; }
        public string district { get; set; }
        public int pincode { get; set; }
        public string qualification { get; set; }
        public decimal cgpa { get; set; }
        public string skills { get; set; }

    }
}
    
