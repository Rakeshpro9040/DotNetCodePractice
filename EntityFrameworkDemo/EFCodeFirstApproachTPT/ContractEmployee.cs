using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.EFCodeFirstApproachTPT
{
    // [Table("ContractEmployees")]
    public class ContractEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public int HourlyPay { get; set; }
    }
}