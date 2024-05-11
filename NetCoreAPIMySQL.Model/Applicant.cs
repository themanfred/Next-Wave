using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Model
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string First_name { get; set; }
        public string Last_names { get; set; }
        public string Dateofbirth { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }

}
