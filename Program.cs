var race1 = new Race("Long Beach");
var race2 = new Race("Road Atlanta");
var race3 = new Race("Orlando Speed World");

var races = new List<Race>() { race1, race2, race3 }
races.Add(race1);
races.Add(race2);
races.Add(race3);

PrintRaces();
foreach (Race race in races)
{
  Console.WriteLine($"{races.IndexOf(race) + 1}. {race.Name}");
}

PrintMenu();
{
  Console.WriteLine("1. See the drivers");
  Console.WriteLine("2. See the waiting list")
  Console.WriteLine("3. Add a driver to the race");
  Console.WriteLine("4. Remove a driver from the race");
  Console.WriteLine("5. Go back");
}

int choice = 0;

do
{
  Console.WriteLine("1. See all races");
  Console.WriteLine("2. Select a race");
  Console.WriteLine("3. Quit")
  string choiceString = Console.ReadLine();
  int choice = int.Parse(choiceString);

  switch (choice)
  {
    case 1:
      PrintRaces();
    break;

    case 2:
      PrintRaces();
      string raceChoiceString = Console.ReadLine();
      int raceChoice = int.Parse(raceChoiceString);

      int raceChoice = raceChoice switch
      {
        1 => race1
        2 => race2
        3 => race3
      }

      int userChoice = 0;

      do
      {
        PrintMenu();
        string userChoiceString = Console.ReadLine();
        int userChoice = int.Parse(userChoiceString);

        switch (userChoice)
        {
          case 1:

          break;

          case 2:
          break;

          case 3:
          break;

          case 4:
          break;

          default:
            Console.WriteLine("Wrong option!");
          break:
        }
      } while (userChoice != 5);
    break;

    default:
      Console.WriteLine("Wrong option!")
    break;
  }
} while (choice != 3);

// var driver1 = new Driver("Ryan Tuerck");
// var driver2 = new Driver("Chelsea DeNofa");
// var driver3 = new Driver("Simen Olsen");
// var driver4 = new Driver("Matt Field");
// var driver5 = new Driver("Frederic Aasbo");
// var driver6 = new Driver("Aurimas Bakchis");
// var driver7 = new Driver("James Dean");
// var driver8 = new Driver("Chris Forsberg");
// var driver9 = new Driver("Dylan Hughes");
// var driver10 = new Driver("Kazuya Taguchi");

// race1.AddDriver(driver1);
// race1.AddDriver(driver2);
// race1.AddDriver(driver3);
// race1.AddDriver(driver4);
// race1.AddDriver(driver5);
// race1.AddDriver(driver6);
// race1.AddDriver(driver7);
// race1.AddDriver(driver8);
// race1.AddDriver(driver9);
// race1.AddDriver(driver10);
