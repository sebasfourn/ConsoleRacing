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

var driver1 = new Driver("Ryan Tuerck");
var driver2 = new Driver("Chelsea DeNofa");
var driver3 = new Driver("Simen Olsen");
var driver4 = new Driver("Matt Field");
var driver5 = new Driver("Frederic Aasbo");
var driver6 = new Driver("Aurimas Bakchis");
var driver7 = new Driver("James Dean");
var driver8 = new Driver("Chris Forsberg");
var driver9 = new Driver("Dylan Hughes");
var driver10 = new Driver("Kazuya Taguchi");

race1.AddDriver(driver1);
race1.AddDriver(driver2);
race1.AddDriver(driver3);
race1.AddDriver(driver4);
race1.AddDriver(driver5);
race1.AddDriver(driver6);
race1.AddDriver(driver7);
race1.AddDriver(driver8);
race1.AddDriver(driver9);
race1.AddDriver(driver10);

// Console.WriteLine($"The 1st driver on the waiting list is: {waitingList[0]}");

race1.RemoveDriver(driver1);
