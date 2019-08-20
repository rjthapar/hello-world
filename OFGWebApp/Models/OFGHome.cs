using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OFGWebApp.Models
{
    public class OFGHome
    {
        //JIRA Number Application Description Status Functionalities To Implement    Expected UAT Delivery Date  PROD Deployment Date Pending Info Comments

        //model to contain all the values for Weekly JIRA Updates
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Display(Name ="User Id")]
        public string userId { get; set; }
        [Display(Name = "JIRA Number")]
        public int jiraNumber { get; set; }
        [Display(Name = "Application Description")]
        public string applicationDescription { get; set; }
        [Display(Name = "Status")]
        public Status status { get; set; }
        [Display(Name = "Pending Functionalities")]
        public string functionalitiesToImplement { get; set; }
        [Display(Name = "Expected UAT Delivery Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime expectedUatDeliveryDate { get; set; }
        [Display(Name = "Expected PROD Delivery Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime prodDeploymentDate { get; set; }
        [Display(Name = "Pending Info")]
        public string pendingInfo { get; set; }
        [Display(Name = "Comments")]
        public string comments { get; set; }
    }
    public enum Status
    {
        INPROGRESS,
        OPEN,
        UAT,
        UATREVIEW,
        PROD,
        PRODREVIEW,
        CLOSED,
        PENDING

    }
}
    
