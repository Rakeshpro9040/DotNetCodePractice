using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachTPH
{
    public class PermanentEmployee : Employee
    {
        [Column(Order = 5)]
        public int AnuualSalary { get; set; }
    }
}