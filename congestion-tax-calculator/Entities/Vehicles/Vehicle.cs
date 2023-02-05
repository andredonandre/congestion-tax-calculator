using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion.calculator
{
    public class Vehicle
    {
        [Key]
      public int Id { get; set; }
       public string Name { get; set; }
    }
}