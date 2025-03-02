using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaAkademiAgency.Entities
{
    public class ProjectDetails
    {
        public int ProjectDetailsId { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Projects { get; set; }
       
        
    }
}