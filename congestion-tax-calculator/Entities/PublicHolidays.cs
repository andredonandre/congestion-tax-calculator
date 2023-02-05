using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion.calculator
{
    public class PublicHoliday
    {
        [Key]
        public int Id { get; set; }
       public string Name { get; set; }
       public DateTime Date { get; set; }

        public int? CountryId { get; set; }

        public DateTime DayBefore() {
            return Date.AddDays(-1);
        }
    }

    public static class PublicHolidays
    {
        public static readonly List<PublicHoliday> Holidays = new List<PublicHoliday>() { 
            
            new PublicHoliday() {Name = "New Year's Day", Date= new DateTime(2013,01,01)},
            new PublicHoliday() {Name = "Epiphany", Date= new DateTime(2013,01,06)},
            new PublicHoliday() {Name = "Good Friday", Date= new DateTime(2013,03,29)},
            new PublicHoliday() {Name = "Holy Saturday", Date= new DateTime(2013,03,30)},
            new PublicHoliday() {Name = "Easter Day", Date= new DateTime(2013,03,31)},
            new PublicHoliday() {Name = "Easter Monday", Date= new DateTime(2013,04,01)},
            new PublicHoliday() {Name = "May 1st", Date= new DateTime(2013,05,01)},
            new PublicHoliday() {Name = "Ascension Day", Date= new DateTime(2013,05,09)},
            new PublicHoliday() {Name = "Pentecost Eve", Date= new DateTime(2013,05,18)},
            new PublicHoliday() {Name = "Whit Sunday", Date= new DateTime(2013,05,19)},
            new PublicHoliday() {Name = "Sweden's National Day", Date= new DateTime(2013,06,06)},
            new PublicHoliday() {Name = "Midsummer Eve", Date= new DateTime(2013,06,21)},
            new PublicHoliday() {Name = "Midsummer Day", Date= new DateTime(2013,06,22)},
            new PublicHoliday() {Name = "All Saints day", Date= new DateTime(2013,11,02)},
            new PublicHoliday() {Name = "Christmas Eve", Date= new DateTime(2013,12,24)},
            new PublicHoliday() {Name = "Christmas Day", Date= new DateTime(2013,12,25)},
            new PublicHoliday() {Name = "Boxing Day", Date= new DateTime(2013,12,26)},
            new PublicHoliday() {Name = "New Year's Eve", Date= new DateTime(2013,12,26)}
        };
    }
}
