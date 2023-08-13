

using congestion.calculator;

VehicleFactory<Car> vehicleFactory = new VehicleFactory<Car>();

var congestion = new CongestionTaxCalculator();
//congestion.MaxDailyFee = 12;
//congestion.MaxDailyMinute = 30;
DateTime[] dates = new DateTime[] { new DateTime(2013, 2, 08, 18, 29, 00), 
                                    new DateTime(2013, 2, 08, 15, 35, 00),
                                    new DateTime(2013, 2, 08, 20, 12, 00)                                    };
 
  var totalTax = congestion.GetTax(dates, vehicleFactory.CreateVehicle());
Console.WriteLine(totalTax);