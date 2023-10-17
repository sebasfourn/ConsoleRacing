var race1 = new Race("Long Beach");
var race2 = new Race("Road Atlanta");
var race3 = new Race("Orlando Speed World");

var races = new List<Race>() { race1, race2, race3};

int choice = 0;
do
{
  PrintMenu();
  string? choiceString = Console.ReadLine();
  choice = int.Parse(choiceString ?? "0");

  switch (choice)
  {
    case 1:
      PrintRaces();
    break;

    case 2:
      int raceChoice = 0;
      do
      {
        PrintRaces();
        Console.WriteLine("4. Go back");
        string? raceChoiceString = Console.ReadLine();
        raceChoice = int.Parse(raceChoiceString ?? "0");

        if (raceChoice == 1 || raceChoice == 2 || raceChoice == 3)
        {
          Race race = raceChoice switch
          {
            1 => race1,
            2 => race2,
            3 => race3,
            _ => race1
          };

          int userChoice = 0;
          do
          {
            PrintOptions();
            string? userChoiceString = Console.ReadLine();
            userChoice = int.Parse(userChoiceString ?? "0");

            switch (userChoice)
            {
              case 1:
                if (race.Drivers.Any())
                {
                  PrintDrivers(race);
                }
                else
                {
                  PrintNoDrivers();
                }
              break;

              case 2:
                  if (race.WaitingList.Any())
                {
                  PrintWaitingList(race);
                }
                else
                {
                  PrintNoDrivers();
                }
              break;

              case 3:
                Console.WriteLine("What's the driver name?");
                string? driverName = Console.ReadLine();
                var driver = new Driver(driverName ?? "0");
                race.AddDriver(driver);
              break;

              case 4:
                if (race.Drivers.Any())
                {
                  Console.WriteLine("Choose a driver:");
                  PrintDrivers(race);
                  string? driverChoiceString = Console.ReadLine();
                  int driverChoice = int.Parse(driverChoiceString ?? "0");
                  race.RemoveDriver(driverChoice - 1);
                }
                else
                {
                  PrintNoDrivers();
                }
              break;
            }
          } while (userChoice != 5);
        }
      } while (raceChoice != 4);
    break;
  }
} while (choice != 3);

// Functions

void PrintMenu()
{
  Console.WriteLine("Choose an option:");
  Console.WriteLine("1. See all races");
  Console.WriteLine("2. Select a race");
  Console.WriteLine("3. Quit");
}

void PrintRaces()
{
  foreach (Race race in races)
  {
    Console.WriteLine($"{races.IndexOf(race) + 1}. {race.Name}");
  }
}

void PrintOptions()
{
  Console.WriteLine("Choose an option:");
  Console.WriteLine("1. See the drivers");
  Console.WriteLine("2. See the waiting list");
  Console.WriteLine("3. Add a driver to the race");
  Console.WriteLine("4. Remove a driver from the race");
  Console.WriteLine("5. Go back");
}

void PrintDrivers(Race race)
{
  foreach (Driver driver in race.Drivers)
  {
    Console.WriteLine($"{race.Drivers.IndexOf(driver) + 1}. {driver.Name}");
  }
}

void PrintWaitingList(Race race)
{
  foreach (Driver driver in race.WaitingList)
  {
    Console.WriteLine($"{driver.Name}");
  }
}

void PrintNoDrivers()
{
  Console.WriteLine("No drivers yet!");
}
