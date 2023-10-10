var race1 = new Race("Long Beach", "2023, 04, 07", "Long Beach");
var race2 = new Race("Road Atlanta", "2023, 05, 11", "Atlanta");
var race3 = new Race("Orlando Speed World", "2023, 05, 26", "Orlando");

var calendar = new List<Race>();
calendar.Add(race1);
calendar.Add(race2);
calendar.Add(race3);

Console.WriteLine($"Name: {calendar[0].Name}, Date: {calendar[0].Date}, City: {calendar[0].City}");
Console.WriteLine($"Name: {calendar[1].Name}, Date: {calendar[1].Date}, City: {calendar[1].City}");
Console.WriteLine($"Name: {calendar[2].Name}, Date: {calendar[2].Date}, City: {calendar[2].City}");

// var driver1 = new Driver("Ryan Tuerck");
// race1.AddDriver(driver1);
// Console.WriteLine(race1);
