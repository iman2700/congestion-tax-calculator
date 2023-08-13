using System;
using System.Collections.Generic;
using System.Linq;
using congestion.calculator;
using congestion.calculator.entity;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class CongestionTaxCalculator
{
    /**
         * Calculate the total toll fee for one day
         *
         * @param vehicle - the vehicle
         * @param dates   - date and time of all passes on one day
         * @return - the total congestion tax for that day
         */

    TimeAmountDbContext DbContext;

    public int MaxDailyMinute { get; set; } = 60;
    public int MaxDailyFee { get; set; } = 60;

    public CongestionTaxCalculator()
    {
        DbContext = new TimeAmountDbContext();

    }

    private int GetCappedFee(int totalFee)
    {
        if (totalFee > 60) return 60;
        return totalFee;
    }


    public int GetTax(DateTime[] dates, Vehicle vehicle)
    {
        int totalFee = 0;  
        double totalMinutes = 0;  
        int maxFeePerHour = 0; 

       
        for (int i = 1; i < dates.Length; i++)
        {
            // Calculate the time difference between consecutive dates.
            TimeSpan timeDifference = dates[i] - dates[i - 1];
            // Add the time difference to the total minutes.
            totalMinutes += timeDifference.TotalMinutes;
            // Get the toll fee for the previous date.
            int fee = GetTollFee(dates[i - 1], vehicle); 

            // Check if the total minutes are less than or equal to the maximum daily fee 
            if (totalMinutes <= MaxDailyFee && fee > maxFeePerHour)
            {
                // Update the maximum fee per hour.
                maxFeePerHour = fee;
            }

            totalFee += fee;  
        }

        // check if the total minutes exceed the maximum daily minutes.
        if (totalMinutes >= MaxDailyMinute)
        {
            // return the minimum value between the total fee and the maximum daily fee.
            return Math.Min(totalFee, MaxDailyFee); 
        }
        else
        {
            // return the maximum fee per hour.
            return maxFeePerHour; 
        }
    }

    private bool IsTollFreeVehicle(Vehicle vehicle)
    {
        // Validate input
        if (vehicle == null)
        {
            return false;
        }

        // Get vehicle type
        string vehicleType = vehicle.GetVehicleType();

        // Check if type is in toll-free list
        return Enum.IsDefined(typeof(TollFreeVehicles), vehicleType);
    }

    public int GetTollFee(DateTime date, Vehicle vehicle)
    {
        if (IsTollFreeDate(date) || IsTollFreeVehicle(vehicle)) return 0;

        var TollFree = DbContext.TimeAmounts
                .FirstOrDefault(t => t.StartTime <= date.TimeOfDay && t.EndTime >= date.TimeOfDay);

        return TollFree.Amount;
    }

    private bool IsTollFreeDate(DateTime date)
    {
        // Check weekends
        if (date.DayOfWeek == DayOfWeek.Saturday ||
           date.DayOfWeek == DayOfWeek.Sunday || date.Month == 7)
        {
            return true;
        }

        // Check date against toll-free dates
        return DbContext.FreeDates.Any(x => x.Date == date.Date);
    }


    private enum TollFreeVehicles
    {
        Motorcycle = 0,
        Tractor = 1,
        Emergency = 2,
        Diplomat = 3,
        Foreign = 4,
        Military = 5
    }
}