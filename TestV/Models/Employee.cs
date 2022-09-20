using System.ComponentModel.DataAnnotations;

namespace TestV.Models
{
    public class Employee
    {

        public int id { get; set; }
        public string? vcName { get; set; }

        public string? vcEmail { get; set; }
        public string? vcAddress { get; set; }
        public int intPhone { get; set; }

        [DataType(DataType.Date)]
        public DateTime dtHire { get; set; }
        public decimal dcSalary{ get; set; }
    }
}
