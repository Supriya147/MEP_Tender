using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MEPTender.Models
{
    public class Employee
    {
        public string ProjectDetails { get; set; }
        [Required]
        public int Client { get; set; }
        [Required]
        public int Consultant { get; set; }
        [Required]
        public int Contractor { get; set; }

    }

    public class Client
    {
        public int Client_ID { get; set; }
        public string ClientName { get; set; }
    }

    public class Consultant
    {
        public int Consultant_ID { get; set; }
        public string ConsultantName { get; set; }
    }

    public class Contractor
    {
        public int Contractor_ID { get; set; }
        public string ContractorName { get; set; }
    }
}
