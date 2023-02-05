using System;
using System.Linq;
using System.Net.Http.Headers;
using congestion.calculator;
public class CongestionTaxCalculator
{
    /**
         * Calculate the total toll fee for one day
         *
         * @param vehicle - the vehicle
         * @param dates   - date and time of all passes on one day
         * @return - the total congestion tax for that day
         */

    public int GetTax(IVehicle vehicle, DateTime[] dates)
    {
        DateTime intervalStart = dates[0];
        int totalFee = 0;
        int tempFee = GetTollFee(intervalStart, vehicle);

        foreach (DateTime date in dates)
        {           
            int nextFee = GetTollFee(date, vehicle);           

            TimeSpan span = date - intervalStart;          
            if (span.TotalMinutes <= 60)
            {
                if (totalFee > 0) totalFee -= tempFee;
                if (nextFee >= tempFee) {
                    tempFee = nextFee;
                }                
                totalFee += tempFee;
            }
            else
            {
                intervalStart = date;
                totalFee += nextFee;                
            }
        }
        if (totalFee > 60) totalFee = 60;
        return totalFee;
    }

    public static bool IsTollFreeVehicle(IVehicle vehicle)
    {
        if (vehicle == null) return false;
        String vehicleType = vehicle.GetVehicleType();
        return vehicleType.Equals(TollFreeVehicles.Motorcycle.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Tractor.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Emergency.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Diplomat.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Foreign.ToString()) ||
               vehicleType.Equals(TollFreeVehicles.Military.ToString()) || vehicleType.Equals(TollFreeVehicles.Bus.ToString());
    }

    public static int GetTollFee(DateTime date, IVehicle vehicle)
    {

        int hour = date.Hour;
        int minute = date.Minute;
        if (IsTollFreeDate(date) || IsTollFreeVehicle(vehicle))
        {
            return 0;
        }
        else {

            if (hour == 6 && minute >= 0 && minute <= 29) return 8;
            else if (hour == 6 && minute >= 30 && minute <= 59) return 13;
            else if (hour == 7 && minute >= 0 && minute <= 59) return 18;
            else if (hour == 8 && minute >= 0 && minute <= 29) return 13;
            else if (hour >= 8 && hour <= 14 && minute >= 30 && minute <= 59) return 8;
            else if (hour == 15 && minute >= 0 && minute <= 29) return 13;
            else if (hour == 15 && minute >= 30 || hour == 16 && minute <= 59) return 18;
            else if (hour == 17 && minute >= 0 && minute <= 59) return 13;
            else if (hour == 18 && minute >= 0 && minute <= 29) return 8;
            else return 0;
        }
    }

    public static Boolean IsTollFreeDate(DateTime date)
    {
        int year = date.Year;

        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) return true;

        if (year == 2013)
        {
            if (IsHolidayExcept(date)) return true;
        }       
        return false;
    }

    public static bool IsHolidayExcept(DateTime date)
    {
        if (PublicHolidays.Holidays.Any(h =>
        (h.Date.Year == date.Year && h.Date.Month == date.Month && h.Date.Day == date.Day) || 
        (h.DayBefore().Year == date.Year && h.DayBefore().Month == date.Month && h.DayBefore().Day == date.Day))) {
            return true;
        }
        return false;
    }

    private enum TollFreeVehicles
    {
        Motorcycle = 0,
        Tractor = 1,
        Emergency = 2,
        Diplomat = 3,
        Foreign = 4,
        Military = 5,
        Bus = 6
    }
}