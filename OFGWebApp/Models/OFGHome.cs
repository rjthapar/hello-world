using System;
using System.Collections.Generic;
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
        public string userId { get; set; }
        public int jiraNumber { get; set; }
        public string applicationDescription { get; set; }
        public Status status { get; set; }
        public string functionalitiesToImplement { get; set; }
        public DateTime expectedUatDeliveryDate { get; set; }
        public DateTime prodDeploymentDate { get; set; }
        public string pendingInfo { get; set; }
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
    
