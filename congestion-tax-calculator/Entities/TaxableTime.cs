using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion.calculator
{
    public class TaxableTime
    {
        [Key]
       public Guid Id { get; set; }
       public int CityId { get; set; }
       public DateTime StartTime { get; set; }
       public DateTime Endtime { get; set; }
       public int Amount { get; set; }
       public string currency { get; set; } = "sek";

    }
}
